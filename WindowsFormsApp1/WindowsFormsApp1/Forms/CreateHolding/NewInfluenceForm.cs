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
    public partial class NewInfluenceForm : Form
    {
        ///// VARIABLES START ///////////////////////////////////////////////////////
        
        //Classes
        DevLog DevLog = new DevLog();
        House House;
        Validation Validation = new Validation();
        ///// VARIABLES END /////////////////////////////////////////////////////////

        ///// METHODS START /////////////////////////////////////////////////////////

        ///// METHODS END ///////////////////////////////////////////////////////////
        public NewInfluenceForm(int houseID, string houseName)
        {
            House = new House(houseID, houseName);

            InitializeComponent();

            Text = House.name + " New Influence Holding";

            dgInfluence.DataSource = House.HouseQry("Influence");
            object[] influence = new object[dgInfluence.RowCount];
            for (int i = 0; i < dgInfluence.RowCount; i++)
            {
                influence[i] = dgInfluence.Rows[i].Cells[1].Value.ToString() + " - Inf: " + dgInfluence.Rows[i].Cells[2].Value.ToString();
            }
            cbInfluence.Items.Clear();
            cbInfluence.Items.AddRange(influence);
            cbInfluence.SelectedIndex = 0;
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void CbDefense_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDescription.Text = dgInfluence.Rows[cbInfluence.SelectedIndex].Cells[3].Value.ToString() + Environment.NewLine;
            lbBenefits.Text = "Benfits:" + dgInfluence.Rows[cbInfluence.SelectedIndex].Cells[4].Value.ToString();
            int cost = Convert.ToInt32(dgInfluence.Rows[cbInfluence.SelectedIndex].Cells[2].Value);
            if(tbDiscount.Text != "") { cost -= Convert.ToInt32(tbDiscount.Text); }
            lbCost.Text = cost.ToString();
        }

        private void TbDiscount_TextChanged(object sender, EventArgs e)
        {
            if (tbDiscount.Text != "") { lbCost.Text = Convert.ToString(Convert.ToInt32(dgInfluence.Rows[cbInfluence.SelectedIndex].Cells[2].Value) - Convert.ToInt32(tbDiscount.Text)); }
            else { lbCost.Text = dgInfluence.Rows[cbInfluence.SelectedIndex].Cells[2].Value.ToString(); }
        }

        private void BtBuy_Click(object sender, EventArgs e)
        {
            Validation.SetNullTo(tbDiscount, "0");
            House.InsertInfluence(dgInfluence.Rows[cbInfluence.SelectedIndex].Cells[0].Value.ToString(), tbName.Text, rtbNote.Text, tbDiscount.Text);
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
