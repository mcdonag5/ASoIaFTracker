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

namespace WindowsFormsApp1.Forms
{
    public partial class CreateNewWealthHolding : Form
    {
        ///// VARIABLES START ///////////////////////////////////////////////////////
        string holdingType;
        string holdingID;
        //classes //
        DevLog DevLog = new DevLog();
        Validation Validation = new Validation();
        House House = new House();
        ///// VARIABLES END /////////////////////////////////////////////////////////

        ///// METHODS START /////////////////////////////////////////////////////////


        ///// METHODS END ///////////////////////////////////////////////////////////
        public CreateNewWealthHolding(string type)
        {
            holdingType = type;
            InitializeComponent();
        }

        public CreateNewWealthHolding(string type, string ID)
        {
            holdingType = type;
            holdingID = ID;
            InitializeComponent();
        }

        private void CreateNewWealthHolding_Load(object sender, EventArgs e)
        {
            switch(holdingType)
            {
                case "Wealth":
                    cbWealthHoldingType.SelectedIndex = 0;
                    lbInfluence.Visible = tbInfluence.Visible =  false;
                    break;
            }
            
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void CbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbWealthHoldingType.Text)
            {
                case "Estate":
                    lbTypeDescription.Text = "Estate Holdings represent concentrated, organized holdings intended to make the most of a domain’s natural resources. These are usually agricultural or husbandry related, although some may involve the harvest of natural resources. Not all domains where such resources are gathered must have these holdings, however. These holdings represent such operations on a scale large enough to influence the fortunes of the master House, generally producing not just enough for those who dwell there, but a surplus that can be sold. In either event, any given domain can have only one estate holding at a time.";
                    chbTakesSpace.Enabled = false; chbTakesSpace.Checked = true;
                    break;
                case "Lifestyle":
                    lbTypeDescription.Text = "Lifestyle Wealth Holdings reflect the sorts of luxuries that only the truly wealthy Houses can afford. They often provide improvements to the living conditions in a Community or Defensive Holding. Because these Holdings often build into the main keep or seat, some of them also cost points of Defense—such Holdings can reduce the overall defensibility of a castle, and so resources have to be allocated appropriately to include them.";
                    chbTakesSpace.Enabled = false; chbTakesSpace.Checked = false;
                    break;
                case "Personage":
                    lbTypeDescription.Text = "Personage Holdings represent either skilled individuals or small gatherings of such individuals. In general, they require the presence of a Community or Defensive Holding. Unlike with other Holdings, there are no limits on the number of Personage Wealth Holdings that may be purchased in a given domain.";
                    chbTakesSpace.Enabled = false; chbTakesSpace.Checked = false;
                    break;
                case "Settlement":
                    lbTypeDescription.Text = "Settlement Holdings require a population of some size in order to be built. Generally speaking, they require either a Community (Hamlet, Town or City) or Defensive Holding (Tower, Hall or Castle) in order to construct. A hamlet or tower may have one such Holding, a small town or hall may have two, a large town or castle may have four and there is no limit to how many larger communities or defensive holdings may have. These limits apply to all Settlement Wealth Holdings save where noted.";
                    chbTakesSpace.Enabled = true; chbTakesSpace.Checked = true;
                    break;
            }
        }

        private void BtCreate_Click(object sender, EventArgs e)
        {
            switch(holdingType)
            {
                case "Wealth":
                    if (tbName.Text != "")
                    {
                        Validation.SetNullTo(tbWealth); Validation.SetNullTo(tbDefense); Validation.SetNullTo(tbLand); Validation.SetNullTo(tbPower); 
                        Validation.SetNullTo(tbWeaGain); Validation.SetNullTo(tbPowGain); Validation.SetNullTo(tbPopGain); Validation.SetNullTo(tbLawGain); Validation.SetNullTo(tbLanGain); Validation.SetNullTo(tbInfGain); Validation.SetNullTo(tbDefGain);
                        Validation.SetNullTo(tbWeaLoss); Validation.SetNullTo(tbPopLoss); Validation.SetNullTo(tbPopLoss); Validation.SetNullTo(tbLawLoss); Validation.SetNullTo(tbLawLoss); Validation.SetNullTo(tbInfLoss); Validation.SetNullTo(tbDefLoss);
                        Validation.SetNullTo(tbHouseFortune); Validation.SetNullTo(tbLawPenaltyReduction); Validation.SetNullTo(tbPopulationPenaltyReduction);
                        Validation.SetNullTo(tbRequirement,"None");

                        House.InsertWealth(tbName.Text, cbWealthHoldingType.Text, chbTakesSpace.Checked.ToString(), tbWealth.Text, tbDefense.Text, tbLand.Text, tbPower.Text, tbTime.Text, tbRequirement.Text, rtbDescription.Text, rtbBenfits.Text, tbHouseFortune.Text, tbWeaGain.Text, tbPowGain.Text, tbPopGain.Text, tbLawGain.Text, tbLanGain.Text, tbInfGain.Text, tbDefGain.Text, tbWeaLoss.Text, tbPowLoss.Text, tbPopLoss.Text, tbLawLoss.Text, tbLanLoss.Text, tbInfLoss.Text, tbDefLoss.Text, tbLawPenaltyReduction.Text, tbPopulationPenaltyReduction.Text, tbHouseAction.Text);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("The holding needs a name.");
                    }
                    break;
            }
        }


        //Validation
        private void OnlyDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyDigit(e);
        }
        ///// EVENTS END ////////////////////////////////////////////////////////////

    }
}
