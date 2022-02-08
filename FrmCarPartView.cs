using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class FrmCarPartView : Form
    {
        string imgPath = "";
        public FrmCarPartView()
        {
            InitializeComponent();
        }

        public static string itemcode { get; set; }
        private void FrmCarPartView_Load(object sender, EventArgs e)
        {
            tbl_car_part part = new tbl_car_part();
            part = CarPartsDetailsBLL.GetOrderedCarPart(itemcode);
            comboBoxCarBrand.Text = part.CarBrand;
            txtItemCode.Text = part.ItemCode;
            comboBoxCarModel.Text = part.CarModel;
            comboBoxPartBrand.Text = part.PartBrandName;
            txtPartName.Text = part.CarPartName;
            dateTimePickerYOM.Value = Convert.ToDateTime(part.YOM);
            comboBoxCondition.Text = part.Condition;

            imgPath = Application.StartupPath + "\\images\\" + part.ImagePath;
            pictureBoxCarPart.ImageLocation = imgPath;
        }
    }
}
