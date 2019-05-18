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
    public partial class HeirForm : Form
    {
        ///// VARIABLES START //////////////////////////////////////////////////////
        int[] costs;
        public int currentIndex = -1;
        public bool dorne;
        int nextMaleCost = 20;
        int nextFemaleCost = 10;
        //classes
        DevLog DevLog = new DevLog();
        Validation Validation = new Validation();
        House House;
        //Form
        NewHeirForm NewHeirForm;
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////
        public void SaveIfChange()
        {
            DevLog.LogItem("Check if changed");
            if(tbName.Text != dgHeir.Rows[currentIndex].Cells[2].Value.ToString() || rtbNotes.Text != dgHeir.Rows[currentIndex].Cells[4].Value.ToString())
            {
                DevLog.LogItem("Found change: updating");
                House.UpdateHeir(dgHeir.Rows[currentIndex].Cells[0].Value.ToString(), tbName.Text, rtbNotes.Text);
                dgHeir.DataSource = House.HouseQry("Heir");
                cbHeir.Items[currentIndex] = dgHeir.Rows[currentIndex].Cells[2].Value.ToString();
                Visible = true;
            }
        }
        ///// METHODS END //////////////////////////////////////////////////////////
        public HeirForm(int houseID, string houseName, string realm)
        {
            DevLog.LogItem("Opened Heir Form");
            House = new House(houseID, houseName);

            InitializeComponent();

            dorne = realm == "Dorne" ? true : false;
            Text = House.name + " Heirs";
        }

        private void HeirForm_Load(object sender, EventArgs e)
        {
            if (Visible == false) { Visible = true; }
            DevLog.LogItem("Getting Heir details");
            dgHeir.DataSource = House.HouseQry("Heir");
            if (dgHeir.RowCount > 0)
            {
                object[] heirs = new object[dgHeir.RowCount];
                costs = new int[dgHeir.RowCount];
                int male = 0;
                int female = 0;
                for (int i = 0; i < dgHeir.RowCount; i++)
                {
                    heirs[i] = dgHeir.Rows[i].Cells[2].Value.ToString();
                    if (dgHeir.Rows[i].Cells[3].Value.ToString() == "M" || dorne)
                    {
                        male++;
                        switch (male)
                        {
                            case 1:
                                costs[i] = 20;
                                nextMaleCost = 10;
                                break;
                            case 2:
                                costs[i] = 10;
                                nextMaleCost = 5;
                                break;
                            default:
                                costs[i] = 5;
                                break;
                        }
                    }
                    else
                    {
                        female++;
                        switch (female)
                        {
                            case 1:
                                costs[i] = 10;
                                nextFemaleCost = 5;
                                break;
                            default:
                                costs[i] = 5;
                                break;
                        }
                    }
                }
                cbHeir.Items.Clear();
                cbHeir.Items.AddRange(heirs);
                cbHeir.SelectedIndex = 0;
            }
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void CbHeir_SelectedIndexChanged(object sender, EventArgs e)
        {
            DevLog.LogItem("Combo Heir changed to index:" + cbHeir.SelectedIndex + " text: " + cbHeir.SelectedText);
            if(currentIndex != -1) {
                SaveIfChange();
            }

            currentIndex = cbHeir.SelectedIndex;

            string gender = dgHeir.Rows[currentIndex].Cells[3].Value.ToString() == "M" ? "Male" : "Female";
            lbTypeName.Text = gender + " Heir";
            lbCost.Text = "Cost: " + costs[currentIndex] + " Influence";
            tbName.Text = dgHeir.Rows[currentIndex].Cells[2].Value.ToString();
            rtbNotes.Text = dgHeir.Rows[currentIndex].Cells[4].Value.ToString();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("New tool strip button clicked");
            NewHeirForm = new NewHeirForm(House.ID, House.name,nextMaleCost,nextFemaleCost);
            NewHeirForm.FormClosing += new FormClosingEventHandler(HeirForm_Load);
            Visible = false;
            NewHeirForm.Show();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("Delete tool strip button clicked");
            int x = Convert.ToInt32(dgHeir.Rows[currentIndex].Cells[0].Value);
            DevLog.LogItem("Show yes no messagebox");
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove " + dgHeir.Rows[currentIndex].Cells[2].Value.ToString() + ". ID: " + x + ".", "Delete Heir", MessageBoxButtons.YesNo);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    cbHeir.SelectedIndex = -1;
                    DevLog.LogItem("Clicked yes on messagebox");
                    House.DeleteHeir(x);
                    HeirForm_Load(sender, e);
                    Visible = true;
                    break;
                case DialogResult.No:
                    DevLog.LogItem("Clicked no on messagebox");
                    break;
            }
        }

        private void HeirForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DevLog.LogItem("Form Heir form closing");
            if(NewHeirForm != null) { NewHeirForm.Close(); }
            if (cbHeir.SelectedIndex != -1) { SaveIfChange(); }
        }


        ///// EVENTS END ////////////////////////////////////////////////////////////

    }
}
