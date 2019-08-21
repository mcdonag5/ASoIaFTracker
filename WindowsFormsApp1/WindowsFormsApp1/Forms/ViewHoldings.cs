﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class ViewHoldings : Form
    {
        ///// VARIABLES START ///////////////////////////////////////////////////////

        //Classes
        DevLog DevLog = new DevLog();
        House House = new House();
        ///// VARIABLES END /////////////////////////////////////////////////////////

        ///// METHODS START /////////////////////////////////////////////////////////
        
        ///// METHODS END ///////////////////////////////////////////////////////////
        public ViewHoldings()
        {
            InitializeComponent();
        }

        private void ViewHoldings_Load(object sender, EventArgs e)
        {
            cbHoldingType.SelectedIndex = 0;
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void cbHoldingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDoubleHoldingName.Visible = cbDoubleHoldingType.Visible = cbHoldingType.Text == "Wealth" ? true : false;
            cbSoloHoldingName.Visible = !cbDoubleHoldingName.Visible;
            lbBuildTime.Visible = lbBuildTimeDetails.Visible = new[] { "Defense", "Wealth" }.Contains(cbHoldingType.Text) ? true : false;
            lbDisciplineModifier.Visible = lbDisciplineModifierDetail.Visible = lbKeyAbilities.Visible = lbKeyAbilitiesDetails.Visible = lbBaseMovement.Visible = lbBaseMovementDetails.Visible = cbHoldingType.Text == "Unit Type" ? true:false;
            lbRequirement.Visible = lbRequirementDetails.Visible = cbHoldingType.Text == "Wealth" ? true : false;

            if(cbHoldingType.Text != "Wealth")
            {
                dgHoldings.DataSource = House.HouseQry(cbHoldingType.Text);
                object[] holding = new object[dgHoldings.RowCount];
                for (int i = 0; i < dgHoldings.RowCount; i++)
                {
                    holding[i] = dgHoldings.Rows[i].Cells[1].Value.ToString();
                }
                cbSoloHoldingName.Items.Clear();
                cbSoloHoldingName.Items.AddRange(holding);
                cbSoloHoldingName.SelectedIndex = 0;
            }
            else
            {
                cbDoubleHoldingType.SelectedIndex = 0;
            }
        }

        private void cbSoloHoldingName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSoloHoldingName.SelectedIndex;
            string description = "";
            switch (cbHoldingType.Text)
            {
                case "Land":
                    lbCostDetails.Text = dgHoldings.Rows[index].Cells[2].Value.ToString() + " Land";

                    lbDescription.Text = dgHoldings.Rows[index].Cells[3].Value.ToString();
                    break;
                case "Land Features":
                    lbCostDetails.Text = dgHoldings.Rows[index].Cells[2].Value.ToString() + " Land";
                    if(dgHoldings.Rows[index].Cells[3].Value.ToString() != "0") { lbCostDetails.Text += ", " + dgHoldings.Rows[index].Cells[3].Value.ToString() + " Population"; }
                    
                    if(Convert.ToInt32(dgHoldings.Rows[index].Cells[4].Value)>0) { description += "This feature can hold " + dgHoldings.Rows[index].Cells[4].Value + " Settlement Holdings. "; }
                    description += dgHoldings.Rows[index].Cells[5].Value.ToString();
                    break;
                case "Defense":
                    lbCostDetails.Text = dgHoldings.Rows[index].Cells[2].Value.ToString() + " Defense";
                    lbBuildTimeDetails.Text = dgHoldings.Rows[index].Cells[3].Value.ToString();

                    description += dgHoldings.Rows[index].Cells[4].Value.ToString() + Environment.NewLine + Environment.NewLine;
                    if (Convert.ToInt32(dgHoldings.Rows[index].Cells[6].Value) > 0) { description += "This defense holding can hold " + dgHoldings.Rows[index].Cells[6].Value + " Settlement Holdings. "; }
                    description += dgHoldings.Rows[index].Cells[5].Value.ToString();
                    break;
                case "Unit Type":
                    lbCostDetails.Text = dgHoldings.Rows[index].Cells[2].Value.ToString() + " Power";
                    lbDisciplineModifierDetail.Text = Convert.ToInt32(dgHoldings.Rows[index].Cells[3].Value) > 0 ? "+" + dgHoldings.Rows[index].Cells[3].Value : dgHoldings.Rows[index].Cells[3].Value.ToString();
                    lbKeyAbilitiesDetails.Text = dgHoldings.Rows[index].Cells[4].Value + ", " + dgHoldings.Rows[index].Cells[5].Value + ", " + dgHoldings.Rows[index].Cells[6].Value;
                    lbBaseMovementDetails.Text = dgHoldings.Rows[index].Cells[19].Value.ToString();

                    description += dgHoldings.Rows[index].Cells[7].Value.ToString();
                    break;
            }
            lbDescription.Text = description;
        }

        private void cbDoubleHoldingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgHoldings.DataSource = House.HouseQry(cbDoubleHoldingType.Text);
            object[] holding = new object[dgHoldings.RowCount];
            for (int i = 0; i < dgHoldings.RowCount; i++)
            {
                holding[i] = dgHoldings.Rows[i].Cells[1].Value.ToString();
            }
            cbDoubleHoldingName.Items.Clear();
            cbDoubleHoldingName.Items.AddRange(holding);
            cbDoubleHoldingName.SelectedIndex = 0;
        }

        private void cbDoubleHoldingName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbDoubleHoldingName.SelectedIndex;
            string cost = "";
            string[] costNames = new string[] { "Wealth","Defense","Land","Power"};
            for (int i = 0;i<4;i++)
            {
                if(dgHoldings.Rows[index].Cells[i+4].Value.ToString() != "0")
                {
                    if(cost != "") { cost += ", "; }
                    cost += dgHoldings.Rows[index].Cells[i + 4].Value.ToString() + " " + costNames[i];
                }
            }
            lbCostDetails.Text = cost;
            lbBuildTimeDetails.Text = dgHoldings.Rows[index].Cells[8].Value.ToString();
            lbRequirementDetails.Text = dgHoldings.Rows[index].Cells[9].Value.ToString();

            lbDescription.Text = dgHoldings.Rows[index].Cells[10].Value.ToString() + Environment.NewLine + Environment.NewLine + dgHoldings.Rows[index].Cells[11].Value.ToString();
        }
        ///// EVENTS END ////////////////////////////////////////////////////////////

    }
}