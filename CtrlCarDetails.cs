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
    public partial class CtrlCarDetails : UserControl
    {
        int Car_id;
        string item_code;
        CarDetailsDTO carDetailsDTO = new CarDetailsDTO();
        public CtrlCarDetails()
        {
            InitializeComponent();
        }

        private void CtrlCarDetails1_Load(object sender, EventArgs e)
        {
            DisplayDataonLoad();
            dataGridViewCarDetails.Columns[0].Visible = false;

            carDetailsDTO = CarDetailsBLL.GetAll();

            //load Car brands to combo box
            //  List<tbl_car_brand> CarBrands = new List<tbl_car_brand>();
            //  CarBrands = CarBrandsBLL.GetCarBrands();
            comboBoxCarBrand.DataSource = carDetailsDTO.CarBrands;
            comboBoxCarBrand.DisplayMember = "CarBrand";
            comboBoxCarBrand.ValueMember = "CarBrand_ID";
            comboBoxCarBrand.SelectedIndex = -1;

          //  List<tbl_car_model> CarModels = new List<tbl_car_model>();
          //  CarModels = CarModelBLL.GetCarModels();
            comboBoxCarModel.DataSource = carDetailsDTO.CarModels;
            comboBoxCarModel.DisplayMember = "CarModel";
            comboBoxCarModel.ValueMember = "CarModel_ID";
            comboBoxCarModel.SelectedIndex = -1;
           
        }

        void DisplayDataonLoad()
        {
            //create data grid view for Car Details
            List<tbl_car> CarDetails = new List<tbl_car>();
            CarDetails = CarDetailsBLL.GetCarDetails();
            dataGridViewCarDetails.DataSource = CarDetails;
            dataGridViewCarDetails.AutoGenerateColumns = false;
            dataGridViewCarDetails.DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
            dataGridViewCarDetails.ColumnHeadersDefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            this.dataGridViewCarDetails.Columns["tbl_inventory"].Visible = false;
        }

        private void dataGridViewCarDetails_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //assiging values from data grid to the relavant input fields
            Car_id = Convert.ToInt32(dataGridViewCarDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
            comboBoxCarBrand.Text = Convert.ToString(dataGridViewCarDetails.Rows[e.RowIndex].Cells[1].Value.ToString());
            comboBoxCarModel.Text = Convert.ToString(dataGridViewCarDetails.Rows[e.RowIndex].Cells[2].Value.ToString());
            dateTimePickerYOM.Value = Convert.ToDateTime(dataGridViewCarDetails.Rows[e.RowIndex].Cells[3].Value.ToString());
            comboBoxCondition.Text = Convert.ToString(dataGridViewCarDetails.Rows[e.RowIndex].Cells[4].Value.ToString());
            comboBoxFuelType.Text = Convert.ToString(dataGridViewCarDetails.Rows[e.RowIndex].Cells[5].Value.ToString());
            txtMilage.Text = dataGridViewCarDetails.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboBoxTransmission.Text = Convert.ToString(dataGridViewCarDetails.Rows[e.RowIndex].Cells[7].Value.ToString());
            txtEngineCapacity.Text = dataGridViewCarDetails.Rows[e.RowIndex].Cells[8].Value.ToString();
            comboBoxTrimType.Text = Convert.ToString(dataGridViewCarDetails.Rows[e.RowIndex].Cells[9].Value.ToString());
            txtNoOfSeats.Text = dataGridViewCarDetails.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtItemCode.Text = dataGridViewCarDetails.Rows[e.RowIndex].Cells[11].Value.ToString();

            //retrive inventory details matching for the selected car
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

            tbl_car car = new tbl_car();
            car.CarBrand = Convert.ToString(comboBoxCarBrand.Text);
            car.CarModel = Convert.ToString(comboBoxCarModel.Text);
            car.YOM = Convert.ToDateTime(dateTimePickerYOM.Value);
            car.FuelType = Convert.ToString(comboBoxFuelType.Text);
            car.Milage = Convert.ToInt32(txtMilage.Text);
            car.Transmission = Convert.ToString(comboBoxTransmission.Text);
            car.EngineCapacity = txtEngineCapacity.Text;
            car.TrimType = Convert.ToString(comboBoxTrimType.Text);
            car.SeatCount = Convert.ToInt32(txtNoOfSeats.Text);
            car.ItemCode = txtItemCode.Text;
            car.Condition = Convert.ToString(comboBoxCondition.Text);
            CarDetailsBLL.AddCarDetails(car);
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

            tbl_car car = new tbl_car();
            car = CarDetailsBLL.MatchCar(Car_id);
            car.CarBrand = Convert.ToString(comboBoxCarBrand.Text);
            car.CarModel = Convert.ToString(comboBoxCarModel.Text);
            car.YOM = Convert.ToDateTime(dateTimePickerYOM.Value);
            car.FuelType = Convert.ToString(comboBoxFuelType.Text);
            car.Milage = Convert.ToInt32(txtMilage.Text);
            car.Transmission = Convert.ToString(comboBoxTransmission.Text);
            car.EngineCapacity = txtEngineCapacity.Text;
            car.TrimType = Convert.ToString(comboBoxTrimType.Text);
            car.SeatCount = Convert.ToInt32(txtNoOfSeats.Text);
            car.Condition = Convert.ToString(comboBoxCondition.Text);
            CarDetailsBLL.UpdateCarDetails(car);
            DisplayDataonLoad();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult DeleteConfirmation = MessageBox.Show("Confirm Delete Request", "Confirm Delete", MessageBoxButtons.OKCancel);
            if (DeleteConfirmation == DialogResult.OK)
            {
                tbl_car car = new tbl_car();
                car = CarDetailsBLL.MatchCar(Car_id);
                CarDetailsBLL.DeleteCarDetails(car);

                tbl_inventory item = new tbl_inventory();
                item = InventoryBLL.MatchItem(item_code);
                InventoryBLL.DeleteItem(item);


                DisplayDataonLoad();
                Clear();
                MessageBox.Show("Delete Success!", "Deleted", MessageBoxButtons.OK);
            }
        }

        void Clear()
        {
            comboBoxCarBrand.SelectedIndex = -1;
            comboBoxCarModel.SelectedIndex = -1;
            dateTimePickerYOM.ResetText();
            comboBoxCondition.SelectedIndex = -1;
            comboBoxFuelType.SelectedIndex = -1;
            txtMilage.Clear();
            comboBoxTransmission.SelectedIndex = -1;
            txtEngineCapacity.Clear();
            comboBoxTrimType.SelectedIndex = -1;
            txtNoOfSeats.Clear();
            txtItemCode.Clear();

            txtQTY.Clear();
            txtPrice.Clear();
            dateTimePickerDateAdded.ResetText();
        }

      


     
        private void comboBoxCarBrand_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxCarBrand.SelectedIndex != -1)
            {
                comboBoxCarModel.DataSource = carDetailsDTO.CarModels.Where(x => x.CarBrand_ID ==
                Convert.ToInt32(comboBoxCarBrand.SelectedValue)).ToList();
                // Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();
                //int carbrand_id = Convert.ToInt32(comboBoxCarBrand.ValueMember);
                // comboBoxCarModel.DataSource = CarDetailsDTO.CarModels.Where(x => x.CarBrand_ID== carbrand_id).ToList();

            }
           
        }
    }
}
