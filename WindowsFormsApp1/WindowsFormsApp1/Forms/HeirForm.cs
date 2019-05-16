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
        //classes
        DevLog DevLog = new DevLog();
        Validation Validation = new Validation();
        House House;

        int[] costs;
        public int currentIndex = -1;
        public bool dorne;
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////
        public void SaveIfChange()
        {
            if(tbName.Text != dgHeir.Rows[currentIndex].Cells[2].Value.ToString() || rtbNotes.Text != dgHeir.Rows[currentIndex].Cells[4].Value.ToString())
            {
                House.UpdateHeir(dgHeir.Rows[currentIndex].Cells[2].Value.ToString(), tbName.Text, rtbNotes.Text);
            }
        }
        ///// METHODS END //////////////////////////////////////////////////////////
        public HeirForm(int houseID, string houseName, string realm)
        {
            House = new House(houseID, houseName);

            InitializeComponent();

            dorne = realm == "Dorne" ? true : false;
            Text = House.name + " Heirs";
        }

        private void HeirForm_Load(object sender, EventArgs e)
        {

            dgHeir.DataSource = House.HouseQry("Heir");
            object[] heirs = new object[dgHeir.RowCount];
            costs = new int[dgHeir.RowCount];
            int male = 0;
            int female = 0;
            for (int i = 0; i < dgHeir.RowCount; i++)
            {
                heirs[i] = dgHeir.Rows[i].Cells[2].Value.ToString();
                if(dgHeir.Rows[i].Cells[3].Value.ToString() == "M" || dorne)
                {
                    male++;
                    switch (male)
                    {
                        case 1:
                            costs[i] = 20;
                            break;
                        case 2:
                            costs[i] = 10;
                            break;
                        default:
                            costs[i] = 5;
                            break;
                    }
                }
                else
                {
                    female++;
                    costs[i] = female == 1 ? 10 : 5;
                }
            }
            cbHeir.Items.Clear();
            cbHeir.Items.AddRange(heirs);
            cbHeir.SelectedIndex = 0;
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void CbHeir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(currentIndex != -1) {
                SaveIfChange();
                dgHeir.DataSource = House.HouseQry("Heir");
                object[] heirs = new object[dgHeir.RowCount];
                for (int i = 0; i < dgHeir.RowCount; i++)
                {
                    heirs[i] = dgHeir.Rows[i].Cells[2].Value.ToString();
                }
                cbHeir.Items.Clear();
                cbHeir.Items.AddRange(heirs);
                cbHeir.SelectedIndex = 0;
            }

            currentIndex = cbHeir.SelectedIndex;

            string gender = dgHeir.Rows[currentIndex].Cells[3].Value.ToString() == "M" ? "Male" : "Female";
            lbTypeName.Text = gender + " Heir";
            lbCost.Text = "Cost: " + costs[currentIndex] + " Influence";
            tbName.Text = dgHeir.Rows[currentIndex].Cells[2].Value.ToString();
            rtbNotes.Text = dgHeir.Rows[currentIndex].Cells[4].Value.ToString();
        }

        private void HeirForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            House.UpdateHeir(dgHeir.Rows[currentIndex].Cells[2].Value.ToString(), tbName.Text, rtbNotes.Text); 
        }
        ///// EVENTS END ////////////////////////////////////////////////////////////

    }
}
