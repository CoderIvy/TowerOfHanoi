namespace Towers_of_Hanoi
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtTips = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnimation = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.lblDisk3 = new System.Windows.Forms.Label();
            this.lblDisk2 = new System.Windows.Forms.Label();
            this.lblDisk1 = new System.Windows.Forms.Label();
            this.lblDisk0 = new System.Windows.Forms.Label();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.lblPole0 = new System.Windows.Forms.Label();
            this.lblPole1 = new System.Windows.Forms.Label();
            this.lblPole2 = new System.Windows.Forms.Label();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.playbackTimer = new System.Timers.Timer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.playbackTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTips
            // 
            this.txtTips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTips.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTips.Location = new System.Drawing.Point(351, 118);
            this.txtTips.Multiline = true;
            this.txtTips.Name = "txtTips";
            this.txtTips.ReadOnly = true;
            this.txtTips.Size = new System.Drawing.Size(648, 68);
            this.txtTips.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 19);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(693, 55);
            this.label5.TabIndex = 54;
            this.label5.Text = "The  Towers  of  Hanoi  game";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(39, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(251, 468);
            this.textBox1.TabIndex = 53;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(830, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 52;
            this.label3.Text = "Pole 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "Pole 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "Pole 0";
            // 
            // btnAnimation
            // 
            this.btnAnimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimation.Location = new System.Drawing.Point(867, 650);
            this.btnAnimation.Name = "btnAnimation";
            this.btnAnimation.Size = new System.Drawing.Size(141, 44);
            this.btnAnimation.TabIndex = 49;
            this.btnAnimation.Text = "Animation";
            this.btnAnimation.UseVisualStyleBackColor = true;
            this.btnAnimation.Click += new System.EventHandler(this.btnAnimation_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(601, 650);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(141, 44);
            this.btnLoad.TabIndex = 48;
            this.btnLoad.Text = "Load Game";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(335, 650);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 44);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save Game";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1133, 650);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 44);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(69, 650);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(141, 44);
            this.btnReset.TabIndex = 45;
            this.btnReset.Text = "Restart";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // txtStep
            // 
            this.txtStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStep.Location = new System.Drawing.Point(603, 235);
            this.txtStep.Name = "txtStep";
            this.txtStep.ReadOnly = true;
            this.txtStep.Size = new System.Drawing.Size(223, 29);
            this.txtStep.TabIndex = 44;
            this.txtStep.Text = "0 / 15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 43;
            this.label4.Text = "MoveSteps:";
            // 
            // txtLogs
            // 
            this.txtLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogs.Location = new System.Drawing.Point(1032, 123);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogs.Size = new System.Drawing.Size(251, 475);
            this.txtLogs.TabIndex = 42;
            // 
            // lblDisk3
            // 
            this.lblDisk3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblDisk3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisk3.Location = new System.Drawing.Point(435, 425);
            this.lblDisk3.Name = "lblDisk3";
            this.lblDisk3.Size = new System.Drawing.Size(48, 24);
            this.lblDisk3.TabIndex = 41;
            this.lblDisk3.Text = "Disk 3";
            this.lblDisk3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisk3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllDisk_MouseDown);
            // 
            // lblDisk2
            // 
            this.lblDisk2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblDisk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisk2.Location = new System.Drawing.Point(420, 449);
            this.lblDisk2.Name = "lblDisk2";
            this.lblDisk2.Size = new System.Drawing.Size(80, 24);
            this.lblDisk2.TabIndex = 40;
            this.lblDisk2.Text = "Disk 2";
            this.lblDisk2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisk2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllDisk_MouseDown);
            // 
            // lblDisk1
            // 
            this.lblDisk1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblDisk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisk1.Location = new System.Drawing.Point(404, 473);
            this.lblDisk1.Name = "lblDisk1";
            this.lblDisk1.Size = new System.Drawing.Size(112, 24);
            this.lblDisk1.TabIndex = 39;
            this.lblDisk1.Text = "Disk 1";
            this.lblDisk1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisk1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllDisk_MouseDown);
            // 
            // lblDisk0
            // 
            this.lblDisk0.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblDisk0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisk0.Location = new System.Drawing.Point(388, 497);
            this.lblDisk0.Name = "lblDisk0";
            this.lblDisk0.Size = new System.Drawing.Size(144, 24);
            this.lblDisk0.TabIndex = 38;
            this.lblDisk0.Text = "Disk 0";
            this.lblDisk0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisk0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllDisk_MouseDown);
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.Navy;
            this.pnlBase.Location = new System.Drawing.Point(351, 521);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(634, 48);
            this.pnlBase.TabIndex = 34;
            // 
            // lblPole0
            // 
            this.lblPole0.AllowDrop = true;
            this.lblPole0.BackColor = System.Drawing.Color.Blue;
            this.lblPole0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPole0.Location = new System.Drawing.Point(448, 378);
            this.lblPole0.Name = "lblPole0";
            this.lblPole0.Size = new System.Drawing.Size(24, 144);
            this.lblPole0.TabIndex = 35;
            this.lblPole0.DragDrop += new System.Windows.Forms.DragEventHandler(this.AllPole_DragDrop);
            this.lblPole0.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllPole_DragEnter);
            // 
            // lblPole1
            // 
            this.lblPole1.AllowDrop = true;
            this.lblPole1.BackColor = System.Drawing.Color.Blue;
            this.lblPole1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPole1.Location = new System.Drawing.Point(650, 378);
            this.lblPole1.Name = "lblPole1";
            this.lblPole1.Size = new System.Drawing.Size(24, 144);
            this.lblPole1.TabIndex = 36;
            this.lblPole1.DragDrop += new System.Windows.Forms.DragEventHandler(this.AllPole_DragDrop);
            this.lblPole1.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllPole_DragEnter);
            // 
            // lblPole2
            // 
            this.lblPole2.AllowDrop = true;
            this.lblPole2.BackColor = System.Drawing.Color.Blue;
            this.lblPole2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPole2.Location = new System.Drawing.Point(853, 378);
            this.lblPole2.Name = "lblPole2";
            this.lblPole2.Size = new System.Drawing.Size(24, 144);
            this.lblPole2.TabIndex = 37;
            this.lblPole2.DragDrop += new System.Windows.Forms.DragEventHandler(this.AllPole_DragDrop);
            this.lblPole2.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllPole_DragEnter);
            this.lblPole2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllDisk_MouseDown);
            // 
            // playbackTimer
            // 
            this.playbackTimer.Interval = 1000D;
            this.playbackTimer.SynchronizingObject = this;
            this.playbackTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.playbackTimer_Elapsed);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1015, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(223, 22);
            this.textBox2.TabIndex = 57;
            this.textBox2.Text = "-- LanChen (1465253)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 729);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtTips);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnimation);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.lblDisk3);
            this.Controls.Add(this.lblDisk2);
            this.Controls.Add(this.lblDisk1);
            this.Controls.Add(this.lblDisk0);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.lblPole0);
            this.Controls.Add(this.lblPole1);
            this.Controls.Add(this.lblPole2);
            this.Name = "MainForm";
            this.Text = "The Towers of Hanoi";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.AllPole_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllPole_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.playbackTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTips;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnimation;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.Label lblDisk3;
        private System.Windows.Forms.Label lblDisk2;
        private System.Windows.Forms.Label lblDisk1;
        private System.Windows.Forms.Label lblDisk0;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Label lblPole0;
        private System.Windows.Forms.Label lblPole1;
        private System.Windows.Forms.Label lblPole2;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Timers.Timer playbackTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

