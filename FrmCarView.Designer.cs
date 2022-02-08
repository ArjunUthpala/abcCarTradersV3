
namespace abcCarTradersV1
{
    partial class FrmCarView
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
            this.comboBoxCarModel = new System.Windows.Forms.ComboBox();
            this.comboBoxCondition = new System.Windows.Forms.ComboBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTrimType = new System.Windows.Forms.ComboBox();
            this.txtEngineCapacity = new System.Windows.Forms.TextBox();
            this.txtMilage = new System.Windows.Forms.TextBox();
            this.comboBoxTransmission = new System.Windows.Forms.ComboBox();
            this.comboBoxFuelType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerYOM = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCarBrand = new System.Windows.Forms.ComboBox();
            this.txtNoOfSeats = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCarModel
            // 
            this.comboBoxCarModel.DisplayMember = "CarBrand";
            this.comboBoxCarModel.Enabled = false;
            this.comboBoxCarModel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCarModel.FormattingEnabled = true;
            this.comboBoxCarModel.Location = new System.Drawing.Point(196, 158);
            this.comboBoxCarModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCarModel.Name = "comboBoxCarModel";
            this.comboBoxCarModel.Size = new System.Drawing.Size(124, 29);
            this.comboBoxCarModel.TabIndex = 98;
            this.comboBoxCarModel.ValueMember = "CarBrand_ID";
            // 
            // comboBoxCondition
            // 
            this.comboBoxCondition.Enabled = false;
            this.comboBoxCondition.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCondition.FormattingEnabled = true;
            this.comboBoxCondition.Items.AddRange(new object[] {
            "Brand New",
            "Used",
            "Reconditioned"});
            this.comboBoxCondition.Location = new System.Drawing.Point(196, 340);
            this.comboBoxCondition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCondition.Name = "comboBoxCondition";
            this.comboBoxCondition.Size = new System.Drawing.Size(124, 28);
            this.comboBoxCondition.TabIndex = 96;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Enabled = false;
            this.txtItemCode.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(196, 71);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(124, 27);
            this.txtItemCode.TabIndex = 95;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(48, 341);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 22);
            this.label14.TabIndex = 94;
            this.label14.Text = "Condition";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(48, 72);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 22);
            this.label15.TabIndex = 93;
            this.label15.Text = "Item Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 72;
            this.label1.Text = "Car Details";
            // 
            // comboBoxTrimType
            // 
            this.comboBoxTrimType.Enabled = false;
            this.comboBoxTrimType.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTrimType.FormattingEnabled = true;
            this.comboBoxTrimType.Items.AddRange(new object[] {
            "Sedan",
            "Wagon",
            "Van"});
            this.comboBoxTrimType.Location = new System.Drawing.Point(196, 475);
            this.comboBoxTrimType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTrimType.Name = "comboBoxTrimType";
            this.comboBoxTrimType.Size = new System.Drawing.Size(124, 28);
            this.comboBoxTrimType.TabIndex = 89;
            // 
            // txtEngineCapacity
            // 
            this.txtEngineCapacity.Enabled = false;
            this.txtEngineCapacity.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEngineCapacity.Location = new System.Drawing.Point(226, 432);
            this.txtEngineCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEngineCapacity.Name = "txtEngineCapacity";
            this.txtEngineCapacity.Size = new System.Drawing.Size(94, 27);
            this.txtEngineCapacity.TabIndex = 88;
            // 
            // txtMilage
            // 
            this.txtMilage.Enabled = false;
            this.txtMilage.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMilage.Location = new System.Drawing.Point(196, 295);
            this.txtMilage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMilage.Name = "txtMilage";
            this.txtMilage.Size = new System.Drawing.Size(124, 27);
            this.txtMilage.TabIndex = 87;
            // 
            // comboBoxTransmission
            // 
            this.comboBoxTransmission.Enabled = false;
            this.comboBoxTransmission.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTransmission.FormattingEnabled = true;
            this.comboBoxTransmission.Items.AddRange(new object[] {
            "Manual",
            "Auto",
            "Triptonic"});
            this.comboBoxTransmission.Location = new System.Drawing.Point(226, 386);
            this.comboBoxTransmission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTransmission.Name = "comboBoxTransmission";
            this.comboBoxTransmission.Size = new System.Drawing.Size(94, 29);
            this.comboBoxTransmission.TabIndex = 86;
            // 
            // comboBoxFuelType
            // 
            this.comboBoxFuelType.Enabled = false;
            this.comboBoxFuelType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFuelType.FormattingEnabled = true;
            this.comboBoxFuelType.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "Hybrid",
            "Electric"});
            this.comboBoxFuelType.Location = new System.Drawing.Point(196, 249);
            this.comboBoxFuelType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxFuelType.Name = "comboBoxFuelType";
            this.comboBoxFuelType.Size = new System.Drawing.Size(124, 29);
            this.comboBoxFuelType.TabIndex = 85;
            // 
            // dateTimePickerYOM
            // 
            this.dateTimePickerYOM.Enabled = false;
            this.dateTimePickerYOM.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerYOM.Location = new System.Drawing.Point(196, 205);
            this.dateTimePickerYOM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerYOM.Name = "dateTimePickerYOM";
            this.dateTimePickerYOM.Size = new System.Drawing.Size(124, 27);
            this.dateTimePickerYOM.TabIndex = 84;
            // 
            // comboBoxCarBrand
            // 
            this.comboBoxCarBrand.DisplayMember = "CarBrand";
            this.comboBoxCarBrand.Enabled = false;
            this.comboBoxCarBrand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCarBrand.FormattingEnabled = true;
            this.comboBoxCarBrand.Location = new System.Drawing.Point(196, 113);
            this.comboBoxCarBrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCarBrand.Name = "comboBoxCarBrand";
            this.comboBoxCarBrand.Size = new System.Drawing.Size(124, 29);
            this.comboBoxCarBrand.TabIndex = 83;
            this.comboBoxCarBrand.ValueMember = "CarBrand_ID";
            // 
            // txtNoOfSeats
            // 
            this.txtNoOfSeats.Enabled = false;
            this.txtNoOfSeats.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfSeats.Location = new System.Drawing.Point(196, 520);
            this.txtNoOfSeats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoOfSeats.Name = "txtNoOfSeats";
            this.txtNoOfSeats.Size = new System.Drawing.Size(124, 27);
            this.txtNoOfSeats.TabIndex = 82;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(48, 432);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 22);
            this.label12.TabIndex = 81;
            this.label12.Text = "Engine Capacity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(48, 476);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 22);
            this.label11.TabIndex = 80;
            this.label11.Text = "Trim Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(48, 521);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 22);
            this.label10.TabIndex = 79;
            this.label10.Text = "No. of Seats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(48, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 22);
            this.label7.TabIndex = 78;
            this.label7.Text = "Car Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(48, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 22);
            this.label6.TabIndex = 77;
            this.label6.Text = "YOM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(48, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 76;
            this.label5.Text = "Fuel Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(48, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 75;
            this.label4.Text = "Milage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(48, 387);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 74;
            this.label3.Text = "Transmission";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(48, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 73;
            this.label2.Text = "Car Brand";
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Location = new System.Drawing.Point(376, 72);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(475, 475);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCar.TabIndex = 99;
            this.pictureBoxCar.TabStop = false;
            // 
            // FrmCarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(901, 604);
            this.Controls.Add(this.pictureBoxCar);
            this.Controls.Add(this.comboBoxCarModel);
            this.Controls.Add(this.comboBoxCondition);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTrimType);
            this.Controls.Add(this.txtEngineCapacity);
            this.Controls.Add(this.txtMilage);
            this.Controls.Add(this.comboBoxTransmission);
            this.Controls.Add(this.comboBoxFuelType);
            this.Controls.Add(this.dateTimePickerYOM);
            this.Controls.Add(this.comboBoxCarBrand);
            this.Controls.Add(this.txtNoOfSeats);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmCarView";
            this.Text = "Ordered Car";
            this.Load += new System.EventHandler(this.FrmCarView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxCarModel;
        private System.Windows.Forms.ComboBox comboBoxCondition;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTrimType;
        private System.Windows.Forms.TextBox txtEngineCapacity;
        private System.Windows.Forms.TextBox txtMilage;
        private System.Windows.Forms.ComboBox comboBoxTransmission;
        private System.Windows.Forms.ComboBox comboBoxFuelType;
        private System.Windows.Forms.DateTimePicker dateTimePickerYOM;
        private System.Windows.Forms.ComboBox comboBoxCarBrand;
        private System.Windows.Forms.TextBox txtNoOfSeats;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxCar;
    }
}