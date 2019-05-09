using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Forms
{
    public partial class NewLandForm : Form
    {
        ///// VARIABLES START ////////////////////////////////////////////////////// 
        DbConn mysqlConn = new DbConn();
        DevLog DevLog = new DevLog();
        Validation Validation = new Validation();
        House House;
        public int houseID;


        public NewLandForm(int ID)
        {
            DevLog.LogItem("ID: " + ID);
            House = new House(ID);
            InitializeComponent();
        }

        private void NewLandForm_Load(object sender, EventArgs e)
        {
            dgLand.DataSource = House.HouseQry("Land");
            object[] land = new object[dgLand.RowCount - 1];
            for (int i = 0; i < dgLand.RowCount - 1; i++)
            {
                land[i] = dgLand.Rows[i].Cells[1].Value.ToString() + " - Land: " + dgLand.Rows[i].Cells[2].Value.ToString();
            }
            cbLand.Items.Clear();
            cbLand.Items.AddRange(land);
            cbLand.SelectedIndex = 0;
        }

        private void CbLand_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCost.Text = Convert.ToString(Convert.ToInt32(dgLand.Rows[cbLand.SelectedIndex].Cells[2].Value) - Convert.ToInt32(tbDiscount.Text));
        }

        private void TbDiscount_TextChanged(object sender, EventArgs e)
        {
            lbCost.Text = Convert.ToString(Convert.ToInt32(dgLand.Rows[cbLand.SelectedIndex].Cells[2].Value) - Convert.ToInt32(tbDiscount.Text));
        }

        private void BtBuy_Click(object sender, EventArgs e)
        {
            Validation.SetNullToZero(tbDiscount);
            House.InsertLandHolding(dgLand.Rows[cbLand.SelectedIndex].Cells[0].Value.ToString(), tbName.Text, rtbNote.Text, tbDiscount.Text);
            Close();
        }

        //Validation
        private void TbDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyDigit(e);
        }
    }
}
