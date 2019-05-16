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
    public partial class NewBannerForm : Form
    {
        ///// VARIABLES START //////////////////////////////////////////////////////
        DevLog DevLog = new DevLog();
        House House;
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////
        public NewBannerForm(int houseID, string houseName)
        {
            House = new House(houseID, houseName);

            InitializeComponent();

            Text = House.name + " New Banner";
        }

        private void NewBannerForm_Load(object sender, EventArgs e)
        {
            dgBanners.DataSource = House.HouseQry("Banner");
            if(dgBanners.RowCount == 0) { lbCost.Text = "20"; }
            else if (dgBanners.RowCount == 1) { lbCost.Text = "10"; }
            else { lbCost.Text = "5"; }

            dgHouse.DataSource = House.HouseQry("OtherHouse");
            object[] land = new object[dgHouse.RowCount];
            string prefix;
            for (int i = 0; i < dgHouse.RowCount; i++)
            {
                switch (dgHouse.Rows[i].Cells[3].Value.ToString())
                {
                    case "The Wall":
                        prefix = "";
                        break;
                    default:
                        prefix = "House ";
                        break;
                }
                land[i] = prefix + dgHouse.Rows[i].Cells[1].Value.ToString() ;
            }
            cbHouse.Items.Clear();
            cbHouse.Items.AddRange(land);
            cbHouse.SelectedIndex = 0;
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void tbHouLanView_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(dgHouse.Rows[cbHouse.SelectedIndex].Cells[0].Value);
            bool noDuplicate = true;
            for (int i = 0; i<dgBanners.RowCount && noDuplicate;i++)
            {
                if (x == Convert.ToInt32(dgBanners.Rows[i].Cells[1].Value))
                {
                    noDuplicate = false;
                    MessageBox.Show("House "+ dgBanners.Rows[i].Cells[2].Value.ToString() + " is already your banner.");
                }
            }
            if(noDuplicate)
            {
                House.InsertBanners(x);
                Close();
            }

        }
        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
