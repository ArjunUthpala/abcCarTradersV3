namespace abcCarTradersV1
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelBrand = new System.Windows.Forms.Label();
            this.btnLoginPanel = new System.Windows.Forms.Button();
            this.PanelIndicator = new System.Windows.Forms.Panel();
            this.btnRegisterPanel = new System.Windows.Forms.Button();
            this.panelIndicator2 = new System.Windows.Forms.Panel();
            this.ctrlSignIn1 = new abcCarTradersV1.CtrlSignIn();
            this.ctrlRegister1 = new abcCarTradersV1.CtrlRegister();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1209, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnRegisterPanel);
            this.panel1.Controls.Add(this.panelIndicator2);
            this.panel1.Controls.Add(this.btnLoginPanel);
            this.panel1.Controls.Add(this.PanelIndicator);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 100);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(92, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 320);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 581);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Goldenrod;
            this.panel3.Controls.Add(this.labelBrand);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(514, 100);
            this.panel3.TabIndex = 5;
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBrand.Location = new System.Drawing.Point(54, 21);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(402, 58);
            this.labelBrand.TabIndex = 1;
            this.labelBrand.Text = "ABC Car Traders";
            // 
            // btnLoginPanel
            // 
            this.btnLoginPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLoginPanel.FlatAppearance.BorderSize = 0;
            this.btnLoginPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginPanel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginPanel.ForeColor = System.Drawing.Color.White;
            this.btnLoginPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnLoginPanel.Image")));
            this.btnLoginPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginPanel.Location = new System.Drawing.Point(547, 19);
            this.btnLoginPanel.Name = "btnLoginPanel";
            this.btnLoginPanel.Size = new System.Drawing.Size(308, 47);
            this.btnLoginPanel.TabIndex = 12;
            this.btnLoginPanel.Text = "        Login";
            this.btnLoginPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginPanel.UseVisualStyleBackColor = false;
            this.btnLoginPanel.Click += new System.EventHandler(this.btnLoginPanel_Click);
            // 
            // PanelIndicator
            // 
            this.PanelIndicator.BackColor = System.Drawing.Color.SpringGreen;
            this.PanelIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelIndicator.ForeColor = System.Drawing.Color.White;
            this.PanelIndicator.Location = new System.Drawing.Point(547, 69);
            this.PanelIndicator.Name = "PanelIndicator";
            this.PanelIndicator.Size = new System.Drawing.Size(308, 10);
            this.PanelIndicator.TabIndex = 13;
            // 
            // btnRegisterPanel
            // 
            this.btnRegisterPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRegisterPanel.FlatAppearance.BorderSize = 0;
            this.btnRegisterPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterPanel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterPanel.ForeColor = System.Drawing.Color.White;
            this.btnRegisterPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterPanel.Image")));
            this.btnRegisterPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterPanel.Location = new System.Drawing.Point(873, 19);
            this.btnRegisterPanel.Name = "btnRegisterPanel";
            this.btnRegisterPanel.Size = new System.Drawing.Size(308, 47);
            this.btnRegisterPanel.TabIndex = 13;
            this.btnRegisterPanel.Text = "        Register";
            this.btnRegisterPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterPanel.UseVisualStyleBackColor = false;
            this.btnRegisterPanel.Click += new System.EventHandler(this.btnRegisterPanel_Click);
            // 
            // panelIndicator2
            // 
            this.panelIndicator2.BackColor = System.Drawing.Color.SpringGreen;
            this.panelIndicator2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIndicator2.ForeColor = System.Drawing.Color.White;
            this.panelIndicator2.Location = new System.Drawing.Point(873, 69);
            this.panelIndicator2.Name = "panelIndicator2";
            this.panelIndicator2.Size = new System.Drawing.Size(308, 10);
            this.panelIndicator2.TabIndex = 14;
            // 
            // ctrlSignIn1
            // 
            this.ctrlSignIn1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ctrlSignIn1.Location = new System.Drawing.Point(529, 117);
            this.ctrlSignIn1.Name = "ctrlSignIn1";
            this.ctrlSignIn1.Size = new System.Drawing.Size(720, 550);
            this.ctrlSignIn1.TabIndex = 12;
            // 
            // ctrlRegister1
            // 
            this.ctrlRegister1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ctrlRegister1.Location = new System.Drawing.Point(530, 115);
            this.ctrlRegister1.Name = "ctrlRegister1";
            this.ctrlRegister1.Size = new System.Drawing.Size(720, 550);
            this.ctrlRegister1.TabIndex = 13;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ctrlRegister1);
            this.Controls.Add(this.ctrlSignIn1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Button btnLoginPanel;
        private System.Windows.Forms.Button btnRegisterPanel;
        private System.Windows.Forms.Panel PanelIndicator;
        private System.Windows.Forms.Panel panelIndicator2;
        private CtrlSignIn ctrlSignIn1;
        private CtrlRegister ctrlRegister1;
    }
}