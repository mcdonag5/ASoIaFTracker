using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        ///// VARIABLES START //////////////////////////////////////////////////////
        DevLog DevLog = new DevLog();
        House House = new House();
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////
        public void ViewHouse()
        {
            DevLog.LogItem("Opening House View Form for: " + GetSelectedHouseID());
            HouseViewForm houseForm = new HouseViewForm(GetSelectedHouseID());
            houseForm.FormClosing += new FormClosingEventHandler(this.Form1_Load);
            houseForm.Show();
        }

        public int GetSelectedHouseID()
        {
            int row = Convert.ToInt32(dgHouseDetails.SelectedCells[0].RowIndex);
            return (Convert.ToInt32(dgHouseDetails.Rows[row].Cells[0].Value));
        }
        ///// METHODS END //////////////////////////////////////////////////////////

        public FormMain()
        {
            InitializeComponent();
            File.WriteAllText("DevLog.txt", String.Empty);//Clear contents of DevLog
            DevLog.LogItem("Program started");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgHouseDetails.DataSource = House.HouseTableQry();
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        //Datagrid
        private void DgHouseDetails_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DevLog.LogItem("Double clicked on the datagrid");
            ViewHouse();
        }
        //Tool strip
        //Menu drop down start
        private void TsbMenuDevLog_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("Devlog tool strip item clicked");
            DevLog.OpenLog();
        }

        private void TsbseeTestHouses_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("See test house button pressed");
            dgHouseDetails.DataSource = House.HouseTableQry("Hou_Player", "Test");
        }

        private void GetQryNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("Qry Helper tool strip clicked");
            QryHelperForm qryHelper = new QryHelperForm();
            qryHelper.Show();
        }
        //Menu drop down end
        private void TsbAllHouses_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("All houses button clicked");
            dgHouseDetails.DataSource = House.HouseTableQry();
        }
        //Player drop down
        private void PlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("Player tool strip item clicked for " + (sender as ToolStripMenuItem).Text);
            dgHouseDetails.DataSource = House.HouseTableQry("Hou_Player", (sender as ToolStripMenuItem).Text);
        }

        private void TsbCreateHouse_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("Create house button clicked");
            CreateHouseForm createHouseForm = new CreateHouseForm();
            createHouseForm.ShowDialog();
        }

        private void TsbViewHouse_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("View house tool strip clicked");
            ViewHouse();
        }

        private void TsbDeleteHouse_Click(object sender, EventArgs e)
        {//Not currently used
            DevLog.LogItem("Delete House tool strip clicked");
            int x = GetSelectedHouseID();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete House " + dgHouseDetails.Rows[Convert.ToInt32(dgHouseDetails.SelectedCells[0].RowIndex)].Cells[1].Value + ". ID: " + x + ".", "Delete House", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        //Create New Holding start
        private void WealthHoldingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("Create new wealth holding tool strip clicked");
            CreateNewWealthHolding createNewWealthHolding = new CreateNewWealthHolding("Wealth");
            createNewWealthHolding.ShowDialog();
        }

        private void WealthImprovemntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("Create new wealth holding tool strip clicked");
            CreateNewWealthHolding createNewWealthHolding = new CreateNewWealthHolding("Wealth Improvement");
            createNewWealthHolding.ShowDialog();
        }
        //Create New Holding end

        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
