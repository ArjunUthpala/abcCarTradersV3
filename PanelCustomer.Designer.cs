namespace abcCarTradersV1
{
    partial class PanelCustomer
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelCustomer));
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnOrderCar = new System.Windows.Forms.Button();
            this.btnCarPartsOrder = new System.Windows.Forms.Button();
            this.btnMyOrders = new System.Windows.Forms.Button();
            this.CurrentTabIndicator = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCusHome = new System.Windows.Forms.Button();
            this.labelBrand = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUserAcc = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCusUname = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ctrlCusHome1 = new abcCarTradersV1.CtrlCusHome();
            this.ctrlCusDetails1 = new abcCarTradersV1.CtrlCusDetails();
            this.ctrlCusCarOrder1 = new abcCarTradersV1.CtrlCusCarOrder();
            this.ctrlCusCarPartOrder1 = new abcCarTradersV1.CtrlCusCarPartOrder();
            this.ctrlCusOrderSummary1 = new abcCarTradersV1.CtrlCusOrderSummary();
            this.btnProfile = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = System.Windows.Forms.Cursors.Default;
            label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.DarkGray;
            label3.Location = new System.Drawing.Point(328, 18);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 21);
            label3.TabIndex = 3;
            label3.Text = "Customer : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = System.Windows.Forms.Cursors.Default;
            label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.DarkGray;
            label2.Location = new System.Drawing.Point(685, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(156, 22);
            label2.TabIndex = 1;
            label2.Text = "Customer panel";
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1280, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 662);
            this.panel5.TabIndex = 5;
            // 
            // btnOrderCar
            // 
            this.btnOrderCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnOrderCar.FlatAppearance.BorderSize = 0;
            this.btnOrderCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderCar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCar.ForeColor = System.Drawing.Color.White;
            this.btnOrderCar.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderCar.Image")));
            this.btnOrderCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderCar.Location = new System.Drawing.Point(37, 76);
            this.btnOrderCar.Name = "btnOrderCar";
            this.btnOrderCar.Size = new System.Drawing.Size(238, 51);
            this.btnOrderCar.TabIndex = 5;
            this.btnOrderCar.Text = "        Order a Car";
            this.btnOrderCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderCar.UseVisualStyleBackColor = false;
            this.btnOrderCar.Click += new System.EventHandler(this.btnOrderCar_Click);
            // 
            // btnCarPartsOrder
            // 
            this.btnCarPartsOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnCarPartsOrder.FlatAppearance.BorderSize = 0;
            this.btnCarPartsOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarPartsOrder.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarPartsOrder.ForeColor = System.Drawing.Color.White;
            this.btnCarPartsOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnCarPartsOrder.Image")));
            this.btnCarPartsOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarPartsOrder.Location = new System.Drawing.Point(37, 133);
            this.btnCarPartsOrder.Name = "btnCarPartsOrder";
            this.btnCarPartsOrder.Size = new System.Drawing.Size(238, 51);
            this.btnCarPartsOrder.TabIndex = 5;
            this.btnCarPartsOrder.Text = "        Order Car Parts";
            this.btnCarPartsOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarPartsOrder.UseVisualStyleBackColor = false;
            this.btnCarPartsOrder.Click += new System.EventHandler(this.btnCarPartsOrder_Click);
            // 
            // btnMyOrders
            // 
            this.btnMyOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnMyOrders.FlatAppearance.BorderSize = 0;
            this.btnMyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyOrders.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyOrders.ForeColor = System.Drawing.Color.White;
            this.btnMyOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnMyOrders.Image")));
            this.btnMyOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyOrders.Location = new System.Drawing.Point(37, 190);
            this.btnMyOrders.Name = "btnMyOrders";
            this.btnMyOrders.Size = new System.Drawing.Size(238, 51);
            this.btnMyOrders.TabIndex = 4;
            this.btnMyOrders.Text = "        My Orders";
            this.btnMyOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyOrders.UseVisualStyleBackColor = false;
            this.btnMyOrders.Click += new System.EventHandler(this.btnMyOrders_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnProfile);
            this.panel2.Controls.Add(this.btnCusHome);
            this.panel2.Controls.Add(this.btnOrderCar);
            this.panel2.Controls.Add(this.btnCarPartsOrder);
            this.panel2.Controls.Add(this.btnMyOrders);
            this.panel2.Controls.Add(this.CurrentTabIndicator);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 662);
            this.panel2.TabIndex = 4;
            // 
            // btnCusHome
            // 
            this.btnCusHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnCusHome.FlatAppearance.BorderSize = 0;
            this.btnCusHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusHome.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusHome.ForeColor = System.Drawing.Color.White;
            this.btnCusHome.Image = ((System.Drawing.Image)(resources.GetObject("btnCusHome.Image")));
            this.btnCusHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCusHome.Location = new System.Drawing.Point(37, 21);
            this.btnCusHome.Name = "btnCusHome";
            this.btnCusHome.Size = new System.Drawing.Size(238, 51);
            this.btnCusHome.TabIndex = 6;
            this.btnCusHome.Text = "        Home";
            this.btnCusHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCusHome.UseVisualStyleBackColor = false;
            this.btnCusHome.Click += new System.EventHandler(this.btnCusHome_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtCusUname);
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
            this.panel1.TabIndex = 3;
            // 
            // txtCusUname
            // 
            this.txtCusUname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.txtCusUname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusUname.ForeColor = System.Drawing.Color.White;
            this.txtCusUname.Location = new System.Drawing.Point(425, 16);
            this.txtCusUname.Name = "txtCusUname";
            this.txtCusUname.ReadOnly = true;
            this.txtCusUname.Size = new System.Drawing.Size(105, 27);
            this.txtCusUname.TabIndex = 9;
            // 
            // ctrlCusHome1
            // 
            this.ctrlCusHome1.BackColor = System.Drawing.Color.Goldenrod;
            this.ctrlCusHome1.Location = new System.Drawing.Point(290, 73);
            this.ctrlCusHome1.Name = "ctrlCusHome1";
            this.ctrlCusHome1.Size = new System.Drawing.Size(978, 629);
            this.ctrlCusHome1.TabIndex = 10;
            // 
            // ctrlCusDetails1
            // 
            this.ctrlCusDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ctrlCusDetails1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCusDetails1.Location = new System.Drawing.Point(290, 76);
            this.ctrlCusDetails1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlCusDetails1.Name = "ctrlCusDetails1";
            this.ctrlCusDetails1.Size = new System.Drawing.Size(977, 626);
            this.ctrlCusDetails1.TabIndex = 9;
            // 
            // ctrlCusCarOrder1
            // 
            this.ctrlCusCarOrder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ctrlCusCarOrder1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCusCarOrder1.Location = new System.Drawing.Point(290, 76);
            this.ctrlCusCarOrder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlCusCarOrder1.Name = "ctrlCusCarOrder1";
            this.ctrlCusCarOrder1.Size = new System.Drawing.Size(977, 626);
            this.ctrlCusCarOrder1.TabIndex = 8;
            // 
            // ctrlCusCarPartOrder1
            // 
            this.ctrlCusCarPartOrder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ctrlCusCarPartOrder1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCusCarPartOrder1.Location = new System.Drawing.Point(290, 76);
            this.ctrlCusCarPartOrder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlCusCarPartOrder1.Name = "ctrlCusCarPartOrder1";
            this.ctrlCusCarPartOrder1.Size = new System.Drawing.Size(977, 626);
            this.ctrlCusCarPartOrder1.TabIndex = 7;
            // 
            // ctrlCusOrderSummary1
            // 
            this.ctrlCusOrderSummary1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ctrlCusOrderSummary1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCusOrderSummary1.Location = new System.Drawing.Point(290, 76);
            this.ctrlCusOrderSummary1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlCusOrderSummary1.Name = "ctrlCusOrderSummary1";
            this.ctrlCusOrderSummary1.Size = new System.Drawing.Size(977, 626);
            this.ctrlCusOrderSummary1.TabIndex = 6;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(37, 246);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(238, 51);
            this.btnProfile.TabIndex = 7;
            this.btnProfile.Text = "        My Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // PanelCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.ctrlCusHome1);
            this.Controls.Add(this.ctrlCusDetails1);
            this.Controls.Add(this.ctrlCusCarOrder1);
            this.Controls.Add(this.ctrlCusCarPartOrder1);
            this.Controls.Add(this.ctrlCusOrderSummary1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.PanelCustomer_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnOrderCar;
        private System.Windows.Forms.Button btnCarPartsOrder;
        private System.Windows.Forms.Button btnMyOrders;
        private System.Windows.Forms.Panel CurrentTabIndicator;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUserAcc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCusHome;
        private System.Windows.Forms.TextBox txtCusUname;
        private CtrlCusOrderSummary ctrlCusOrderSummary1;
        private CtrlCusCarPartOrder ctrlCusCarPartOrder1;
        private CtrlCusCarOrder ctrlCusCarOrder1;
        private CtrlCusDetails ctrlCusDetails1;
        private CtrlCusHome ctrlCusHome1;
        private System.Windows.Forms.Button btnProfile;
    }
}