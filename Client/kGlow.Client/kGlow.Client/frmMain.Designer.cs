namespace kGlow.Client
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.gbCheat = new System.Windows.Forms.GroupBox();
            this.btnGlowOff = new System.Windows.Forms.Button();
            this.lblGlowStatus = new System.Windows.Forms.Label();
            this.btnGlowOn = new System.Windows.Forms.Button();
            this.pnlSpacer = new System.Windows.Forms.Panel();
            this.gbDriver = new System.Windows.Forms.GroupBox();
            this.btnRunWithDSEFix = new System.Windows.Forms.Button();
            this.btnDisableDSE = new System.Windows.Forms.Button();
            this.btnStopDriver = new System.Windows.Forms.Button();
            this.btnStartDriver = new System.Windows.Forms.Button();
            this.lblDriverStatus = new System.Windows.Forms.Label();
            this.pnlError = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.errorFader = new System.Windows.Forms.Timer(this.components);
            this.pnlBanner.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.gbCheat.SuspendLayout();
            this.gbDriver.SuspendLayout();
            this.pnlError.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(534, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "kGlow";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblCredits
            // 
            this.lblCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCredits.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.Location = new System.Drawing.Point(0, 45);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblCredits.Size = new System.Drawing.Size(534, 30);
            this.lblCredits.TabIndex = 1;
            this.lblCredits.Text = "created by adev4004 - Discord: @adev4004 | Github: /adev4004";
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.pnlBanner.Controls.Add(this.lblCredits);
            this.pnlBanner.Controls.Add(this.lblTitle);
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBanner.ForeColor = System.Drawing.Color.White;
            this.pnlBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(534, 75);
            this.pnlBanner.TabIndex = 0;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.gbCheat);
            this.pnlContainer.Controls.Add(this.pnlSpacer);
            this.pnlContainer.Controls.Add(this.gbDriver);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 75);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(25, 20, 25, 10);
            this.pnlContainer.Size = new System.Drawing.Size(534, 301);
            this.pnlContainer.TabIndex = 1;
            // 
            // gbCheat
            // 
            this.gbCheat.Controls.Add(this.btnGlowOff);
            this.gbCheat.Controls.Add(this.lblGlowStatus);
            this.gbCheat.Controls.Add(this.btnGlowOn);
            this.gbCheat.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCheat.Location = new System.Drawing.Point(25, 157);
            this.gbCheat.Name = "gbCheat";
            this.gbCheat.Size = new System.Drawing.Size(484, 128);
            this.gbCheat.TabIndex = 3;
            this.gbCheat.TabStop = false;
            this.gbCheat.Text = "Glow ESP";
            // 
            // btnGlowOff
            // 
            this.btnGlowOff.Enabled = false;
            this.btnGlowOff.Location = new System.Drawing.Point(144, 59);
            this.btnGlowOff.Name = "btnGlowOff";
            this.btnGlowOff.Size = new System.Drawing.Size(118, 25);
            this.btnGlowOff.TabIndex = 6;
            this.btnGlowOff.Text = "Disable Glow";
            this.btnGlowOff.UseVisualStyleBackColor = true;
            this.btnGlowOff.Click += new System.EventHandler(this.btnGlowOff_Click);
            // 
            // lblGlowStatus
            // 
            this.lblGlowStatus.AutoSize = true;
            this.lblGlowStatus.Location = new System.Drawing.Point(17, 31);
            this.lblGlowStatus.Name = "lblGlowStatus";
            this.lblGlowStatus.Size = new System.Drawing.Size(45, 13);
            this.lblGlowStatus.TabIndex = 5;
            this.lblGlowStatus.Text = "Inactive";
            // 
            // btnGlowOn
            // 
            this.btnGlowOn.Enabled = false;
            this.btnGlowOn.Location = new System.Drawing.Point(20, 59);
            this.btnGlowOn.Name = "btnGlowOn";
            this.btnGlowOn.Size = new System.Drawing.Size(118, 25);
            this.btnGlowOn.TabIndex = 5;
            this.btnGlowOn.Text = "Enable Glow";
            this.btnGlowOn.UseVisualStyleBackColor = true;
            this.btnGlowOn.Click += new System.EventHandler(this.btnGlowOn_Click);
            // 
            // pnlSpacer
            // 
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpacer.Location = new System.Drawing.Point(25, 131);
            this.pnlSpacer.Name = "pnlSpacer";
            this.pnlSpacer.Size = new System.Drawing.Size(484, 26);
            this.pnlSpacer.TabIndex = 4;
            // 
            // gbDriver
            // 
            this.gbDriver.Controls.Add(this.btnRunWithDSEFix);
            this.gbDriver.Controls.Add(this.btnDisableDSE);
            this.gbDriver.Controls.Add(this.btnStopDriver);
            this.gbDriver.Controls.Add(this.btnStartDriver);
            this.gbDriver.Controls.Add(this.lblDriverStatus);
            this.gbDriver.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDriver.Location = new System.Drawing.Point(25, 20);
            this.gbDriver.Name = "gbDriver";
            this.gbDriver.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.gbDriver.Size = new System.Drawing.Size(484, 111);
            this.gbDriver.TabIndex = 2;
            this.gbDriver.TabStop = false;
            this.gbDriver.Text = "Driver";
            // 
            // btnRunWithDSEFix
            // 
            this.btnRunWithDSEFix.Location = new System.Drawing.Point(333, 57);
            this.btnRunWithDSEFix.Name = "btnRunWithDSEFix";
            this.btnRunWithDSEFix.Size = new System.Drawing.Size(133, 25);
            this.btnRunWithDSEFix.TabIndex = 4;
            this.btnRunWithDSEFix.Text = "Start with DSEFix";
            this.btnRunWithDSEFix.UseVisualStyleBackColor = true;
            this.btnRunWithDSEFix.Click += new System.EventHandler(this.btnRunWithDSEFix_Click);
            // 
            // btnDisableDSE
            // 
            this.btnDisableDSE.Location = new System.Drawing.Point(333, 30);
            this.btnDisableDSE.Name = "btnDisableDSE";
            this.btnDisableDSE.Size = new System.Drawing.Size(133, 25);
            this.btnDisableDSE.TabIndex = 3;
            this.btnDisableDSE.Text = "Disable DSE";
            this.btnDisableDSE.UseVisualStyleBackColor = true;
            this.btnDisableDSE.Click += new System.EventHandler(this.btnDisableDSE_Click);
            // 
            // btnStopDriver
            // 
            this.btnStopDriver.Enabled = false;
            this.btnStopDriver.Location = new System.Drawing.Point(101, 57);
            this.btnStopDriver.Name = "btnStopDriver";
            this.btnStopDriver.Size = new System.Drawing.Size(75, 25);
            this.btnStopDriver.TabIndex = 2;
            this.btnStopDriver.Text = "Stop";
            this.btnStopDriver.UseVisualStyleBackColor = true;
            this.btnStopDriver.Click += new System.EventHandler(this.btnStopDriver_Click);
            // 
            // btnStartDriver
            // 
            this.btnStartDriver.Location = new System.Drawing.Point(20, 57);
            this.btnStartDriver.Name = "btnStartDriver";
            this.btnStartDriver.Size = new System.Drawing.Size(75, 25);
            this.btnStartDriver.TabIndex = 1;
            this.btnStartDriver.Text = "Start";
            this.btnStartDriver.UseVisualStyleBackColor = true;
            this.btnStartDriver.Click += new System.EventHandler(this.btnStartDriver_Click);
            // 
            // lblDriverStatus
            // 
            this.lblDriverStatus.AutoSize = true;
            this.lblDriverStatus.Location = new System.Drawing.Point(17, 30);
            this.lblDriverStatus.Name = "lblDriverStatus";
            this.lblDriverStatus.Size = new System.Drawing.Size(89, 13);
            this.lblDriverStatus.TabIndex = 0;
            this.lblDriverStatus.Text = "Status: Unknown";
            // 
            // pnlError
            // 
            this.pnlError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlError.Controls.Add(this.lblError);
            this.pnlError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlError.Location = new System.Drawing.Point(0, 376);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(534, 35);
            this.pnlError.TabIndex = 6;
            this.pnlError.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoEllipsis = true;
            this.lblError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblError.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblError.Size = new System.Drawing.Size(534, 35);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "An error has occurred.";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorFader
            // 
            this.errorFader.Interval = 5000;
            this.errorFader.Tick += new System.EventHandler(this.errorFader_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlError);
            this.Controls.Add(this.pnlBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kGlow.Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.pnlBanner.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.gbCheat.ResumeLayout(false);
            this.gbCheat.PerformLayout();
            this.gbDriver.ResumeLayout(false);
            this.gbDriver.PerformLayout();
            this.pnlError.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.GroupBox gbDriver;
        private System.Windows.Forms.GroupBox gbCheat;
        private System.Windows.Forms.Panel pnlSpacer;
        private System.Windows.Forms.Label lblDriverStatus;
        private System.Windows.Forms.Button btnStartDriver;
        private System.Windows.Forms.Button btnStopDriver;
        private System.Windows.Forms.Button btnDisableDSE;
        private System.Windows.Forms.Button btnRunWithDSEFix;
        private System.Windows.Forms.Label lblGlowStatus;
        private System.Windows.Forms.Button btnGlowOff;
        private System.Windows.Forms.Button btnGlowOn;
        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Timer errorFader;
    }
}

