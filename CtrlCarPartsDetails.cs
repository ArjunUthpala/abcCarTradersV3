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


namespace abcCarTradersV1
{
    public partial class CtrlCarPartsDetails : UserControl
    {
        int Part_id;
        string item_code;
        public CtrlCarPartsDetails()
        {
            InitializeComponent();
        }

        private void CtrlCarPartsDetails_Load(object sender, EventArgs e)
        {
            DisplayDataonLoad();
            dataGridViewCarPartsDetails.Columns[0].Visible = false;

            //load Car brands to combo box
            List<tbl_car_brand> CarBrands = new List<tbl_car_brand>();
            CarBrands = CarBrandsBLL.GetCarBrands();
            comboBoxCarBrand.DataSource = CarBrands;
            comboBoxCarBrand.DisplayMember = "CarBrand";
            comboBoxCarBrand.ValueMember = "CarBrand_ID";
            comboBoxCarBrand.SelectedIndex = -1;

            //load Car brands to combo box
            List<tbl_car_part_brand> CarModels = new List<tbl_car_part_brand>();
         
            comboBoxCarBrand.DataSource = CarBrands;
            comboBoxCarBrand.DisplayMember = "CarBrand";
            comboBoxCarBrand.ValueMember = "CarBrand_ID";
            comboBoxCarBrand.SelectedIndex = -1; 
        }

        void Clear()
        {
            comboBoxPartName.SelectedIndex = -1;
            txtPartBrand.Clear();
            comboBoxCarBrand.SelectedIndex = -1;
            txtCarmodel.Clear();
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
        }
    }
}
