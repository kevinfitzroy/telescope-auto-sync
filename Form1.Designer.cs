namespace AutoSync
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTeleScopeChoose = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbSiderealTime = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRA = new System.Windows.Forms.TextBox();
            this.tbDEC = new System.Windows.Forms.TextBox();
            this.tbAz = new System.Windows.Forms.TextBox();
            this.tbAlt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCameraChoose = new System.Windows.Forms.Button();
            this.btnCameraConnect = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.btnFilterWheelConnect = new System.Windows.Forms.Button();
            this.btnFilterWheelChoose = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbCameraChoose = new System.Windows.Forms.TextBox();
            this.tbTeleScopeChoose = new System.Windows.Forms.TextBox();
            this.drolsFilterWheel = new System.Windows.Forms.ComboBox();
            this.btnFilterWheel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCurrentFilterWheel = new System.Windows.Forms.TextBox();
            this.timerFilterWheel = new System.Windows.Forms.Timer(this.components);
            this.tbExposeTime = new System.Windows.Forms.TextBox();
            this.btnExpose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSlew = new System.Windows.Forms.Button();
            this.btnChooseFits = new System.Windows.Forms.Button();
            this.tbFitsFile = new System.Windows.Forms.TextBox();
            this.btnSync = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TitlePic = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Title = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTeleScopeChoose
            // 
            this.btnTeleScopeChoose.Location = new System.Drawing.Point(193, 118);
            this.btnTeleScopeChoose.Name = "btnTeleScopeChoose";
            this.btnTeleScopeChoose.Size = new System.Drawing.Size(141, 23);
            this.btnTeleScopeChoose.TabIndex = 0;
            this.btnTeleScopeChoose.Text = "Choose Telescope";
            this.btnTeleScopeChoose.UseVisualStyleBackColor = true;
            this.btnTeleScopeChoose.Click += new System.EventHandler(this.drivebtn_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(340, 118);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbSiderealTime
            // 
            this.tbSiderealTime.CausesValidation = false;
            this.tbSiderealTime.Location = new System.Drawing.Point(51, 304);
            this.tbSiderealTime.Name = "tbSiderealTime";
            this.tbSiderealTime.ReadOnly = true;
            this.tbSiderealTime.Size = new System.Drawing.Size(124, 21);
            this.tbSiderealTime.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "LST:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "RA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "DEC:";
            // 
            // tbRA
            // 
            this.tbRA.CausesValidation = false;
            this.tbRA.Location = new System.Drawing.Point(51, 332);
            this.tbRA.Name = "tbRA";
            this.tbRA.ReadOnly = true;
            this.tbRA.Size = new System.Drawing.Size(124, 21);
            this.tbRA.TabIndex = 9;
            // 
            // tbDEC
            // 
            this.tbDEC.CausesValidation = false;
            this.tbDEC.Location = new System.Drawing.Point(51, 359);
            this.tbDEC.Name = "tbDEC";
            this.tbDEC.ReadOnly = true;
            this.tbDEC.Size = new System.Drawing.Size(124, 21);
            this.tbDEC.TabIndex = 10;
            // 
            // tbAz
            // 
            this.tbAz.CausesValidation = false;
            this.tbAz.Location = new System.Drawing.Point(51, 386);
            this.tbAz.Name = "tbAz";
            this.tbAz.ReadOnly = true;
            this.tbAz.Size = new System.Drawing.Size(124, 21);
            this.tbAz.TabIndex = 11;
            // 
            // tbAlt
            // 
            this.tbAlt.CausesValidation = false;
            this.tbAlt.Location = new System.Drawing.Point(51, 413);
            this.tbAlt.Name = "tbAlt";
            this.tbAlt.ReadOnly = true;
            this.tbAlt.Size = new System.Drawing.Size(124, 21);
            this.tbAlt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "Az:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alt:";
            // 
            // btnCameraChoose
            // 
            this.btnCameraChoose.Location = new System.Drawing.Point(193, 151);
            this.btnCameraChoose.Name = "btnCameraChoose";
            this.btnCameraChoose.Size = new System.Drawing.Size(141, 23);
            this.btnCameraChoose.TabIndex = 16;
            this.btnCameraChoose.Text = "Choose Camera";
            this.btnCameraChoose.UseVisualStyleBackColor = true;
            this.btnCameraChoose.Click += new System.EventHandler(this.btnCameraChoose_Click);
            // 
            // btnCameraConnect
            // 
            this.btnCameraConnect.Location = new System.Drawing.Point(340, 151);
            this.btnCameraConnect.Name = "btnCameraConnect";
            this.btnCameraConnect.Size = new System.Drawing.Size(75, 23);
            this.btnCameraConnect.TabIndex = 17;
            this.btnCameraConnect.Text = "Connect";
            this.btnCameraConnect.UseVisualStyleBackColor = true;
            this.btnCameraConnect.Click += new System.EventHandler(this.btnCameraConnect_Click);
            // 
            // logBox
            // 
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logBox.Location = new System.Drawing.Point(436, 118);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(430, 324);
            this.logBox.TabIndex = 19;
            // 
            // btnFilterWheelConnect
            // 
            this.btnFilterWheelConnect.Location = new System.Drawing.Point(340, 205);
            this.btnFilterWheelConnect.Name = "btnFilterWheelConnect";
            this.btnFilterWheelConnect.Size = new System.Drawing.Size(75, 23);
            this.btnFilterWheelConnect.TabIndex = 22;
            this.btnFilterWheelConnect.Text = "Connect";
            this.btnFilterWheelConnect.UseVisualStyleBackColor = true;
            this.btnFilterWheelConnect.Click += new System.EventHandler(this.btnFilterWheelConnect_Click);
            // 
            // btnFilterWheelChoose
            // 
            this.btnFilterWheelChoose.Location = new System.Drawing.Point(193, 205);
            this.btnFilterWheelChoose.Name = "btnFilterWheelChoose";
            this.btnFilterWheelChoose.Size = new System.Drawing.Size(141, 23);
            this.btnFilterWheelChoose.TabIndex = 21;
            this.btnFilterWheelChoose.Text = "Choose FilterWheel";
            this.btnFilterWheelChoose.UseVisualStyleBackColor = true;
            this.btnFilterWheelChoose.Click += new System.EventHandler(this.btnFilterWheelChoose_Click);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AutoSync.Properties.Settings.Default, "FilterWheel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(24, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(151, 21);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = global::AutoSync.Properties.Settings.Default.FilterWheel;
            // 
            // tbCameraChoose
            // 
            this.tbCameraChoose.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AutoSync.Properties.Settings.Default, "Camera", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbCameraChoose.Location = new System.Drawing.Point(24, 151);
            this.tbCameraChoose.Name = "tbCameraChoose";
            this.tbCameraChoose.ReadOnly = true;
            this.tbCameraChoose.Size = new System.Drawing.Size(151, 21);
            this.tbCameraChoose.TabIndex = 15;
            this.tbCameraChoose.Text = global::AutoSync.Properties.Settings.Default.Camera;
            // 
            // tbTeleScopeChoose
            // 
            this.tbTeleScopeChoose.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AutoSync.Properties.Settings.Default, "Telescope", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbTeleScopeChoose.Location = new System.Drawing.Point(24, 120);
            this.tbTeleScopeChoose.Name = "tbTeleScopeChoose";
            this.tbTeleScopeChoose.ReadOnly = true;
            this.tbTeleScopeChoose.Size = new System.Drawing.Size(151, 21);
            this.tbTeleScopeChoose.TabIndex = 1;
            this.tbTeleScopeChoose.Text = global::AutoSync.Properties.Settings.Default.Telescope;
            // 
            // drolsFilterWheel
            // 
            this.drolsFilterWheel.Enabled = false;
            this.drolsFilterWheel.FormattingEnabled = true;
            this.drolsFilterWheel.Location = new System.Drawing.Point(193, 244);
            this.drolsFilterWheel.Name = "drolsFilterWheel";
            this.drolsFilterWheel.Size = new System.Drawing.Size(121, 20);
            this.drolsFilterWheel.TabIndex = 23;
            // 
            // btnFilterWheel
            // 
            this.btnFilterWheel.Enabled = false;
            this.btnFilterWheel.Location = new System.Drawing.Point(320, 242);
            this.btnFilterWheel.Name = "btnFilterWheel";
            this.btnFilterWheel.Size = new System.Drawing.Size(95, 23);
            this.btnFilterWheel.TabIndex = 24;
            this.btnFilterWheel.Text = "ChangeFilter";
            this.btnFilterWheel.UseVisualStyleBackColor = true;
            this.btnFilterWheel.Click += new System.EventHandler(this.btnFilterWheel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "Current Filter:";
            // 
            // tbCurrentFilterWheel
            // 
            this.tbCurrentFilterWheel.Location = new System.Drawing.Point(119, 244);
            this.tbCurrentFilterWheel.Name = "tbCurrentFilterWheel";
            this.tbCurrentFilterWheel.ReadOnly = true;
            this.tbCurrentFilterWheel.Size = new System.Drawing.Size(56, 21);
            this.tbCurrentFilterWheel.TabIndex = 26;
            // 
            // timerFilterWheel
            // 
            this.timerFilterWheel.Interval = 1000;
            this.timerFilterWheel.Tick += new System.EventHandler(this.timerFilterWheel_Tick);
            // 
            // tbExposeTime
            // 
            this.tbExposeTime.Enabled = false;
            this.tbExposeTime.Location = new System.Drawing.Point(98, 22);
            this.tbExposeTime.Name = "tbExposeTime";
            this.tbExposeTime.Size = new System.Drawing.Size(33, 21);
            this.tbExposeTime.TabIndex = 28;
            this.tbExposeTime.Text = "5";
            this.tbExposeTime.TextChanged += new System.EventHandler(this.tbExposeTime_TextChanged);
            this.tbExposeTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbExposeTime_KeyPress);
            // 
            // btnExpose
            // 
            this.btnExpose.Enabled = false;
            this.btnExpose.Location = new System.Drawing.Point(137, 21);
            this.btnExpose.Name = "btnExpose";
            this.btnExpose.Size = new System.Drawing.Size(85, 23);
            this.btnExpose.TabIndex = 29;
            this.btnExpose.Text = "Expose";
            this.btnExpose.UseVisualStyleBackColor = true;
            this.btnExpose.Click += new System.EventHandler(this.btnExpose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "ExposeTime(s):";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(82, 98);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(67, 50);
            this.btnAnalyze.TabIndex = 31;
            this.btnAnalyze.Text = "Analyze Picture";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 94);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FilterWheel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSlew);
            this.groupBox2.Controls.Add(this.btnChooseFits);
            this.groupBox2.Controls.Add(this.tbFitsFile);
            this.groupBox2.Controls.Add(this.btnSync);
            this.groupBox2.Controls.Add(this.btnAnalyze);
            this.groupBox2.Controls.Add(this.btnExpose);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbExposeTime);
            this.groupBox2.Location = new System.Drawing.Point(193, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 162);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sync Control Panel";
            // 
            // btnSlew
            // 
            this.btnSlew.Location = new System.Drawing.Point(9, 98);
            this.btnSlew.Name = "btnSlew";
            this.btnSlew.Size = new System.Drawing.Size(67, 50);
            this.btnSlew.TabIndex = 35;
            this.btnSlew.Text = "Start OneStar Sync";
            this.btnSlew.UseVisualStyleBackColor = true;
            this.btnSlew.Click += new System.EventHandler(this.btnSlew_Click);
            // 
            // btnChooseFits
            // 
            this.btnChooseFits.Location = new System.Drawing.Point(137, 57);
            this.btnChooseFits.Name = "btnChooseFits";
            this.btnChooseFits.Size = new System.Drawing.Size(85, 23);
            this.btnChooseFits.TabIndex = 34;
            this.btnChooseFits.Text = "Choose Fits";
            this.btnChooseFits.UseVisualStyleBackColor = true;
            this.btnChooseFits.Click += new System.EventHandler(this.btnChooseFits_Click);
            // 
            // tbFitsFile
            // 
            this.tbFitsFile.Location = new System.Drawing.Point(7, 58);
            this.tbFitsFile.Name = "tbFitsFile";
            this.tbFitsFile.Size = new System.Drawing.Size(124, 21);
            this.tbFitsFile.TabIndex = 33;
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(155, 98);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(67, 50);
            this.btnSync.TabIndex = 32;
            this.btnSync.Text = "Sync Telescope";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 162);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Telescope Data";
            // 
            // TitlePic
            // 
            this.TitlePic.Image = ((System.Drawing.Image)(resources.GetObject("TitlePic.Image")));
            this.TitlePic.InitialImage = ((System.Drawing.Image)(resources.GetObject("TitlePic.InitialImage")));
            this.TitlePic.Location = new System.Drawing.Point(-1, 0);
            this.TitlePic.Name = "TitlePic";
            this.TitlePic.Size = new System.Drawing.Size(885, 95);
            this.TitlePic.TabIndex = 35;
            this.TitlePic.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(12, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(412, 80);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Teloscope and Camera";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(430, 101);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(442, 347);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Log";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Adobe Gothic Std B", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Title.ForeColor = System.Drawing.Color.Teal;
            this.Title.Location = new System.Drawing.Point(294, 37);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(280, 36);
            this.Title.TabIndex = 38;
            this.Title.Text = "AUTO SYNC SYSTEM";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "fits";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            this.openFileDialog1.Title = "ChooseFitsToAnalyze";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 458);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.TitlePic);
            this.Controls.Add(this.tbCurrentFilterWheel);
            this.Controls.Add(this.btnFilterWheel);
            this.Controls.Add(this.drolsFilterWheel);
            this.Controls.Add(this.btnFilterWheelConnect);
            this.Controls.Add(this.btnFilterWheelChoose);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnCameraConnect);
            this.Controls.Add(this.btnCameraChoose);
            this.Controls.Add(this.tbCameraChoose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAlt);
            this.Controls.Add(this.tbAz);
            this.Controls.Add(this.tbDEC);
            this.Controls.Add(this.tbRA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSiderealTime);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbTeleScopeChoose);
            this.Controls.Add(this.btnTeleScopeChoose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "AutoSyncSystem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTeleScopeChoose;
        private System.Windows.Forms.TextBox tbTeleScopeChoose;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbSiderealTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRA;
        private System.Windows.Forms.TextBox tbDEC;
        private System.Windows.Forms.TextBox tbAz;
        private System.Windows.Forms.TextBox tbAlt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCameraChoose;
        private System.Windows.Forms.Button btnCameraChoose;
        private System.Windows.Forms.Button btnCameraConnect;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Button btnFilterWheelConnect;
        private System.Windows.Forms.Button btnFilterWheelChoose;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox drolsFilterWheel;
        private System.Windows.Forms.Button btnFilterWheel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCurrentFilterWheel;
        private System.Windows.Forms.Timer timerFilterWheel;
        private System.Windows.Forms.TextBox tbExposeTime;
        private System.Windows.Forms.Button btnExpose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox TitlePic;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnChooseFits;
        private System.Windows.Forms.TextBox tbFitsFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSlew;
    }
}

