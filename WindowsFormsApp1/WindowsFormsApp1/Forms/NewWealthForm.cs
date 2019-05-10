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
    public partial class NewWealthForm : Form
    {
        ///// VARIABLES START //////////////////////////////////////////////////////
        DevLog DevLog = new DevLog();
        Validation Validation = new Validation();
        House House;
        string holdingType;
        string holdingID;
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////
        public void SelectWealthTypes(string type)
        {
            dgWealth.DataSource = House.HouseQry(type);
            object[] defense = new object[dgWealth.RowCount];
            string item;
            for (int i = 0; i < dgWealth.RowCount; i++)
            {
                item = dgWealth.Rows[i].Cells[1].Value.ToString();
                if (Convert.ToInt32(dgWealth.Rows[i].Cells[4].Value) > 0) { item += " Wea: " + dgWealth.Rows[i].Cells[4].Value.ToString(); }
                if (Convert.ToInt32(dgWealth.Rows[i].Cells[5].Value) > 0){ item += " Def: " + dgWealth.Rows[i].Cells[5].Value.ToString(); }
                if (Convert.ToInt32(dgWealth.Rows[i].Cells[6].Value) > 0) { item += " Lan: " + dgWealth.Rows[i].Cells[6].Value.ToString(); }
                if (Convert.ToInt32(dgWealth.Rows[i].Cells[7].Value) > 0) { item += " Pow: " + dgWealth.Rows[i].Cells[7].Value.ToString(); }
                defense[i] = item;
            }
            cbWealth.Items.Clear();
            cbWealth.Items.AddRange(defense);
            cbWealth.SelectedIndex = 0;
        }
        ///// METHODS END //////////////////////////////////////////////////////////
        public NewWealthForm(int HouseID, string type, int ID, string hoildingName)
        {
            House = new House(HouseID);
            holdingType = type;
            holdingID = ID.ToString();

            InitializeComponent();

            cbType.SelectedIndex = 0;

        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectWealthTypes(cbType.Text);
        }

        private void cbWealth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cost = Convert.ToInt32(dgWealth.Rows[cbWealth.SelectedIndex].Cells[4].Value);
            if (tbDiscount.Text != "") { cost -= Convert.ToInt32(tbDiscount.Text); }
            string text = "";
            if (cost > 0) { text += "Wealth: " + cost; }
            if (Convert.ToInt32(dgWealth.Rows[cbWealth.SelectedIndex].Cells[5].Value) > 0) { text += " Defense: " + dgWealth.Rows[cbWealth.SelectedIndex].Cells[5].Value.ToString(); }
            if (Convert.ToInt32(dgWealth.Rows[cbWealth.SelectedIndex].Cells[6].Value) > 0) { text += " Land: " + dgWealth.Rows[cbWealth.SelectedIndex].Cells[6].Value.ToString(); }
            if (Convert.ToInt32(dgWealth.Rows[cbWealth.SelectedIndex].Cells[7].Value) > 0) { text += " Power: " + dgWealth.Rows[cbWealth.SelectedIndex].Cells[7].Value.ToString(); }
            lbCost.Text = text;

            lbBuildTime.Text = dgWealth.Rows[cbWealth.SelectedIndex].Cells[8].Value.ToString();
            lbRequirement.Text = dgWealth.Rows[cbWealth.SelectedIndex].Cells[9].Value.ToString();
            lbDescription.Text = dgWealth.Rows[cbWealth.SelectedIndex].Cells[10].Value.ToString();
            lbBenefits.Text = Environment.NewLine + dgWealth.Rows[cbWealth.SelectedIndex].Cells[11].Value.ToString();
        }

        private void tbDiscount_TextChanged(object sender, EventArgs e)
        {
            int cost = Convert.ToInt32(dgWealth.Rows[cbWealth.SelectedIndex].Cells[4].Value);
            if (tbDiscount.Text != "") { cost -= Convert.ToInt32(tbDiscount.Text); }
            string text = "";
            if (cost > 0) { text += "Wealth: " + cost; }
            if (Convert.ToInt32(dgWealth.Rows[cbWealth.SelectedIndex].Cells[5].Value) > 0) { text += " Defense: " + dgWealth.Rows[cbWealth.SelectedIndex].Cells[5].Value.ToString(); }
            if (Convert.ToInt32(dgWealth.Rows[cbWealth.SelectedIndex].Cells[6].Value) > 0) { text += " Land: " + dgWealth.Rows[cbWealth.SelectedIndex].Cells[6].Value.ToString(); }
            if (Convert.ToInt32(dgWealth.Rows[cbWealth.SelectedIndex].Cells[7].Value) > 0) { text += " Power: " + dgWealth.Rows[cbWealth.SelectedIndex].Cells[7].Value.ToString(); }
            lbCost.Text = text;
        }
        //Validation
        private void tbDiscount_KeyPress(object sender, KeyPressEventArgs e) => Validation.OnlyDigit(e);





        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
