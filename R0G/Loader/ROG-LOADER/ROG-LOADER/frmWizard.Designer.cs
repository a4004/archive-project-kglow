namespace ROG_LOADER
{
    partial class frmWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWizard));
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.pnlRtbHolder = new System.Windows.Forms.Panel();
            this.rtbLicense = new System.Windows.Forms.RichTextBox();
            this.lblWelcomeCaption = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.globalToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlInstall = new System.Windows.Forms.Panel();
            this.pnlIContent = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.pnlWelcome.SuspendLayout();
            this.pnlRtbHolder.SuspendLayout();
            this.pnlInstall.SuspendLayout();
            this.pnlIContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.Controls.Add(this.btnDecline);
            this.pnlWelcome.Controls.Add(this.btnAccept);
            this.pnlWelcome.Controls.Add(this.pnlRtbHolder);
            this.pnlWelcome.Controls.Add(this.lblWelcomeCaption);
            this.pnlWelcome.Controls.Add(this.lblWelcome);
            this.pnlWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWelcome.Location = new System.Drawing.Point(0, 0);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.pnlWelcome.Size = new System.Drawing.Size(684, 461);
            this.pnlWelcome.TabIndex = 0;
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(458, 405);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(100, 30);
            this.btnDecline.TabIndex = 4;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Enabled = false;
            this.btnAccept.Location = new System.Drawing.Point(564, 405);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 30);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // pnlRtbHolder
            // 
            this.pnlRtbHolder.BackColor = System.Drawing.Color.Gray;
            this.pnlRtbHolder.Controls.Add(this.rtbLicense);
            this.pnlRtbHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRtbHolder.Location = new System.Drawing.Point(20, 95);
            this.pnlRtbHolder.Name = "pnlRtbHolder";
            this.pnlRtbHolder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlRtbHolder.Size = new System.Drawing.Size(644, 294);
            this.pnlRtbHolder.TabIndex = 2;
            // 
            // rtbLicense
            // 
            this.rtbLicense.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbLicense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLicense.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLicense.Location = new System.Drawing.Point(1, 1);
            this.rtbLicense.Name = "rtbLicense";
            this.rtbLicense.ReadOnly = true;
            this.rtbLicense.Size = new System.Drawing.Size(642, 292);
            this.rtbLicense.TabIndex = 3;
            this.rtbLicense.Text = resources.GetString("rtbLicense.Text");
            // 
            // lblWelcomeCaption
            // 
            this.lblWelcomeCaption.AutoEllipsis = true;
            this.lblWelcomeCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcomeCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeCaption.Location = new System.Drawing.Point(20, 53);
            this.lblWelcomeCaption.Name = "lblWelcomeCaption";
            this.lblWelcomeCaption.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblWelcomeCaption.Size = new System.Drawing.Size(644, 42);
            this.lblWelcomeCaption.TabIndex = 1;
            this.lblWelcomeCaption.Text = "Before you begin, take a moment and read this";
            this.lblWelcomeCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoEllipsis = true;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(20, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(644, 53);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "License Agreement";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonTimer
            // 
            this.buttonTimer.Enabled = true;
            this.buttonTimer.Interval = 1000;
            this.buttonTimer.Tick += new System.EventHandler(this.buttonTimer_Tick);
            // 
            // pnlInstall
            // 
            this.pnlInstall.Controls.Add(this.pnlIContent);
            this.pnlInstall.Controls.Add(this.pbImg);
            this.pnlInstall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInstall.Location = new System.Drawing.Point(0, 0);
            this.pnlInstall.Name = "pnlInstall";
            this.pnlInstall.Size = new System.Drawing.Size(684, 461);
            this.pnlInstall.TabIndex = 1;
            // 
            // pnlIContent
            // 
            this.pnlIContent.BackColor = System.Drawing.SystemColors.Window;
            this.pnlIContent.Controls.Add(this.lblStatus);
            this.pnlIContent.Controls.Add(this.progressBar);
            this.pnlIContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIContent.Location = new System.Drawing.Point(0, 357);
            this.pnlIContent.Name = "pnlIContent";
            this.pnlIContent.Padding = new System.Windows.Forms.Padding(20, 0, 20, 25);
            this.pnlIContent.Size = new System.Drawing.Size(684, 104);
            this.pnlIContent.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(20, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(644, 32);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Preparing...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(20, 44);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(644, 35);
            this.progressBar.TabIndex = 0;
            this.progressBar.Value = 1;
            // 
            // pbImg
            // 
            this.pbImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbImg.Image = global::ROG_LOADER.Properties.Resources.Image2;
            this.pbImg.Location = new System.Drawing.Point(0, 0);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(684, 357);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            // 
            // frmWizard
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.pnlWelcome);
            this.Controls.Add(this.pnlInstall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmWizard";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R0G – Loader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWizard_FormClosing);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlRtbHolder.ResumeLayout(false);
            this.pnlInstall.ResumeLayout(false);
            this.pnlIContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Panel pnlRtbHolder;
        private System.Windows.Forms.RichTextBox rtbLicense;
        private System.Windows.Forms.Label lblWelcomeCaption;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ToolTip globalToolTip;
        private System.Windows.Forms.Timer buttonTimer;
        private System.Windows.Forms.Panel pnlInstall;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Panel pnlIContent;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
    }
}

