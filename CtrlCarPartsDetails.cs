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

namespace abcCarTradersV1
{
    public partial class CtrlCarPartsDetails : UserControl
    {
        int Part_id;
        string item_code;
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

            //retrive inventory details matching for the selected car part
            item_code = txtItemCode.Text;
            tbl_inventory item = new tbl_inventory();
            item = InventoryBLL.GetOneItem(item_code);
            txtQTY.Text = Convert.ToString(item.QTY);
            txtPrice.Text = Convert.ToString(item.Price);
            dateTimePickerDateAdded.Value = Convert.ToDateTime(item.DateAdded);
        }

        private void btnInsert_Click(object sender, EventArgs e)
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
            CarPartsDetailsBLL.AddCarPartDetails(carpart);
            DisplayDataonLoad();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tbl_inventory item = new tbl_inventory();
            item = InventoryBLL.MatchItem(item_code);
            item.Price = Convert.ToInt32(txtPrice.Text);
            item.QTY = Convert.ToInt32(txtQTY.Text);
            item.DateAdded = Convert.ToDateTime(dateTimePickerDateAdded.Value);
            InventoryBLL.UpdateItem(item);

            tbl_car_part carpart = new tbl_car_part();
            carpart = CarPartsDetailsBLL.MatchCarPart(Part_id);
            carpart.CarBrand = Convert.ToString(comboBoxCarBrand.Text);
            carpart.CarModel = Convert.ToString(comboBoxCarModel.Text);
            carpart.YOM = Convert.ToDateTime(dateTimePickerYOM.Value);
            carpart.PartBrandName = Convert.ToString(comboBoxPartBrand.Text);
            carpart.CarPartName = txtPartName.Text;
            carpart.Condition = Convert.ToString(comboBoxCondition.Text);
            CarPartsDetailsBLL.UpdateCarPartDetails(carpart);
            DisplayDataonLoad();
            Clear();
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
    }
}
