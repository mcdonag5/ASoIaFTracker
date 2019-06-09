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
    public partial class InfluenceHoldingForm : Form
    {

        ///// VARIABLES START //////////////////////////////////////////////////////
        int currentIndex;
        Label[] improvmentName;
        Label[] improvmentDesc;
        //Classes
        DevLog DevLog = new DevLog();
        House House;
        //Forms

        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////

        ///// METHODS END //////////////////////////////////////////////////////////
        public InfluenceHoldingForm(int houseID, string houseName)
        {
            House = new House(houseID, houseName);

            InitializeComponent();

            Name = House.name + " Influence Holdings";
            improvmentName = new Label[] { lbName1, lbName2 };
            improvmentDesc = new Label[] { lbDesc1, lbDesc2 };
        }

        private void InfluenceHoldingForm_Load(object sender, EventArgs e)
        {
            if (Visible == false) { Visible = true; }
            DevLog.LogItem("Getting Heir details");
            dgInfluence.DataSource = House.HouseQry("InfluenceHoldings");
            if (dgInfluence.RowCount > 0)
            {
                object[] influence = new object[dgInfluence.RowCount];
                for (int i = 0; i < dgInfluence.RowCount; i++)
                {
                    influence[i] = dgInfluence.Rows[i].Cells[10].Value.ToString()+"-"+ dgInfluence.Rows[i].Cells[4].Value.ToString();
                }
                cbInfluence.Items.Clear();
                cbInfluence.Items.AddRange(influence);
                cbInfluence.SelectedIndex = 0;
            }

        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void cbInfluence_SelectedIndexChanged(object sender, EventArgs e)
        {


            currentIndex = cbInfluence.SelectedIndex;

            lbTypeName.Text = dgInfluence.Rows[currentIndex].Cells[10].Value.ToString();
            int cost = Convert.ToInt32(dgInfluence.Rows[currentIndex].Cells[11].Value) - Convert.ToInt32(dgInfluence.Rows[currentIndex].Cells[7].Value);
            tbName.Text = dgInfluence.Rows[currentIndex].Cells[4].Value.ToString();
            lbDesc.Text = dgInfluence.Rows[currentIndex].Cells[12].Value.ToString();
            lbBenfits.Text = Environment.NewLine + "Benfit: " + dgInfluence.Rows[currentIndex].Cells[13].Value.ToString();
            dgInfluenceImprovemnt.DataSource = House.HouseQry("InfluenceHolding", dgInfluence.Rows[currentIndex].Cells[1].Value.ToString());

            for (int i = 0; i < improvmentName.Length; i++)
            {
                if (i < dgInfluenceImprovemnt.RowCount)
                {
                    improvmentName[i].Visible = improvmentDesc[i].Visible = true;
                    improvmentName[i].Text = dgInfluenceImprovemnt.Rows[i].Cells[7].Value.ToString();
                    improvmentDesc[i].Text = dgInfluenceImprovemnt.Rows[i].Cells[9].Value.ToString() + Environment.NewLine + "Benfit: " + dgInfluenceImprovemnt.Rows[i].Cells[10].Value.ToString();
                    cost += Convert.ToInt32(dgInfluenceImprovemnt.Rows[i].Cells[8].Value) - Convert.ToInt32(dgInfluenceImprovemnt.Rows[i].Cells[4].Value);
                }
                else
                {
                    improvmentName[i].Visible = improvmentDesc[i].Visible = false;
                }
            }

            lbCost.Text = "Cost: " + cost + " Influence";
        }
        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
