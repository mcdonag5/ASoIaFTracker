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
    public partial class BannersHoldingsForm : Form
    {
        ///// VARIABLES START //////////////////////////////////////////////////////
        DevLog DevLog = new DevLog();
        House House;
        //Forms
        NewBannerForm NewBannerForm;

        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////
        public void ViewHouse()
        {
            DevLog.LogItem("datagrid double clicked");
            HouseViewForm houseForm = new HouseViewForm(Convert.ToInt32(dgBanners.Rows[Convert.ToInt32(dgBanners.SelectedCells[0].RowIndex)].Cells[0].Value));
            houseForm.Show();
        }
        ///// METHODS END //////////////////////////////////////////////////////////
        public BannersHoldingsForm(int houseID, string houseName)
        {
            House = new House(houseID,houseName);
            InitializeComponent();
            Text = House.name + " Banners";
            
        }

        private void BannersHoldings_Load(object sender, EventArgs e)
        {
            dgBanners.DataSource = House.HouseQry("ViewBanner");
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void tsbNewBanner_Click(object sender, EventArgs e)
        {
            NewBannerForm = new NewBannerForm(House.ID,House.name);
            NewBannerForm.FormClosing += new FormClosingEventHandler(BannersHoldings_Load);
            NewBannerForm.ShowDialog();
        }

        private void tsbDeleteBanner_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(dgBanners.Rows[Convert.ToInt32(dgBanners.SelectedCells[0].RowIndex)].Cells[0].Value);
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove House " + dgBanners.Rows[Convert.ToInt32(dgBanners.SelectedCells[0].RowIndex)].Cells[1].Value + " as your banner. ID: " + x + ".", "Remove Banner", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                House.DeleteBanner(x);
                dgBanners.DataSource = House.HouseQry("ViewBanner");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void tsbViewBanner_Click(object sender, EventArgs e)
        {
            ViewHouse();
        }

        private void dgBanners_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ViewHouse();
        }

        private void BannersHoldings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NewBannerForm != null) { NewBannerForm.Close(); }
        }

        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
