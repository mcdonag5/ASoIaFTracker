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
    public partial class NewDefenseForm : Form
    {
        ///// VARIABLES START //////////////////////////////////////////////////////
        DevLog DevLog = new DevLog();
        Validation Validation = new Validation();
        House House;
        string landID;
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////

        ///// METHODS END //////////////////////////////////////////////////////////
        public NewDefenseForm(int ID, int holdingID, string landName)
        {
            House = new House(ID);
            landID = holdingID.ToString();
            InitializeComponent();

            lbName.Text = landName;

            dgDefense.DataSource = House.HouseQry("Defense");
            object[] defense = new object[dgDefense.RowCount];
            for (int i = 0; i < dgDefense.RowCount; i++)
            {
                defense[i] = dgDefense.Rows[i].Cells[1].Value.ToString() + " - Def: " + dgDefense.Rows[i].Cells[2].Value.ToString();
            }
            cbDefense.Items.Clear();
            cbDefense.Items.AddRange(defense);
            cbDefense.SelectedIndex = 0;
        }
        ///// EVENTS START //////////////////////////////////////////////////////////

        private void CbDefense_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbBuildTime.Text = "Build Time: " + dgDefense.Rows[cbDefense.SelectedIndex].Cells[3].Value.ToString();
            lbDescription.Text =  dgDefense.Rows[cbDefense.SelectedIndex].Cells[4].Value.ToString();
            lbBenefits.Text = "Benfits: " + dgDefense.Rows[cbDefense.SelectedIndex].Cells[5].Value.ToString() + " Can Hold "+ dgDefense.Rows[cbDefense.SelectedIndex].Cells[6].Value.ToString()+ " settlement Wealth holdings.";
            int cost = Convert.ToInt32(dgDefense.Rows[cbDefense.SelectedIndex].Cells[2].Value);
            if(tbDiscount.Text != "") { cost -= Convert.ToInt32(tbDiscount.Text); }
            lbCost.Text = cost.ToString();
        }

        private void TbDiscount_TextChanged(object sender, EventArgs e)
        {
            int cost = Convert.ToInt32(dgDefense.Rows[cbDefense.SelectedIndex].Cells[2].Value);
            if (tbDiscount.Text != "") { cost -= Convert.ToInt32(tbDiscount.Text); }
            lbCost.Text = cost.ToString();
        }

        private void BtBuy_Click(object sender, EventArgs e)
        {
            Validation.SetNullToZero(tbDiscount);
            House.InsertDefenseHolding(dgDefense.Rows[cbDefense.SelectedIndex].Cells[0].Value.ToString(), landID, tbName.Text, chbBuilt.Checked.ToString(), rtbNote.Text, tbDiscount.Text);
            Close();
        }
        //Validation
        private void TbDiscount_KeyPress(object sender, KeyPressEventArgs e) => Validation.OnlyDigit(e);


        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
