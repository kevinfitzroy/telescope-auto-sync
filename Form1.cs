using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASCOM;
using ASCOM.DriverAccess;
using ASCOM.Utilities;
using System.Net;
using System.Net.Sockets;
using System.IO;
using nom.tam.fits;
using nom.tam.image;
using nom.tam.util;
namespace AutoSync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Title.Parent = this.TitlePic;
            this.btnAnalyze.Enabled = false;
            this.btnSync.Enabled = false;
        }
        private  const string CONNECT_BUTTON_ON = "Connect";
        private  const string CONNECT_BUTTON_OFF = "Disconnect";
        private Telescope objTelescope;
        private Camera objCamera;
        private FilterWheel objFilterWheel;
        private ASCOM.Utilities.Util util = new Util();

        private double oneStarRa;
        private double oneStarDec;

        private string currentPath = "";
        private AnalyzeResult curentAnalyzeResult;
        private void drivebtn_Click(object sender, EventArgs e)
        {
            var obj = new ASCOM.Utilities.Chooser();
            obj.DeviceType = "Telescope";
            Properties.Settings.Default.Telescope = obj.Choose(Properties.Settings.Default.Telescope);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (connectBtnStatus(btnConnect))
            {
                objTelescope.Connected = false;
                timer1.Stop();
            }
            else
            {
                try
                {
                    objTelescope = new Telescope(Properties.Settings.Default.Telescope);
                }
                catch(Exception ex)
                {
                    Log(ex.Message);
                    return;
                }
                objTelescope.Connected = true;
                
                timer1.Start();
            }
            switchBtnStatus(btnConnect);
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            bool connected;
            try
            {
                connected = objTelescope.Connected;
            }catch(Exception)
            {
                connected = false;
            }

            if (connected)
            {
                update();
            }
            else
            {
                switchBtnStatusWhen(btnConnect, true);
                timer1.Stop();
            }
        }
        private void update()
        {
            tbSiderealTime.Text = util.HoursToHMS( objTelescope.SiderealTime);
            tbRA.Text = util.HoursToHMS(objTelescope.RightAscension);
            tbDEC.Text = util.DegreesToDMS(objTelescope.Declination);
            tbAz.Text = util.DegreesToDM(objTelescope.Azimuth);
            tbAlt.Text = util.DegreesToDM(objTelescope.Altitude);
            //objTelescope.
        }
       
        private void btnCameraChoose_Click(object sender, EventArgs e)
        {
            var obj = new Chooser();
            obj.DeviceType = "Camera";
            Properties.Settings.Default.Camera = obj.Choose(Properties.Settings.Default.Camera);
        }

        private void btnCameraConnect_Click(object sender, EventArgs e)
        {
            if (connectBtnStatus(btnCameraConnect))
            {
                objCamera.Connected = false;
                objCamera.Dispose();
                btnExpose.Enabled = false;
                tbExposeTime.Enabled = false;
            }
            else
            {
                try
                {
                    objCamera = new Camera(Properties.Settings.Default.Camera);
                }
                catch (Exception ex)
                {
                    Log(ex.Message);
                    return;
                }
                
                objCamera.Connected = true;
                btnExpose.Enabled = true;
                tbExposeTime.Enabled = true;
            }
            switchBtnStatus(btnCameraConnect);
        }

        private void btnFilterWheelChoose_Click(object sender, EventArgs e)
        {
            var obj = new Chooser();
            obj.DeviceType = "FilterWheel";
            Properties.Settings.Default.FilterWheel = obj.Choose(Properties.Settings.Default.FilterWheel);
        }

        private void btnFilterWheelConnect_Click(object sender, EventArgs e)
        {
            if (connectBtnStatus(btnFilterWheelConnect))
            {
                objFilterWheel.Connected = false;
                objFilterWheel.Dispose();
                btnFilterWheel.Enabled = false;
                drolsFilterWheel.Enabled = false;
                timerFilterWheel.Stop();
            }
            else
            {
                try
                {
                    objFilterWheel = new FilterWheel(Properties.Settings.Default.FilterWheel);
                }
                catch (Exception ex)
                {
                    Log(ex.Message);
                    return;
                }
                
                objFilterWheel.Connected = true;
                drolsFilterWheel.Items.Clear();
                drolsFilterWheel.Items.AddRange(objFilterWheel.Names);
                while (objFilterWheel.Position < 0)
                {
                    System.Threading.Thread.Sleep(100);
                }
                drolsFilterWheel.SelectedIndex = objFilterWheel.Position;
                updateFilterWheelStatus();
                timerFilterWheel.Start();
                btnFilterWheel.Enabled = true;
                drolsFilterWheel.Enabled = true;
            }
            switchBtnStatus(btnFilterWheelConnect);
        }
        int lastFilterWheelPosition = -1;
        private void updateFilterWheelStatus()
        {
            try
            {

                if(objFilterWheel.Position >= 0)
                {

                    tbCurrentFilterWheel.Text = objFilterWheel.Names[objFilterWheel.Position];
                    if(lastFilterWheelPosition != objFilterWheel.Position)
                    {
                        Log("update FilterWheel to " + tbCurrentFilterWheel.Text);
                    }
                    lastFilterWheelPosition = objFilterWheel.Position;
                }
            }
            catch
            {
                timerFilterWheel.Stop();
                switchBtnStatusWhen(btnFilterWheelConnect, true);
            }
        }
        private void btnFilterWheel_Click(object sender, EventArgs e)
        {
            objFilterWheel.Position = Convert.ToInt16(drolsFilterWheel.SelectedIndex);
            btnFilterWheel.Enabled = false;
            while(objFilterWheel.Position < 0)
            {
                System.Threading.Thread.Sleep(100);
            }
            btnFilterWheel.Enabled = true;
            tbCurrentFilterWheel.Text = objFilterWheel.Names[objFilterWheel.Position];
        }

        private void timerFilterWheel_Tick(object sender, EventArgs e)
        {
            updateFilterWheelStatus();
        }

        private void switchBtnStatus(Button btn)
        {
            if (connectBtnStatus(btn))
            {
                btn.Text = CONNECT_BUTTON_ON;
            }
            else
            {
                btn.Text = CONNECT_BUTTON_OFF;
            }
        }
        // if connect  return true,else return false
        private bool connectBtnStatus(Button btn)
        {
            return btn.Text == CONNECT_BUTTON_OFF;
        }
        private void switchBtnStatusWhen(Button btn, bool when)
        {
            if (connectBtnStatus(btn) == when)
            {
                switchBtnStatus(btn);
            }
        }
        void Log(string s)
        {
            logBox.AppendText(DateTime.Now.ToString());
            logBox.AppendText("\t");
            logBox.AppendText(s);
            logBox.AppendText("\r\n");
        }
        void Log(int d)
        {
            Log(d.ToString());
        }

        private void tbExposeTime_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbExposeTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnExpose_Click(object sender, EventArgs e)
        {


            string expTime_s = tbExposeTime.Text;
            int expTime = 5;
            try
            {
                expTime = int.Parse(expTime_s);
                if(expTime <1 || expTime > 600)
                {
                    throw new Exception("expTime too big or small");
                }
            }
            catch
            {
                Log("exposeTime parse error,will exposing 5 seconds");
            }


            objCamera.StartExposure(expTime, true);
            
            while(!objCamera.ImageReady)
            {
                System.Threading.Thread.Sleep(1000);
                Log("exposing...");
            }
            Log("expose done,ImageReady");
            object imageArrObj = objCamera.ImageArray;
            BasicHDU h;
            if (imageArrObj.GetType().FullName == "System.Int32[,]")
            {
                Log("The Camera Output 32 bit Image Data");
                int[,] imagearray = (int[,])imageArrObj;
                int[][] arr = new int[imagearray.GetLength(0)][];
                for (int x = 0; x < imagearray.GetLength(0); x++)
                {
                    int[] colum = new int[imagearray.GetLength(1)];
                    for (int y = 0; y < imagearray.GetLength(1); y++)
                    {
                        colum[y] = imagearray[x, y];
                    }
                    arr[x] = colum;
                }
                h = FitsFactory.HDUFactory(arr);
            }
            else if(imageArrObj.GetType().FullName == "System.Int16[,]")
            {
                Log("The Camera Output 16 bit Image Data");
                Int16[,] imagearray = (Int16[,])imageArrObj;
                Int16[][] arr = new Int16[imagearray.GetLength(0)][];
                for (Int16 x = 0; x < imagearray.GetLength(0); x++)
                {
                    Int16[] colum = new Int16[imagearray.GetLength(1)];
                    for (Int16 y = 0; y < imagearray.GetLength(1); y++)
                    {
                        colum[y] = imagearray[x, y];
                    }
                    arr[x] = colum;
                }
                h = FitsFactory.HDUFactory(arr);
            }
            else
            {
                Log(imageArrObj.GetType().FullName);
                Log("Unknown Camera Output");
                return;
            }
           
            Fits fits = new Fits();
            fits.AddHDU(h);
            string path = System.IO.Path.GetTempPath() + System.Guid.NewGuid().ToString() + ".fit";
            BufferedDataStream fs = new BufferedDataStream(new FileStream(path , FileMode.Create));
            fits.Write(fs);
            fs.Close();
            setCurrentPath(path);
        }

        //slew mount to some where
        private void btnSlew_Click(object sender, EventArgs e)
        {
            oneStarRa = objTelescope.RightAscension;
            oneStarDec = objTelescope.Declination;
            //objTelescope.SlewToCoordinates(oneStarRa, oneStarDec);
            while (objTelescope.Slewing)
            {
                System.Threading.Thread.Sleep(100);
            }
            objTelescope.Tracking = true;
            Log("Slew to One Star Position Done");
        }
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (currentPath.Equals(""))
            {
                Log("Please Captcha a Image");
                return;
            }
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                clientSocket.Connect( "localhost", 3040);
            }
            catch(Exception ex)
            {
                Log(ex.Message);
                return;
            }
            Log("Start Analyze,Wait a monent");
            string resolvePath = this.currentPath.Replace('\\', '/');
            string queryCode = getSkyxQueryCode(resolvePath, 0.81);
            byte[] bytdata = System.Text.Encoding.Default.GetBytes(queryCode);
            clientSocket.Send(bytdata);
            byte[] recByt = new byte[200];
            clientSocket.Receive(recByt);
            string analyzeRes = System.Text.Encoding.Default.GetString(recByt);
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
            Log("Analyze Done : "+ analyzeRes);
            if(analyzeRes.IndexOf('|') > -1)
            {
                string[] arr = analyzeRes.Split('|');
                try
                {
                    this.curentAnalyzeResult =  Newtonsoft.Json.JsonConvert.DeserializeObject<AnalyzeResult>(arr[0]);
                }catch(Exception ex)
                {
                    Log(ex.Message);
                    return;
                }
                this.btnSync.Enabled = true;
                Log(this.curentAnalyzeResult.ToString());
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            if(this.curentAnalyzeResult == null)
            {
                Log("must Analyze,to get currentPosition");
                return;
            }
            //TODO check one star position 

            if (connectBtnStatus(btnConnect))
            {
                if (!objTelescope.Tracking)
                {
                    Log("Sync Telescope need Tracking!");
                    return;
                }
                double ra = 2 * oneStarRa - this.curentAnalyzeResult.RA;
                double dec = 2 * oneStarDec - this.curentAnalyzeResult.DEC;
                if(Math.Abs(dec) > 90)
                {

                    /*
                    dec = dec - 2 * (dec % 90);
                    ra = (oneStarRa + 12) % 24 - this.curentAnalyzeResult.RA + oneStarRa;
                   
                 
                    Log("DEBUG:ra + 12");
                    */
                }
                ra = (ra + 24) % 24;
                Log(String.Format("Slew to target RA: {0}   DEC: {1}",util.HoursToHMS(ra),util.DegreesToDMS(dec)));
                objTelescope.SlewToCoordinates(ra, dec);
                System.Threading.Thread.Sleep(1000);
                if (objTelescope.Tracking)
                {
                    objTelescope.SyncToCoordinates(oneStarRa, oneStarDec);
                }
                else
                {
                    Log("Telescope is not Tracking");
                }
                //TODO 
                Log("Sync Success");
            }
            else
            {
                Log("Please Connect Telescope!");
            }
        }

        class AnalyzeResult{
            public int errorCode { get; set; }
            public double RA { get; set; }
            public double DEC { set; get; }
            public int startCount { set; get; }

            private ASCOM.Utilities.Util util = new Util();
            override
            public string ToString()
            {
                return string.Format("\r\nAnalyze Result : \r\n\t        RA : {0}\r\n\t       DEC : {1}\r\n\tstartCount : {2}",util.HoursToHMS( RA),util.DegreesToDMS( DEC), startCount);
            }
        }

        private  string [] skyxQueryCodeTemplate = new string[3] { "/* Java Script */ImageLink.pathToFITS='", "';ImageLink.scale=", ";ImageLink.execute();var Out = '';Out=JSON.stringify({errorCode:ImageLinkResults.errorCode,RA:ImageLinkResults.imageCenterRAJ2000,DEC:ImageLinkResults.imageCenterDecJ2000,startCount:ImageLinkResults.catalogStarCount})" };
        private String getSkyxQueryCode(string path,double imageScale)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(skyxQueryCodeTemplate[0]);
            sb.Append(path);
            sb.Append(skyxQueryCodeTemplate[1]);
            sb.Append(imageScale);
            sb.Append(skyxQueryCodeTemplate[2]);
            return sb.ToString();
        }

        private void btnChooseFits_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "E:\\CCD";
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();
            tbFitsFile.Text = openFileDialog1.FileName;
            setCurrentPath(openFileDialog1.FileName);
        }

        private void setCurrentPath(string currentPath)
        {
            this.currentPath = currentPath;
            Log("SetCurrent Path : "+ currentPath);
            this.btnAnalyze.Enabled = true;

        }

        //unused
        private void button1_Click(object sender, EventArgs e)
        {
            Fits f = new Fits("E:\\CCD\\2020-04-03\\NGC7000\\NGC7000_0100_0001H.fit");
            ImageHDU hh = (ImageHDU)f.ReadHDU();

            Array[] arr = (Array[])hh.Kernel;

            Log((arr[0].GetValue(0)).GetType().FullName);
            Log("rank" + arr.Rank);

            
            Fits fits = new Fits();
            BasicHDU h = FitsFactory.HDUFactory(arr);
            fits.AddHDU(h);

            string path = System.IO.Path.GetTempPath() + System.Guid.NewGuid().ToString() + ".fit";
            BufferedDataStream fs = new BufferedDataStream(new FileStream(path, FileMode.Create));
            fits.Write(fs);
            fs.Close();
            setCurrentPath(path);
        }

        
    }
}
