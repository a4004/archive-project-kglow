namespace kGlow.Setup
{
    partial class frmWz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWz));
            this.pnlGather = new System.Windows.Forms.Panel();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnSetDirectory = new System.Windows.Forms.Button();
            this.lblInstallDir = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.pnlPrep = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.installationBar = new kGlow.Setup.GradientPanel();
            this.lblStep4 = new System.Windows.Forms.Label();
            this.lblStep3 = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timeout = new System.Windows.Forms.Timer(this.components);
            this.pnlDone = new System.Windows.Forms.Panel();
            this.chkLaunch = new System.Windows.Forms.CheckBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblDone = new System.Windows.Forms.Label();
            this.pnlGather.SuspendLayout();
            this.pnlPrep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.installationBar.SuspendLayout();
            this.pnlDone.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGather
            // 
            this.pnlGather.Controls.Add(this.btnNext1);
            this.pnlGather.Controls.Add(this.lblWarning);
            this.pnlGather.Controls.Add(this.btnSetDirectory);
            this.pnlGather.Controls.Add(this.lblInstallDir);
            this.pnlGather.Controls.Add(this.lblTitle1);
            this.pnlGather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGather.Location = new System.Drawing.Point(220, 0);
            this.pnlGather.Name = "pnlGather";
            this.pnlGather.Size = new System.Drawing.Size(364, 411);
            this.pnlGather.TabIndex = 0;
            // 
            // btnNext1
            // 
            this.btnNext1.Location = new System.Drawing.Point(108, 134);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(75, 25);
            this.btnNext1.TabIndex = 4;
            this.btnNext1.Text = "Next";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(24, 280);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(275, 47);
            this.lblWarning.TabIndex = 3;
            this.lblWarning.Text = "We recommend disabling your security software as\r\nwe will extract files that may " +
    "be incorrectly flagged as \r\nmalicious software.";
            // 
            // btnSetDirectory
            // 
            this.btnSetDirectory.Location = new System.Drawing.Point(27, 134);
            this.btnSetDirectory.Name = "btnSetDirectory";
            this.btnSetDirectory.Size = new System.Drawing.Size(75, 25);
            this.btnSetDirectory.TabIndex = 2;
            this.btnSetDirectory.Text = "Browse";
            this.btnSetDirectory.UseVisualStyleBackColor = true;
            this.btnSetDirectory.Click += new System.EventHandler(this.btnSetDirectory_Click);
            // 
            // lblInstallDir
            // 
            this.lblInstallDir.Location = new System.Drawing.Point(24, 76);
            this.lblInstallDir.Name = "lblInstallDir";
            this.lblInstallDir.Size = new System.Drawing.Size(328, 47);
            this.lblInstallDir.TabIndex = 1;
            this.lblInstallDir.Text = "Default: Desktop";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(23, 43);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(135, 24);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "Install Directory";
            // 
            // pnlPrep
            // 
            this.pnlPrep.Controls.Add(this.pictureBox2);
            this.pnlPrep.Controls.Add(this.pictureBox1);
            this.pnlPrep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrep.Location = new System.Drawing.Point(220, 0);
            this.pnlPrep.Name = "pnlPrep";
            this.pnlPrep.Size = new System.Drawing.Size(364, 411);
            this.pnlPrep.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = global::kGlow.Setup.Properties.Resources.IMG2;
            this.pictureBox2.Location = new System.Drawing.Point(0, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(364, 206);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::kGlow.Setup.Properties.Resources.IMG1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // installationBar
            // 
            this.installationBar.Controls.Add(this.lblStep4);
            this.installationBar.Controls.Add(this.lblStep3);
            this.installationBar.Controls.Add(this.lblStep2);
            this.installationBar.Controls.Add(this.lblStep1);
            this.installationBar.Controls.Add(this.lblTitle);
            this.installationBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.installationBar.Location = new System.Drawing.Point(0, 0);
            this.installationBar.Name = "installationBar";
            this.installationBar.Size = new System.Drawing.Size(220, 411);
            this.installationBar.TabIndex = 0;
            // 
            // lblStep4
            // 
            this.lblStep4.AutoSize = true;
            this.lblStep4.BackColor = System.Drawing.Color.Transparent;
            this.lblStep4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep4.Location = new System.Drawing.Point(25, 165);
            this.lblStep4.Name = "lblStep4";
            this.lblStep4.Size = new System.Drawing.Size(54, 17);
            this.lblStep4.TabIndex = 4;
            this.lblStep4.Text = "4. Finish";
            // 
            // lblStep3
            // 
            this.lblStep3.AutoSize = true;
            this.lblStep3.BackColor = System.Drawing.Color.Transparent;
            this.lblStep3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep3.Location = new System.Drawing.Point(25, 140);
            this.lblStep3.Name = "lblStep3";
            this.lblStep3.Size = new System.Drawing.Size(110, 17);
            this.lblStep3.TabIndex = 3;
            this.lblStep3.Text = "3. Install Software";
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.BackColor = System.Drawing.Color.Transparent;
            this.lblStep2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep2.Location = new System.Drawing.Point(25, 115);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(121, 17);
            this.lblStep2.TabIndex = 2;
            this.lblStep2.Text = "2. Prepare to Install";
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.BackColor = System.Drawing.Color.Transparent;
            this.lblStep1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep1.ForeColor = System.Drawing.Color.Blue;
            this.lblStep1.Location = new System.Drawing.Point(25, 90);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(132, 17);
            this.lblStep1.TabIndex = 1;
            this.lblStep1.Text = "1. Gather Information";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(198, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Software Installer";
            // 
            // timeout
            // 
            this.timeout.Interval = 5000;
            this.timeout.Tick += new System.EventHandler(this.timeout_Tick);
            // 
            // pnlDone
            // 
            this.pnlDone.Controls.Add(this.chkLaunch);
            this.pnlDone.Controls.Add(this.btnFinish);
            this.pnlDone.Controls.Add(this.lblDone);
            this.pnlDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDone.Location = new System.Drawing.Point(220, 0);
            this.pnlDone.Name = "pnlDone";
            this.pnlDone.Size = new System.Drawing.Size(364, 411);
            this.pnlDone.TabIndex = 6;
            // 
            // chkLaunch
            // 
            this.chkLaunch.AutoSize = true;
            this.chkLaunch.Checked = true;
            this.chkLaunch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLaunch.Location = new System.Drawing.Point(27, 106);
            this.chkLaunch.Name = "chkLaunch";
            this.chkLaunch.Size = new System.Drawing.Size(124, 17);
            this.chkLaunch.TabIndex = 3;
            this.chkLaunch.Text = "Launch kGlow.Client";
            this.chkLaunch.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(27, 134);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 25);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.Text = "Finsih";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDone.Location = new System.Drawing.Point(23, 43);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(142, 24);
            this.lblDone.TabIndex = 1;
            this.lblDone.Text = "Install Complete";
            // 
            // frmWz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.pnlGather);
            this.Controls.Add(this.pnlDone);
            this.Controls.Add(this.pnlPrep);
            this.Controls.Add(this.installationBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmWz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kGlow Setup";
            this.pnlGather.ResumeLayout(false);
            this.pnlGather.PerformLayout();
            this.pnlPrep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.installationBar.ResumeLayout(false);
            this.installationBar.PerformLayout();
            this.pnlDone.ResumeLayout(false);
            this.pnlDone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGather;
        private GradientPanel installationBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Label lblStep4;
        private System.Windows.Forms.Label lblStep3;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblInstallDir;
        private System.Windows.Forms.Button btnSetDirectory;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Panel pnlPrep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timeout;
        private System.Windows.Forms.Panel pnlDone;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.CheckBox chkLaunch;
    }
}

