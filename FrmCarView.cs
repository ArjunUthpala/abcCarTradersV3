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
    public partial class FrmCarView : Form
    {
        string imgPath = "";
        public FrmCarView()
        {
            InitializeComponent();
        }

        public static string itemcode { get; set; }
        private void FrmCarView_Load(object sender, EventArgs e)
        {
            tbl_car car = new tbl_car();
            car = CarDetailsBLL.GetOrderedCar(itemcode);
            comboBoxCarBrand.Text = car.CarBrand;
            txtEngineCapacity.Text = car.EngineCapacity;
            txtItemCode.Text = car.ItemCode;
            comboBoxCarModel.Text = car.CarModel;
            txtYOM.Text = Convert.ToString(car.YOM);
            txtMilage.Text = Convert.ToString(car.Milage);
            comboBoxFuelType.Text = car.FuelType;
            comboBoxCondition.Text = car.Condition;
            comboBoxTransmission.Text = car.Transmission;
            comboBoxTrimType.Text = car.TrimType;
            txtNoOfSeats.Text = Convert.ToString(car.SeatCount);

            imgPath = Application.StartupPath + "\\images\\" + car.ImagePath;
            pictureBoxCar.ImageLocation = imgPath;
        }
    }
}
