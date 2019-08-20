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
    public partial class NewInfluenceImprovementForm : Form
    {
        ///// VARIABLES START ///////////////////////////////////////////////////////
        string holdingID;
        string influenceID;
        //Classes
        DevLog DevLog = new DevLog();
        House House;
        Validation Validation = new Validation();
        ///// VARIABLES END /////////////////////////////////////////////////////////

        ///// METHODS START /////////////////////////////////////////////////////////

        ///// METHODS END ///////////////////////////////////////////////////////////
        public NewInfluenceImprovementForm(int houseID, string houseName, string infHoldingID, string infID, string holdinghName)
        {
            House = new House(houseID, houseName);
            holdingID = infHoldingID;
            influenceID = infID;

            InitializeComponent();

            Text = House.name + " New Influence Improvement";
            lbName.Text = holdinghName;

            dgImprovement.DataSource = House.HouseQry("ImprovementImprovement", influenceID);
            if(dgImprovement.RowCount>0)
            {
                object[] improvement = new object[dgImprovement.RowCount];
                string item;
                for (int i = 0; i < dgImprovement.RowCount; i++)
                {
                    item = dgImprovement.Rows[i].Cells[2].Value.ToString() + " - Inf: " + dgImprovement.Rows[i].Cells[3].Value.ToString();
                    improvement[i] = item;
                }
                cbInfluence.Items.Clear();
                cbInfluence.Items.AddRange(improvement);
                cbInfluence.SelectedIndex = 0;
            }
            else
            {
                btBuy.Enabled = false;
            }
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void CbInfluence_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDescription.Text = dgImprovement.Rows[cbInfluence.SelectedIndex].Cells[4].Value.ToString() + Environment.NewLine;
            lbBenefits.Text = "Benfits: " + dgImprovement.Rows[cbInfluence.SelectedIndex].Cells[5].Value.ToString();
            TbDiscount_TextChanged(sender, e);
        }

        private void TbDiscount_TextChanged(object sender, EventArgs e)
        {
            int cost = Convert.ToInt32(dgImprovement.Rows[cbInfluence.SelectedIndex].Cells[3].Value.ToString());
            if (tbDiscount.Text != "") { cost -= Convert.ToInt32(tbDiscount.Text); }
            lbCost.Text = cost.ToString();
        }

        private void BtBuy_Click(object sender, EventArgs e)
        {
            Validation.SetNullTo(tbDiscount, "0");
            House.InsertInfluenceImprovementHolding(dgImprovement.Rows[cbInfluence.SelectedIndex].Cells[0].Value.ToString(),holdingID,tbDiscount.Text);
            Close();
        }
        //Validation
        private void TbDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyDigit(e);
        }





        ///// EVENTS END ////////////////////////////////////////////////////////////

    }
}
