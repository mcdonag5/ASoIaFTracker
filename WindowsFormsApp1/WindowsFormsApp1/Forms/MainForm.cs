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

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {

        /// <sumary>
        /// NOTES
        /// 
        /// </summary>


        ///// VARIABLES START //////////////////////////////////////////////////////
        DevLog DevLog = new DevLog();
        House House = new House();
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////
        public void ViewHouse()
        {
            DevLog.LogItem("datagrid double clicked");
            HouseViewForm houseForm = new HouseViewForm(GetSelectedHouseID());
            houseForm.FormClosing += new FormClosingEventHandler(this.Form1_Load);
            houseForm.ShowDialog();
        }

        public int GetSelectedHouseID()
        {
            int x;
            int row = Convert.ToInt32(dgHouseDetails.SelectedCells[0].RowIndex);
            if (dgHouseDetails.Columns[0].Name == "ID")
            {
                x = (Convert.ToInt32(dgHouseDetails.Rows[row].Cells[0].Value));
            }
            else
            {
                x = (Convert.ToInt32(dgHouseDetails.Rows[row].Cells[1].Value));
            }
            return x;
        }
        ///// METHODS END //////////////////////////////////////////////////////////

        public FormMain()
        {
            InitializeComponent();
            File.WriteAllText("DevLog.txt", String.Empty);//Clear contents of DevLog
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DevLog.LogItem("Program started");
            dgHouseDetails.DataSource = House.HouseTableQry();
        }
        ///// EVENTS START //////////////////////////////////////////////////////////

        private void DgHouseDetails_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ViewHouse();
        }

        private void PlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("Player tool strip item clicked");
            dgHouseDetails.DataSource = House.HouseTableQry("Hou_Player", (sender as ToolStripMenuItem).Text);
        }

        private void TsbCreateHouse_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("Create house button clicked");
            CreateHouseForm createHouseForm = new CreateHouseForm();
            createHouseForm.ShowDialog();
        }

        private void TsbAllHouses_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("All houses button clicked");
            dgHouseDetails.DataSource = House.HouseTableQry();
        }

        private void TsbseeTestHouses_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("See test house button pressed");
            dgHouseDetails.DataSource = House.HouseTableQry("Hou_Player", "Test");
        }

        private void TsbMenuDevLog_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("Devlog tool strip item clicked");
            DevLog.OpenLog();
        }

        private void TsbViewHouse_Click(object sender, EventArgs e)
        {
            ViewHouse();
        }

        private void TsbDeleteHouse_Click(object sender, EventArgs e)
        {
            int x = GetSelectedHouseID();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete House "+ dgHouseDetails.Rows[Convert.ToInt32(dgHouseDetails.SelectedCells[0].RowIndex)].Cells[1].Value + ". ID: "+x+".", "Delete House", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
