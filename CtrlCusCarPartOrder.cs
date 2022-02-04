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
    public partial class CtrlCusCarPartOrder : UserControl
    {
        int Carpart_id;
        string item_code;
        string customer_NIC = Convert.ToString(UserStatic.NICNum);
        public CtrlCusCarPartOrder()
        {
            InitializeComponent();
        }

        private void CtrlCusCarPartOrder_Load(object sender, EventArgs e)
        {
            DisplayDataonLoad();
        }

        void DisplayDataonLoad()
        {
            List<tbl_car_part> CarPartDetails = new List<tbl_car_part>();
            CarPartDetails = CarPartsDetailsBLL.GetCarPartsDetails();
            dataGridViewCarPartsDetails.DataSource = CarPartDetails;
            dataGridViewCarPartsDetails.AutoGenerateColumns = false;
            dataGridViewCarPartsDetails.DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
            dataGridViewCarPartsDetails.ColumnHeadersDefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            this.dataGridViewCarPartsDetails.Columns["tbl_inventory"].Visible = false;


        }

        private void dataGridViewCarPartsDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //assiging values from data grid to the relavant input fields
            Carpart_id = Convert.ToInt32(dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtPartName.Text = dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPartBrand.Text = Convert.ToString(dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[2].Value.ToString());     
            txtCarModel.Text = Convert.ToString(dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[4].Value.ToString());
            txtItemCode.Text = dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[7].Value.ToString();

            item_code = txtItemCode.Text;
            tbl_inventory item = new tbl_inventory();
            item = InventoryBLL.GetOneItem(item_code);
            txtQTY.Text = Convert.ToString(item.QTY);
            txtPrice.Text = Convert.ToString(item.Price);
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int orderQTY = Convert.ToInt32(numericUpDown.Value);
            int unitPrice = Convert.ToInt32(txtPrice.Text);
            int TotAmount = (orderQTY * unitPrice);
            txtTotalAmt.Text = Convert.ToString(TotAmount);
        }
    }
}
