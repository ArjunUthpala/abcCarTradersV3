namespace abcCarTradersV1
{
    partial class AdminPanel
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAdminUname = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUserAcc = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelBrand = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCarDetails = new System.Windows.Forms.Button();
            this.btnCarPartsDetails = new System.Windows.Forms.Button();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.CurrentTabIndicator = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ctrlCarDetails1 = new abcCarTradersV1.CtrlCarDetails();
            this.ctrlCarPartsDetails1 = new abcCarTradersV1.CtrlCarPartsDetails();
            this.ctrlOrderDetails2 = new abcCarTradersV1.CtrlOrderDetails();
            this.ctrlReports2 = new abcCarTradersV1.CtrlReports();
            this.ctrlAdminDash1 = new abcCarTradersV1.CtrlAdminDash();
            this.btnAdminHome = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = System.Windows.Forms.Cursors.Default;
            label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Coral;
            label2.Location = new System.Drawing.Point(703, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(128, 22);
            label2.TabIndex = 1;
            label2.Text = "Admin panel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = System.Windows.Forms.Cursors.Default;
            label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.DarkGray;
            label3.Location = new System.Drawing.Point(328, 18);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(74, 21);
            label3.TabIndex = 3;
            label3.Text = "Admin : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtAdminUname);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnUserAcc);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 58);
            this.panel1.TabIndex = 0;
            // 
            // txtAdminUname
            // 
            this.txtAdminUname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.txtAdminUname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminUname.ForeColor = System.Drawing.Color.White;
            this.txtAdminUname.Location = new System.Drawing.Point(408, 16);
            this.txtAdminUname.Name = "txtAdminUname";
            this.txtAdminUname.ReadOnly = true;
            this.txtAdminUname.Size = new System.Drawing.Size(105, 27);
            this.txtAdminUname.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1109, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(121, 37);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "          Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1236, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUserAcc
            // 
            this.btnUserAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnUserAcc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserAcc.BackgroundImage")));
            this.btnUserAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserAcc.FlatAppearance.BorderSize = 0;
            this.btnUserAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAcc.Location = new System.Drawing.Point(290, 12);
            this.btnUserAcc.Name = "btnUserAcc";
            this.btnUserAcc.Size = new System.Drawing.Size(32, 32);
            this.btnUserAcc.TabIndex = 3;
            this.btnUserAcc.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Goldenrod;
            this.panel3.Controls.Add(this.labelBrand);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 58);
            this.panel3.TabIndex = 0;
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBrand.Location = new System.Drawing.Point(39, 15);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(186, 26);
            this.labelBrand.TabIndex = 0;
            this.labelBrand.Text = "ABC Car Traders";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnAdminHome);
            this.panel2.Controls.Add(this.btnCarDetails);
            this.panel2.Controls.Add(this.btnCarPartsDetails);
            this.panel2.Controls.Add(this.btnOrderDetails);
            this.panel2.Controls.Add(this.btnReports);
            this.panel2.Controls.Add(this.CurrentTabIndicator);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 662);
            this.panel2.TabIndex = 1;
            // 
            // btnCarDetails
            // 
            this.btnCarDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnCarDetails.FlatAppearance.BorderSize = 0;
            this.btnCarDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarDetails.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarDetails.ForeColor = System.Drawing.Color.White;
            this.btnCarDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnCarDetails.Image")));
            this.btnCarDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarDetails.Location = new System.Drawing.Point(37, 78);
            this.btnCarDetails.Name = "btnCarDetails";
            this.btnCarDetails.Size = new System.Drawing.Size(275, 51);
            this.btnCarDetails.TabIndex = 5;
            this.btnCarDetails.Text = "        Car Details";
            this.btnCarDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarDetails.UseVisualStyleBackColor = false;
            this.btnCarDetails.Click += new System.EventHandler(this.btnCarDetails_Click);
            // 
            // btnCarPartsDetails
            // 
            this.btnCarPartsDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnCarPartsDetails.FlatAppearance.BorderSize = 0;
            this.btnCarPartsDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarPartsDetails.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarPartsDetails.ForeColor = System.Drawing.Color.White;
            this.btnCarPartsDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnCarPartsDetails.Image")));
            this.btnCarPartsDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarPartsDetails.Location = new System.Drawing.Point(37, 135);
            this.btnCarPartsDetails.Name = "btnCarPartsDetails";
            this.btnCarPartsDetails.Size = new System.Drawing.Size(275, 51);
            this.btnCarPartsDetails.TabIndex = 5;
            this.btnCarPartsDetails.Text = "        Car Parts Details";
            this.btnCarPartsDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarPartsDetails.UseVisualStyleBackColor = false;
            this.btnCarPartsDetails.Click += new System.EventHandler(this.btnCarPartsDetails_Click);
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnOrderDetails.FlatAppearance.BorderSize = 0;
            this.btnOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderDetails.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDetails.ForeColor = System.Drawing.Color.White;
            this.btnOrderDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderDetails.Image")));
            this.btnOrderDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderDetails.Location = new System.Drawing.Point(37, 192);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(275, 51);
            this.btnOrderDetails.TabIndex = 4;
            this.btnOrderDetails.Text = "        Order Details";
            this.btnOrderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderDetails.UseVisualStyleBackColor = false;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(37, 249);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(275, 51);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "        Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // CurrentTabIndicator
            // 
            this.CurrentTabIndicator.BackColor = System.Drawing.Color.SpringGreen;
            this.CurrentTabIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentTabIndicator.ForeColor = System.Drawing.Color.White;
            this.CurrentTabIndicator.Location = new System.Drawing.Point(0, 21);
            this.CurrentTabIndicator.Name = "CurrentTabIndicator";
            this.CurrentTabIndicator.Size = new System.Drawing.Size(17, 51);
            this.CurrentTabIndicator.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1280, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 662);
            this.panel5.TabIndex = 2;
            // 
            // ctrlCarDetails1
            // 
            this.ctrlCarDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ctrlCarDetails1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCarDetails1.Location = new System.Drawing.Point(288, 76);
            this.ctrlCarDetails1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlCarDetails1.Name = "ctrlCarDetails1";
            this.ctrlCarDetails1.Size = new System.Drawing.Size(977, 626);
            this.ctrlCarDetails1.TabIndex = 6;
            // 
            // ctrlCarPartsDetails1
            // 
            this.ctrlCarPartsDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ctrlCarPartsDetails1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCarPartsDetails1.Location = new System.Drawing.Point(288, 76);
            this.ctrlCarPartsDetails1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlCarPartsDetails1.Name = "ctrlCarPartsDetails1";
            this.ctrlCarPartsDetails1.Size = new System.Drawing.Size(977, 626);
            this.ctrlCarPartsDetails1.TabIndex = 5;
            // 
            // ctrlOrderDetails2
            // 
            this.ctrlOrderDetails2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ctrlOrderDetails2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlOrderDetails2.Location = new System.Drawing.Point(288, 76);
            this.ctrlOrderDetails2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlOrderDetails2.Name = "ctrlOrderDetails2";
            this.ctrlOrderDetails2.Size = new System.Drawing.Size(977, 626);
            this.ctrlOrderDetails2.TabIndex = 4;
            // 
            // ctrlReports2
            // 
            this.ctrlReports2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ctrlReports2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlReports2.Location = new System.Drawing.Point(288, 76);
            this.ctrlReports2.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlReports2.Name = "ctrlReports2";
            this.ctrlReports2.Size = new System.Drawing.Size(977, 626);
            this.ctrlReports2.TabIndex = 3;
            // 
            // ctrlAdminDash1
            // 
            this.ctrlAdminDash1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ctrlAdminDash1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlAdminDash1.ForeColor = System.Drawing.Color.DarkOrange;
            this.ctrlAdminDash1.Location = new System.Drawing.Point(288, 76);
            this.ctrlAdminDash1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlAdminDash1.Name = "ctrlAdminDash1";
            this.ctrlAdminDash1.Size = new System.Drawing.Size(978, 629);
            this.ctrlAdminDash1.TabIndex = 7;
            // 
            // btnAdminHome
            // 
            this.btnAdminHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnAdminHome.FlatAppearance.BorderSize = 0;
            this.btnAdminHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminHome.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminHome.ForeColor = System.Drawing.Color.White;
            this.btnAdminHome.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminHome.Image")));
            this.btnAdminHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminHome.Location = new System.Drawing.Point(37, 21);
            this.btnAdminHome.Name = "btnAdminHome";
            this.btnAdminHome.Size = new System.Drawing.Size(238, 51);
            this.btnAdminHome.TabIndex = 7;
            this.btnAdminHome.Text = "        Home";
            this.btnAdminHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminHome.UseVisualStyleBackColor = false;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.ctrlAdminDash1);
            this.Controls.Add(this.ctrlCarDetails1);
            this.Controls.Add(this.ctrlCarPartsDetails1);
            this.Controls.Add(this.ctrlOrderDetails2);
            this.Controls.Add(this.ctrlReports2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel CurrentTabIndicator;
        private System.Windows.Forms.Button btnCarDetails;
        private System.Windows.Forms.Button btnCarPartsDetails;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnReports;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUserAcc;
        private System.Windows.Forms.Button btnLogout;
   
      //  private CtrlOrderDetails orderDetails1;
      //  private CtrlAdminDash ctrlAdminDash1;
   
   

        private System.Windows.Forms.TextBox txtAdminUname;
        private CtrlReports ctrlReports2;
        private CtrlOrderDetails ctrlOrderDetails2;
        private CtrlCarPartsDetails ctrlCarPartsDetails1;
        private CtrlCarDetails ctrlCarDetails1;
        private CtrlAdminDash ctrlAdminDash1;
        private System.Windows.Forms.Button btnAdminHome;
    }
}

