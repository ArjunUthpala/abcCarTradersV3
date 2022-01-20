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
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btnDash = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.adminDashboard1 = new abcCarTradersV1.AdminDashboard();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
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
            label2.ForeColor = System.Drawing.Color.DarkGray;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = System.Windows.Forms.Cursors.Default;
            label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.DarkGray;
            label4.Location = new System.Drawing.Point(398, 19);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(51, 21);
            label4.TabIndex = 6;
            label4.Text = "Arjun";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(label4);
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
            this.panel2.Controls.Add(this.btnCarDetails);
            this.panel2.Controls.Add(this.btnCarPartsDetails);
            this.panel2.Controls.Add(this.btnOrderDetails);
            this.panel2.Controls.Add(this.btnReports);
            this.panel2.Controls.Add(this.btnDash);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 662);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.btnCarDetails.Click += new System.EventHandler(this.button5_Click);
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
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnDash.FlatAppearance.BorderSize = 0;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.Color.White;
            this.btnDash.Image = ((System.Drawing.Image)(resources.GetObject("btnDash.Image")));
            this.btnDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDash.Location = new System.Drawing.Point(37, 21);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(275, 51);
            this.btnDash.TabIndex = 0;
            this.btnDash.Text = "        Dashboard";
            this.btnDash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SpringGreen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 51);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
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
            // adminDashboard1
            // 
            this.adminDashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.adminDashboard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminDashboard1.Location = new System.Drawing.Point(289, 76);
            this.adminDashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(978, 629);
            this.adminDashboard1.TabIndex = 3;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.adminDashboard1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnCarDetails;
        private System.Windows.Forms.Button btnCarPartsDetails;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnReports;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUserAcc;
        private System.Windows.Forms.Button btnLogout;
        private AdminDashboard adminDashboard1;
    }
}

