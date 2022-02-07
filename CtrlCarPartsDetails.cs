using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DAO;
using DAL.DTO;
using System.IO;

namespace abcCarTradersV1
{
    public partial class CtrlCarPartsDetails : UserControl
    {
        int Part_id;
        string item_code;
        string pictureName = "";
        string imgPath = "";
        CarPartsDetailsDTO carPartsDetailsDTO = new CarPartsDetailsDTO();
        public CtrlCarPartsDetails()
        {
            InitializeComponent();
        }

        private void CtrlCarPartsDetails_Load(object sender, EventArgs e)
        {
            DisplayDataonLoad();
            dataGridViewCarPartsDetails.Columns[0].Visible = false;

            carPartsDetailsDTO = CarPartsDetailsBLL.GetAll();

            //load part brands to combo box
            comboBoxPartBrand.DataSource = carPartsDetailsDTO.PartBrand;
            comboBoxPartBrand.DisplayMember = "PartBrand";
            comboBoxPartBrand.ValueMember = "PartBrand_ID";
            comboBoxPartBrand.SelectedIndex = -1;

            //load Car brands to combo box
            comboBoxCarBrand.DataSource = carPartsDetailsDTO.CarBrands;
            comboBoxCarBrand.DisplayMember = "CarBrand";
            comboBoxCarBrand.ValueMember = "CarBrand_ID";
            comboBoxCarBrand.SelectedIndex = -1;

            //load Car brands to combo box  
            comboBoxCarModel.DataSource = carPartsDetailsDTO.CarModels;
            comboBoxCarModel.DisplayMember = "CarModel";
            comboBoxCarModel.ValueMember = "CarModel_ID";
            comboBoxCarModel.SelectedIndex = -1;
            combofull = true;
        }

        void Clear()
        {
            comboBoxPartBrand.SelectedIndex = -1;
            txtPartName.Clear();
            comboBoxCarBrand.SelectedIndex = -1;
            comboBoxCarModel.SelectedIndex = -1;
            dateTimePickerYOM.ResetText();
            comboBoxCondition.SelectedIndex = -1;
            txtItemCode.Clear();
            txtImgPath.Clear();

            txtQTY.Clear();
            txtPrice.Clear();
            dateTimePickerDateAdded.ResetText();
        }

        void DisplayDataonLoad()
        {
            //create data grid view for Car Details
            List<tbl_car_part> CarPartDetails = new List<tbl_car_part>();
            CarPartDetails = CarPartsDetailsBLL.GetCarPartsDetails();
            dataGridViewCarPartsDetails.DataSource = CarPartDetails;
            dataGridViewCarPartsDetails.AutoGenerateColumns = false;
            dataGridViewCarPartsDetails.DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
            dataGridViewCarPartsDetails.ColumnHeadersDefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            this.dataGridViewCarPartsDetails.Columns["tbl_inventory"].Visible = false;
        }

        bool combofull = false;
        private void comboBoxCarBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                comboBoxCarModel.DataSource = carPartsDetailsDTO.CarModels.Where(x => x.CarBrand_ID ==
                Convert.ToInt32(comboBoxCarBrand.SelectedValue)).ToList();
            }
        }

        private void dataGridViewCarPartsDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //assiging values from data grid to the relavant input fields
            Part_id = Convert.ToInt32(dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtPartName.Text = dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxPartBrand.Text = Convert.ToString(dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[2].Value.ToString());
            comboBoxCarBrand.Text = Convert.ToString(dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[3].Value.ToString());
            comboBoxCarModel.Text = Convert.ToString(dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[4].Value.ToString());
            dateTimePickerYOM.Value = Convert.ToDateTime(dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[5].Value.ToString());
            comboBoxCondition.Text = Convert.ToString(dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[6].Value.ToString());
            txtItemCode.Text = dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtImgPath.Text = dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[8].Value.ToString();


            //retrive inventory details matching for the selected car part
            item_code = txtItemCode.Text;
            tbl_inventory item = new tbl_inventory();
            item = InventoryBLL.GetOneItem(item_code);
            txtQTY.Text = Convert.ToString(item.QTY);
            txtPrice.Text = Convert.ToString(item.Price);
            dateTimePickerDateAdded.Value = Convert.ToDateTime(item.DateAdded);

            //viewing the selected car image
            tbl_car_part carpart = new tbl_car_part();
            carpart = CarPartsDetailsBLL.MatchCarPart(Part_id);
            imgPath = Application.StartupPath + "\\images\\" + carpart.ImagePath;
            pictureBoxCarPart.ImageLocation = imgPath;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtPartName.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Part Name", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartName.Focus();
            }
            else if (comboBoxCarBrand.Text.Trim() == "")
            {
                MessageBox.Show("Please Select a Car Brand", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCarBrand.Focus();
            }
            else if (comboBoxPartBrand.Text.Trim() == "")
            {
                MessageBox.Show("Please Select a Fuel Type", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxPartBrand.Focus();
            }
            else if (comboBoxCondition.Text.Trim() == "")
            {
                MessageBox.Show("Please Select Current Car Part Condition", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCondition.Focus();
            }
            else if (txtItemCode.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Item Code", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemCode.Focus();
            }
            else if (txtImgPath.Text.Trim() == "")
            {
                MessageBox.Show("Please Select an image", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtImgPath.Focus();
            }
            else if (txtQTY.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Quantity Available", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQTY.Focus();
            }
            else if (txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Car Part Price", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
            }
            else
            {
                tbl_inventory item = new tbl_inventory();
                item.ItemCode = txtItemCode.Text;
                item.Price = Convert.ToInt32(txtPrice.Text);
                item.QTY = Convert.ToInt32(txtQTY.Text);
                item.DateAdded = Convert.ToDateTime(dateTimePickerDateAdded.Value);
                InventoryBLL.AddItem(item);

                tbl_car_part carpart = new tbl_car_part();
                carpart.CarBrand = Convert.ToString(comboBoxCarBrand.Text);
                carpart.CarModel = Convert.ToString(comboBoxCarModel.Text);
                carpart.YOM = Convert.ToDateTime(dateTimePickerYOM.Value);
                carpart.PartBrandName = Convert.ToString(comboBoxPartBrand.Text);
                carpart.CarPartName = txtPartName.Text;
                carpart.ItemCode = txtItemCode.Text;
                carpart.Condition = Convert.ToString(comboBoxCondition.Text);
                carpart.ImagePath = pictureName;
                File.Copy(txtImgPath.Text, @"images\\" + pictureName);
                CarPartsDetailsBLL.AddCarPartDetails(carpart);
                DisplayDataonLoad();
                MessageBox.Show("Car Part Successfully Inserted!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPartName.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Part Name", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartName.Focus();
            }
            else if (comboBoxCarBrand.Text.Trim() == "")
            {
                MessageBox.Show("Please Select a Car Brand", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCarBrand.Focus();
            }
            else if (comboBoxPartBrand.Text.Trim() == "")
            {
                MessageBox.Show("Please Select a Fuel Type", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxPartBrand.Focus();
            }
            else if (comboBoxCondition.Text.Trim() == "")
            {
                MessageBox.Show("Please Select Current Car Part Condition", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCondition.Focus();
            }
            else if (txtItemCode.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Item Code", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemCode.Focus();
            }
            else if (txtImgPath.Text.Trim() == "")
            {
                MessageBox.Show("Please Select an image", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtImgPath.Focus();
            }
            else if (txtQTY.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Quantity Available", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQTY.Focus();
            }
            else if (txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Car Part Price", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
            }
            else
            {
                tbl_inventory item = new tbl_inventory();
                item = InventoryBLL.MatchItem(item_code);
                item.Price = Convert.ToInt32(txtPrice.Text);
                item.QTY = Convert.ToInt32(txtQTY.Text);
                item.DateAdded = Convert.ToDateTime(dateTimePickerDateAdded.Value);
                InventoryBLL.UpdateItem(item);

                tbl_car_part carpart = new tbl_car_part();
                carpart = CarPartsDetailsBLL.MatchCarPart(Part_id);

                if (txtImgPath.Text != carpart.ImagePath)
                {
                    if (File.Exists(@"images\\" + carpart.ImagePath))
                    {
                        File.Delete(@"images\\" + carpart.ImagePath);
                    }
                    File.Copy(txtImgPath.Text, @"images\\" + pictureName);
                    carpart.ImagePath = pictureName;

                }
                carpart.CarBrand = Convert.ToString(comboBoxCarBrand.Text);
                carpart.CarModel = Convert.ToString(comboBoxCarModel.Text);
                carpart.YOM = Convert.ToDateTime(dateTimePickerYOM.Value);
                carpart.PartBrandName = Convert.ToString(comboBoxPartBrand.Text);
                carpart.CarPartName = txtPartName.Text;
                carpart.Condition = Convert.ToString(comboBoxCondition.Text);
                CarPartsDetailsBLL.UpdateCarPartDetails(carpart);
                DisplayDataonLoad();
                MessageBox.Show("Car Successfully Updated!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult DeleteConfirmation = MessageBox.Show("Confirm Delete Request", "Confirm Delete", MessageBoxButtons.OKCancel);
            if (DeleteConfirmation == DialogResult.OK)
            {
                tbl_car_part carpart = new tbl_car_part();
                carpart = CarPartsDetailsBLL.MatchCarPart(Part_id);
                CarPartsDetailsBLL.DeleteCarPartDetails(carpart);

                tbl_inventory item = new tbl_inventory();
                item = InventoryBLL.MatchItem(item_code);
                InventoryBLL.DeleteItem(item);

                DisplayDataonLoad();
                Clear();
                MessageBox.Show("Delete Success!", "Deleted", MessageBoxButtons.OK);
            }
        }

        private void btnBrowseImg_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureName = "";
                pictureBoxCarPart.Load(openFileDialog1.FileName);
                txtImgPath.Text = openFileDialog1.FileName;
                string unique = Guid.NewGuid().ToString();
                pictureName += unique + openFileDialog1.SafeFileName;
            }
        }
    }
}
