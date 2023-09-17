namespace kGlow.Client
{
    partial class frmDSEWarn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSEWarn));
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.pnlBk = new System.Windows.Forms.Panel();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.pnlBanner.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlBk.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.pnlBanner.Controls.Add(this.lblSubTitle);
            this.pnlBanner.Controls.Add(this.lblTitle);
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBanner.ForeColor = System.Drawing.Color.White;
            this.pnlBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(484, 75);
            this.pnlBanner.TabIndex = 1;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(0, 45);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblSubTitle.Size = new System.Drawing.Size(484, 30);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Please read this carefully before you proceed.";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(484, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Blue Screen (BSOD) Warning";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.btnAbort);
            this.pnlContainer.Controls.Add(this.btnYes);
            this.pnlContainer.Controls.Add(this.pnlBk);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 75);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.pnlContainer.Size = new System.Drawing.Size(484, 286);
            this.pnlContainer.TabIndex = 2;
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(290, 221);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(82, 30);
            this.btnAbort.TabIndex = 2;
            this.btnAbort.Text = "Cancel";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(378, 221);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(96, 30);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Continue";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // pnlBk
            // 
            this.pnlBk.BackColor = System.Drawing.Color.Gray;
            this.pnlBk.Controls.Add(this.rtb);
            this.pnlBk.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBk.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBk.Location = new System.Drawing.Point(10, 20);
            this.pnlBk.Name = "pnlBk";
            this.pnlBk.Padding = new System.Windows.Forms.Padding(1);
            this.pnlBk.Size = new System.Drawing.Size(464, 177);
            this.pnlBk.TabIndex = 0;
            // 
            // rtb
            // 
            this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb.Location = new System.Drawing.Point(1, 1);
            this.rtb.Name = "rtb";
            this.rtb.ReadOnly = true;
            this.rtb.Size = new System.Drawing.Size(462, 175);
            this.rtb.TabIndex = 0;
            this.rtb.Text = resources.GetString("rtb.Text");
            // 
            // frmDSEWarn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDSEWarn";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Important Notice";
            this.pnlBanner.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlBk.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlBk;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnYes;
    }
}