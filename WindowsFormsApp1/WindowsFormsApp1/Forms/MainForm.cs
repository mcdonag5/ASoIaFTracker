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
        string user = "";
        //Classes
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
            if (user != "")
            {
                dgHouseDetails.DataSource = House.HouseTableQry("Hou_Player", user);
                tsmChangePassword.Enabled = tsmmLogout.Enabled = tsbCreateHouse.Enabled = tsbViewHouse.Enabled = tsbViewHoldings.Enabled = tsbCreateNewHolding.Enabled = true;
                panLogIn.Visible = false;

                switch (user)
                {
                    case "Chris":
                        dgHouseDetails.DataSource = House.HouseTableQry();
                        break;
                    case "Ross":
                        tsmQryHelper.Enabled = true;
                        break;
                    case "Test":
                        tsmQryHelper.Enabled = true;
                        break;
                }
            }
            else
            {
                dgHouseDetails.DataSource = null;
                tsmChangePassword.Enabled = tsmmLogout.Enabled = tsbCreateHouse.Enabled = tsbViewHouse.Enabled = tsbViewHoldings.Enabled = tsbCreateNewHolding.Enabled = tsmQryHelper.Enabled = false;
                panLogIn.Visible = true;
            }
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        //logIn
        private void BtLogIn_Click(object sender, EventArgs e)
        {
            if(House.LogIn(tbUsername.Text,tbPassword.Text))
            {
                user = tbUsername.Text;
                tbUsername.Text = tbPassword.Text = "";
                panLogIn.Visible = false;
                Form1_Load(sender, e);
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { BtLogIn_Click(sender, e); }
        }

        private void TsmmLogout_Click(object sender, EventArgs e)
        {
            user = "";
            Form1_Load(sender, e);
        }

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
            DevLog.LogItem("Create new Wealth holding tool strip clicked");
            CreateNewWealthHolding createNewWealthHolding = new CreateNewWealthHolding("Wealth");
            createNewWealthHolding.ShowDialog();
        }

        private void WealthImprovemntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("Create new Wealth Improvement holding tool strip clicked");
            CreateNewWealthHolding createNewWealthHolding = new CreateNewWealthHolding("Wealth Improvement");
            createNewWealthHolding.ShowDialog();
        }

        private void InflunceHoldingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("Create new Influence holding tool strip clicked");
            CreateNewWealthHolding createNewWealthHolding = new CreateNewWealthHolding("Influence");
            createNewWealthHolding.ShowDialog();
        }

        private void InflunceImprovemntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("Create new influnce Improvement holding tool strip clicked");
            CreateNewWealthHolding createNewWealthHolding = new CreateNewWealthHolding("Influence Improvement");
            createNewWealthHolding.ShowDialog();
        }

        private void DefenseHoldingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("Create new influnce Improvement holding tool strip clicked");
            CreateNewWealthHolding createNewWealthHolding = new CreateNewWealthHolding("Defense");
            createNewWealthHolding.ShowDialog();
        }

        private void UnitTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("Create new influnce Improvement holding tool strip clicked");
            CreateNewWealthHolding createNewWealthHolding = new CreateNewWealthHolding("Unit Type");
            createNewWealthHolding.ShowDialog();
        }

        private void TsbViewHoldings_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("Create new influnce Improvement holding tool strip clicked");
            ViewHoldings viewHoldings = new ViewHoldings();
            viewHoldings.Show();
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("Change password holding tool strip clicked");
            changePassForm changePassForm = new changePassForm(user);
            changePassForm.ShowDialog();
        }

        


        //Create New Holding end

        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
