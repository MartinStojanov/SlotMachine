namespace SlotMachine
{
    partial class PlayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnCASH = new System.Windows.Forms.Button();
            this.infolbl = new System.Windows.Forms.Label();
            this.betlbl = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnAutoSpin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnINPUT = new System.Windows.Forms.Button();
            this.btnINPUTPlus = new System.Windows.Forms.Button();
            this.btnINPUTMinus = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnBET = new System.Windows.Forms.Button();
            this.btnBETPlus = new System.Windows.Forms.Button();
            this.btnBETMinus = new System.Windows.Forms.Button();
            this.btnSPIN = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.btnInfo);
            this.groupBox2.Controls.Add(this.btnCASH);
            this.groupBox2.Location = new System.Drawing.Point(32, 269);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(160, 184);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(26, 17);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(105, 33);
            this.btnInfo.TabIndex = 38;
            this.btnInfo.Text = "PRIZE INFO";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnCASH
            // 
            this.btnCASH.BackColor = System.Drawing.Color.LightGreen;
            this.btnCASH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCASH.Location = new System.Drawing.Point(26, 93);
            this.btnCASH.Name = "btnCASH";
            this.btnCASH.Size = new System.Drawing.Size(105, 66);
            this.btnCASH.TabIndex = 35;
            this.btnCASH.Text = "CASH OUT";
            this.btnCASH.UseVisualStyleBackColor = false;
            this.btnCASH.Click += new System.EventHandler(this.btnCASH_Click);
            // 
            // infolbl
            // 
            this.infolbl.BackColor = System.Drawing.Color.Gainsboro;
            this.infolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infolbl.ForeColor = System.Drawing.Color.Red;
            this.infolbl.Location = new System.Drawing.Point(236, 6);
            this.infolbl.Name = "infolbl";
            this.infolbl.Size = new System.Drawing.Size(187, 30);
            this.infolbl.TabIndex = 42;
            this.infolbl.Text = "CREDIT: ";
            // 
            // betlbl
            // 
            this.betlbl.BackColor = System.Drawing.Color.Gainsboro;
            this.betlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.betlbl.ForeColor = System.Drawing.Color.Red;
            this.betlbl.Location = new System.Drawing.Point(641, 9);
            this.betlbl.Name = "betlbl";
            this.betlbl.Size = new System.Drawing.Size(193, 30);
            this.betlbl.TabIndex = 43;
            this.betlbl.Text = "BET: ";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::SlotMachine.Properties.Resources.background_for_slots_game_2_vector_3388282;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(222, 38);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(643, 415);
            this.pictureBox9.TabIndex = 44;
            this.pictureBox9.TabStop = false;
            // 
            // btnAutoSpin
            // 
            this.btnAutoSpin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAutoSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoSpin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAutoSpin.Location = new System.Drawing.Point(906, 342);
            this.btnAutoSpin.Name = "btnAutoSpin";
            this.btnAutoSpin.Size = new System.Drawing.Size(116, 85);
            this.btnAutoSpin.TabIndex = 45;
            this.btnAutoSpin.Text = "AUTO SPIN";
            this.btnAutoSpin.UseVisualStyleBackColor = false;
            this.btnAutoSpin.Click += new System.EventHandler(this.btnAutoSpin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.btnINPUT);
            this.groupBox1.Controls.Add(this.btnINPUTPlus);
            this.groupBox1.Controls.Add(this.btnINPUTMinus);
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.btnBET);
            this.groupBox1.Controls.Add(this.btnBETPlus);
            this.groupBox1.Controls.Add(this.btnBETMinus);
            this.groupBox1.Location = new System.Drawing.Point(143, 472);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(721, 104);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // btnINPUT
            // 
            this.btnINPUT.BackColor = System.Drawing.Color.White;
            this.btnINPUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINPUT.ForeColor = System.Drawing.Color.Black;
            this.btnINPUT.Location = new System.Drawing.Point(9, 18);
            this.btnINPUT.Name = "btnINPUT";
            this.btnINPUT.Size = new System.Drawing.Size(102, 66);
            this.btnINPUT.TabIndex = 17;
            this.btnINPUT.Text = "INPUT MONEY";
            this.btnINPUT.UseVisualStyleBackColor = false;
            this.btnINPUT.Click += new System.EventHandler(this.btnINPUT_Click);
            // 
            // btnINPUTPlus
            // 
            this.btnINPUTPlus.BackColor = System.Drawing.Color.Maroon;
            this.btnINPUTPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnINPUTPlus.ForeColor = System.Drawing.Color.White;
            this.btnINPUTPlus.Location = new System.Drawing.Point(118, 18);
            this.btnINPUTPlus.Name = "btnINPUTPlus";
            this.btnINPUTPlus.Size = new System.Drawing.Size(29, 26);
            this.btnINPUTPlus.TabIndex = 18;
            this.btnINPUTPlus.Text = "+";
            this.btnINPUTPlus.UseVisualStyleBackColor = false;
            this.btnINPUTPlus.Click += new System.EventHandler(this.btnINPUTPlus_Click);
            // 
            // btnINPUTMinus
            // 
            this.btnINPUTMinus.BackColor = System.Drawing.Color.Green;
            this.btnINPUTMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINPUTMinus.ForeColor = System.Drawing.Color.White;
            this.btnINPUTMinus.Location = new System.Drawing.Point(118, 56);
            this.btnINPUTMinus.Name = "btnINPUTMinus";
            this.btnINPUTMinus.Size = new System.Drawing.Size(29, 27);
            this.btnINPUTMinus.TabIndex = 19;
            this.btnINPUTMinus.Text = "-";
            this.btnINPUTMinus.UseVisualStyleBackColor = false;
            this.btnINPUTMinus.Click += new System.EventHandler(this.btnINPUTMinus_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.White;
            this.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMsg.Location = new System.Drawing.Point(239, 30);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(232, 40);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBET
            // 
            this.btnBET.BackColor = System.Drawing.Color.White;
            this.btnBET.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBET.ForeColor = System.Drawing.Color.Black;
            this.btnBET.Location = new System.Drawing.Point(575, 18);
            this.btnBET.Name = "btnBET";
            this.btnBET.Size = new System.Drawing.Size(96, 66);
            this.btnBET.TabIndex = 21;
            this.btnBET.Text = "BET";
            this.btnBET.UseVisualStyleBackColor = false;
            this.btnBET.Click += new System.EventHandler(this.btnBET_Click);
            // 
            // btnBETPlus
            // 
            this.btnBETPlus.BackColor = System.Drawing.Color.Maroon;
            this.btnBETPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBETPlus.ForeColor = System.Drawing.Color.White;
            this.btnBETPlus.Location = new System.Drawing.Point(678, 18);
            this.btnBETPlus.Name = "btnBETPlus";
            this.btnBETPlus.Size = new System.Drawing.Size(29, 26);
            this.btnBETPlus.TabIndex = 22;
            this.btnBETPlus.Text = "+";
            this.btnBETPlus.UseVisualStyleBackColor = false;
            this.btnBETPlus.Click += new System.EventHandler(this.btnBETPlus_Click);
            // 
            // btnBETMinus
            // 
            this.btnBETMinus.BackColor = System.Drawing.Color.Green;
            this.btnBETMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBETMinus.ForeColor = System.Drawing.Color.White;
            this.btnBETMinus.Location = new System.Drawing.Point(678, 56);
            this.btnBETMinus.Name = "btnBETMinus";
            this.btnBETMinus.Size = new System.Drawing.Size(29, 27);
            this.btnBETMinus.TabIndex = 23;
            this.btnBETMinus.Text = "-";
            this.btnBETMinus.UseVisualStyleBackColor = false;
            this.btnBETMinus.Click += new System.EventHandler(this.btnBETMinus_Click);
            // 
            // btnSPIN
            // 
            this.btnSPIN.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPIN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSPIN.Location = new System.Drawing.Point(906, 474);
            this.btnSPIN.Name = "btnSPIN";
            this.btnSPIN.Size = new System.Drawing.Size(116, 85);
            this.btnSPIN.TabIndex = 47;
            this.btnSPIN.Text = "SPIN";
            this.btnSPIN.UseVisualStyleBackColor = false;
            this.btnSPIN.Click += new System.EventHandler(this.btnSPIN_Click);
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(241, 54);
            this.pb1.Margin = new System.Windows.Forms.Padding(2);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(182, 119);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 48;
            this.pb1.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Image = ((System.Drawing.Image)(resources.GetObject("pb4.Image")));
            this.pb4.Location = new System.Drawing.Point(241, 188);
            this.pb4.Margin = new System.Windows.Forms.Padding(2);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(182, 119);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 49;
            this.pb4.TabStop = false;
            // 
            // pb7
            // 
            this.pb7.Image = ((System.Drawing.Image)(resources.GetObject("pb7.Image")));
            this.pb7.Location = new System.Drawing.Point(241, 322);
            this.pb7.Margin = new System.Windows.Forms.Padding(2);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(182, 119);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb7.TabIndex = 50;
            this.pb7.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(451, 53);
            this.pb2.Margin = new System.Windows.Forms.Padding(2);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(182, 119);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 51;
            this.pb2.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.Image = ((System.Drawing.Image)(resources.GetObject("pb5.Image")));
            this.pb5.Location = new System.Drawing.Point(451, 188);
            this.pb5.Margin = new System.Windows.Forms.Padding(2);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(182, 119);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 52;
            this.pb5.TabStop = false;
            // 
            // pb8
            // 
            this.pb8.Image = ((System.Drawing.Image)(resources.GetObject("pb8.Image")));
            this.pb8.Location = new System.Drawing.Point(451, 322);
            this.pb8.Margin = new System.Windows.Forms.Padding(2);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(182, 119);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb8.TabIndex = 53;
            this.pb8.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = ((System.Drawing.Image)(resources.GetObject("pb3.Image")));
            this.pb3.Location = new System.Drawing.Point(662, 54);
            this.pb3.Margin = new System.Windows.Forms.Padding(2);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(182, 119);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 54;
            this.pb3.TabStop = false;
            // 
            // pb6
            // 
            this.pb6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb6.BackgroundImage")));
            this.pb6.Location = new System.Drawing.Point(662, 188);
            this.pb6.Margin = new System.Windows.Forms.Padding(2);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(182, 119);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 55;
            this.pb6.TabStop = false;
            // 
            // pb9
            // 
            this.pb9.Image = ((System.Drawing.Image)(resources.GetObject("pb9.Image")));
            this.pb9.Location = new System.Drawing.Point(662, 322);
            this.pb9.Margin = new System.Windows.Forms.Padding(2);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(182, 119);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb9.TabIndex = 56;
            this.pb9.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SlotMachine.Properties.Resources.Person_Gambling_Online;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 599);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btnSPIN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAutoSpin);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.betlbl);
            this.Controls.Add(this.infolbl);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayForm";
            this.Text = "PlayForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayForm_FormClosed);
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnCASH;
        private System.Windows.Forms.Label infolbl;
        private System.Windows.Forms.Label betlbl;
        private System.Windows.Forms.PictureBox pictureBox9;
        internal System.Windows.Forms.Button btnAutoSpin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnINPUT;
        private System.Windows.Forms.Button btnINPUTPlus;
        private System.Windows.Forms.Button btnINPUTMinus;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnBET;
        private System.Windows.Forms.Button btnBETPlus;
        private System.Windows.Forms.Button btnBETMinus;
        internal System.Windows.Forms.Button btnSPIN;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}