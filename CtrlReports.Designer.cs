namespace abcCarTradersV1
{
    partial class CtrlReports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlReports));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestockReport = new System.Windows.Forms.Button();
            this.btnOrderStateReport = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "Reports";
            // 
            // btnRestockReport
            // 
            this.btnRestockReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnRestockReport.FlatAppearance.BorderSize = 0;
            this.btnRestockReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestockReport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestockReport.ForeColor = System.Drawing.Color.White;
            this.btnRestockReport.Image = ((System.Drawing.Image)(resources.GetObject("btnRestockReport.Image")));
            this.btnRestockReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestockReport.Location = new System.Drawing.Point(56, 148);
            this.btnRestockReport.Name = "btnRestockReport";
            this.btnRestockReport.Size = new System.Drawing.Size(275, 51);
            this.btnRestockReport.TabIndex = 35;
            this.btnRestockReport.Text = "        Parts to be Restocked";
            this.btnRestockReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestockReport.UseVisualStyleBackColor = false;
            this.btnRestockReport.Click += new System.EventHandler(this.btnRestockReport_Click);
            // 
            // btnOrderStateReport
            // 
            this.btnOrderStateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnOrderStateReport.FlatAppearance.BorderSize = 0;
            this.btnOrderStateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderStateReport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderStateReport.ForeColor = System.Drawing.Color.White;
            this.btnOrderStateReport.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderStateReport.Image")));
            this.btnOrderStateReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderStateReport.Location = new System.Drawing.Point(56, 220);
            this.btnOrderStateReport.Name = "btnOrderStateReport";
            this.btnOrderStateReport.Size = new System.Drawing.Size(275, 51);
            this.btnOrderStateReport.TabIndex = 34;
            this.btnOrderStateReport.Text = "        Order State Summary";
            this.btnOrderStateReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderStateReport.UseVisualStyleBackColor = false;
            this.btnOrderStateReport.Click += new System.EventHandler(this.btnOrderStateReport_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnSalesReport.FlatAppearance.BorderSize = 0;
            this.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.ForeColor = System.Drawing.Color.White;
            this.btnSalesReport.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesReport.Image")));
            this.btnSalesReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesReport.Location = new System.Drawing.Point(56, 76);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(275, 51);
            this.btnSalesReport.TabIndex = 33;
            this.btnSalesReport.Text = "        Sales Report";
            this.btnSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesReport.UseVisualStyleBackColor = false;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // CtrlReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btnRestockReport);
            this.Controls.Add(this.btnOrderStateReport);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CtrlReports";
            this.Size = new System.Drawing.Size(977, 626);
            this.Load += new System.EventHandler(this.CtrlReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestockReport;
        private System.Windows.Forms.Button btnOrderStateReport;
        private System.Windows.Forms.Button btnSalesReport;
    }
}
