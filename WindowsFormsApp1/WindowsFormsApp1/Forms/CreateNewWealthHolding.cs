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
                    lbInfluence.Visible = tbInfluence.Visible = lbWealthHolding.Visible = cbImprovementType.Visible = cbImprovementHolding.Visible = lbRepeatable.Visible = chbRepeatable.Visible = 
                    lbInfluenceHoldings.Visible = cbInfluenceHoldings.Visible = lbSpaces.Visible = tbSpaces.Visible =
                    lbDisciplineModifier.Visible = tbDisciplineModifier.Visible = lbMovement.Visible = tbMovement.Visible = lbKeyAbilities.Visible = cbKeyAbilities1.Visible = cbKeyAbilities2.Visible = cbKeyAbilities3.Visible = lbNormal.Visible = lbUpgraded.Visible = lbArmorRTG.Visible = tbArmorRTG.Visible = tbArmorRTGUpg.Visible = lbArmorPenalty.Visible = tbArmorPenalty.Visible = tbArmorPenaltyUpg.Visible = lbBulk.Visible = tbBulk.Visible = tbBulkUpg.Visible = lbFightingDamage.Visible = tbFightingDamage.Visible = tbFightingDamageUpg.Visible =lbMarksmanshipDamage.Visible = tbMarksmanshipDamage.Visible = tbMarksmanshipDamageUpg.Visible = lbMarksmanshipRange.Visible = cblbMarksmanshipRange.Visible = false;
                    break;
                case "Wealth Improvement":
                    cbImprovementType.SelectedIndex = 0;
                    chbLimit.Checked = true;
                    lbWealthHoldingType.Visible = cbWealthHoldingType.Visible = 
                    lbInfluenceHoldings.Visible = cbInfluenceHoldings.Visible = lbSpaces.Visible = tbSpaces.Visible =
                    lbDisciplineModifier.Visible = tbDisciplineModifier.Visible = lbMovement.Visible = tbMovement.Visible = lbKeyAbilities.Visible = cbKeyAbilities1.Visible = cbKeyAbilities2.Visible = cbKeyAbilities3.Visible = lbNormal.Visible = lbUpgraded.Visible = lbArmorRTG.Visible = tbArmorRTG.Visible = tbArmorRTGUpg.Visible = lbArmorPenalty.Visible = tbArmorPenalty.Visible = tbArmorPenaltyUpg.Visible = lbBulk.Visible = tbBulk.Visible = tbBulkUpg.Visible = lbFightingDamage.Visible = tbFightingDamage.Visible = tbFightingDamageUpg.Visible = lbMarksmanshipDamage.Visible = tbMarksmanshipDamage.Visible = tbMarksmanshipDamageUpg.Visible = lbMarksmanshipRange.Visible = cblbMarksmanshipRange.Visible = false;
                    break;
                case "Influence":
                    lbWealthHoldingType.Visible = cbWealthHoldingType.Visible = lbWealthHolding.Visible = cbImprovementType.Visible = cbImprovementHolding.Visible = lbTypeDescription.Visible = lbTime.Visible = tbTime.Visible = lbRequirement.Visible = tbRequirement.Visible = 
                    lbWealth.Visible = tbWealth.Visible = lbDefense.Visible = tbDefense.Visible = lbLand.Visible = tbLand.Visible = lbPower.Visible = tbPower.Visible = 
                    lbHouseFortune.Visible = tbHouseFortune.Visible = lbHouseAction.Visible = tbHouseAction.Visible = lbResourceLossMitigation.Visible = lbWeaLoss.Visible = tbWeaLoss.Visible = lbPowLoss.Visible = tbPowLoss.Visible = lbPopLoss.Visible = tbPopLoss.Visible = lbLawLoss.Visible = tbLawLoss.Visible = lbLanLoss.Visible = tbLanLoss.Visible = lbInfLoss.Visible = tbInfLoss.Visible = lbDefLoss.Visible = tbDefLoss.Visible =
                    lbLimit.Visible = chbLimit.Visible = lbRepeatable.Visible = chbRepeatable.Visible = 
                    lbInfluenceHoldings.Visible = cbInfluenceHoldings.Visible = lbSpaces.Visible = tbSpaces.Visible =
                    lbDisciplineModifier.Visible = tbDisciplineModifier.Visible = lbMovement.Visible = tbMovement.Visible = lbKeyAbilities.Visible = cbKeyAbilities1.Visible = cbKeyAbilities2.Visible = cbKeyAbilities3.Visible = lbNormal.Visible = lbUpgraded.Visible = lbArmorRTG.Visible = tbArmorRTG.Visible = tbArmorRTGUpg.Visible = lbArmorPenalty.Visible = tbArmorPenalty.Visible = tbArmorPenaltyUpg.Visible = lbBulk.Visible = tbBulk.Visible = tbBulkUpg.Visible = lbFightingDamage.Visible = tbFightingDamage.Visible = tbFightingDamageUpg.Visible = lbMarksmanshipDamage.Visible = tbMarksmanshipDamage.Visible = tbMarksmanshipDamageUpg.Visible = lbMarksmanshipRange.Visible = cblbMarksmanshipRange.Visible = false;
                    break;
                case "Influence Improvement":
                    lbWealthHoldingType.Visible = cbWealthHoldingType.Visible = lbWealthHolding.Visible = cbImprovementType.Visible = cbImprovementHolding.Visible = lbTypeDescription.Visible = lbTime.Visible = tbTime.Visible = lbRequirement.Visible = tbRequirement.Visible = 
                    lbWealth.Visible = tbWealth.Visible = lbDefense.Visible = tbDefense.Visible = lbLand.Visible = tbLand.Visible = lbPower.Visible = tbPower.Visible = 
                    lbHouseFortune.Visible = tbHouseFortune.Visible = lbHouseAction.Visible = tbHouseAction.Visible = lbResourceLossMitigation.Visible = lbWeaLoss.Visible = tbWeaLoss.Visible = lbPowLoss.Visible = tbPowLoss.Visible = lbPopLoss.Visible = tbPopLoss.Visible = lbLawLoss.Visible = tbLawLoss.Visible = lbLanLoss.Visible = tbLanLoss.Visible = lbInfLoss.Visible = tbInfLoss.Visible = lbDefLoss.Visible = tbDefLoss.Visible =
                    lbLimit.Visible = chbLimit.Visible = lbRepeatable.Visible = chbRepeatable.Visible = lbSpaces.Visible = tbSpaces.Visible =
                    lbDisciplineModifier.Visible = tbDisciplineModifier.Visible = lbMovement.Visible = tbMovement.Visible = lbKeyAbilities.Visible = cbKeyAbilities1.Visible = cbKeyAbilities2.Visible = cbKeyAbilities3.Visible = lbNormal.Visible = lbUpgraded.Visible = lbArmorRTG.Visible = tbArmorRTG.Visible = tbArmorRTGUpg.Visible = lbArmorPenalty.Visible = tbArmorPenalty.Visible = tbArmorPenaltyUpg.Visible = lbBulk.Visible = tbBulk.Visible = tbBulkUpg.Visible = lbFightingDamage.Visible = tbFightingDamage.Visible = tbFightingDamageUpg.Visible = lbMarksmanshipDamage.Visible = tbMarksmanshipDamage.Visible = tbMarksmanshipDamageUpg.Visible = lbMarksmanshipRange.Visible = cblbMarksmanshipRange.Visible = false;

                    dgHoldings.DataSource = House.HouseQry("Influence");
                    object[] influence = new object[dgHoldings.RowCount];
                    for (int i = 0; i < dgHoldings.RowCount; i++)
                    {
                        influence[i] = dgHoldings.Rows[i].Cells[1].Value.ToString() + " - Inf: " + dgHoldings.Rows[i].Cells[2].Value.ToString();
                    }
                    cbInfluenceHoldings.Items.Clear();
                    cbInfluenceHoldings.Items.AddRange(influence);
                    cbInfluenceHoldings.SelectedIndex = 0;
                    break;
                case "Defense":
                    lbWealthHoldingType.Visible = cbWealthHoldingType.Visible = lbWealthHolding.Visible = cbImprovementType.Visible = cbImprovementHolding.Visible = lbTypeDescription.Visible = lbRequirement.Visible = tbRequirement.Visible = lbInfluenceHoldings.Visible = cbInfluenceHoldings.Visible = 
                    lbWealth.Visible = tbWealth.Visible = lbLand.Visible = tbLand.Visible = lbPower.Visible = tbPower.Visible = lbInfluence.Visible = tbInfluence.Visible =
                    lbHouseFortune.Visible = tbHouseFortune.Visible = lbHouseAction.Visible = tbHouseAction.Visible = lbLawPenaltyReduction.Visible = tbLawPenaltyReduction.Visible = lbPopulationPenaltyReduction.Visible = tbPopulationPenaltyReduction.Visible =
                    lbResourceLossMitigation.Visible = lbWeaLoss.Visible = tbWeaLoss.Visible = lbPowLoss.Visible = tbPowLoss.Visible = lbPopLoss.Visible = tbPopLoss.Visible = lbLawLoss.Visible = tbLawLoss.Visible = lbLanLoss.Visible = tbLanLoss.Visible = lbInfLoss.Visible = tbInfLoss.Visible = lbDefLoss.Visible = tbDefLoss.Visible =
                    lbResourceGainBonus.Visible = lbWeaGain.Visible = tbWeaGain.Visible = lbPowGain.Visible = tbPowGain.Visible = lbPopGain.Visible = tbPopGain.Visible = lbLawGain.Visible = tbLawGain.Visible = lbLanGain.Visible = tbLanGain.Visible = lbInfGain.Visible = tbInfGain.Visible = lbDefGain.Visible = tbDefGain.Visible =
                    lbLimit.Visible = chbLimit.Visible = lbRepeatable.Visible = chbRepeatable.Visible =
                    lbDisciplineModifier.Visible = tbDisciplineModifier.Visible = lbMovement.Visible = tbMovement.Visible = lbKeyAbilities.Visible = cbKeyAbilities1.Visible = cbKeyAbilities2.Visible = cbKeyAbilities3.Visible = lbNormal.Visible = lbUpgraded.Visible = lbArmorRTG.Visible = tbArmorRTG.Visible = tbArmorRTGUpg.Visible = lbArmorPenalty.Visible = tbArmorPenalty.Visible = tbArmorPenaltyUpg.Visible = lbBulk.Visible = tbBulk.Visible = tbBulkUpg.Visible = lbFightingDamage.Visible = tbFightingDamage.Visible = tbFightingDamageUpg.Visible = lbMarksmanshipDamage.Visible = tbMarksmanshipDamage.Visible = tbMarksmanshipDamageUpg.Visible = lbMarksmanshipRange.Visible = cblbMarksmanshipRange.Visible = false;
                    break;
                case "Unit Type":
                    lbWealthHoldingType.Visible = cbWealthHoldingType.Visible = lbWealthHolding.Visible = cbImprovementType.Visible = cbImprovementHolding.Visible = lbTypeDescription.Visible = lbRequirement.Visible = tbRequirement.Visible = lbInfluenceHoldings.Visible = cbInfluenceHoldings.Visible = lbTime.Visible = tbTime.Visible = 
                    lbWealth.Visible = tbWealth.Visible = lbLand.Visible = tbLand.Visible = lbDefense.Visible = tbDefense.Visible = lbInfluence.Visible = tbInfluence.Visible = lbBenfits.Visible = rtbBenfits.Visible =
                    lbHouseFortune.Visible = tbHouseFortune.Visible = lbHouseAction.Visible = tbHouseAction.Visible = lbLawPenaltyReduction.Visible = tbLawPenaltyReduction.Visible = lbPopulationPenaltyReduction.Visible = tbPopulationPenaltyReduction.Visible =
                    lbResourceLossMitigation.Visible = lbWeaLoss.Visible = tbWeaLoss.Visible = lbPowLoss.Visible = tbPowLoss.Visible = lbPopLoss.Visible = tbPopLoss.Visible = lbLawLoss.Visible = tbLawLoss.Visible = lbLanLoss.Visible = tbLanLoss.Visible = lbInfLoss.Visible = tbInfLoss.Visible = lbDefLoss.Visible = tbDefLoss.Visible =
                    lbResourceGainBonus.Visible = lbWeaGain.Visible = tbWeaGain.Visible = lbPowGain.Visible = tbPowGain.Visible = lbPopGain.Visible = tbPopGain.Visible = lbLawGain.Visible = tbLawGain.Visible = lbLanGain.Visible = tbLanGain.Visible = lbInfGain.Visible = tbInfGain.Visible = lbDefGain.Visible = tbDefGain.Visible =
                    lbLimit.Visible = chbLimit.Visible = lbRepeatable.Visible = chbRepeatable.Visible = lbSpaces.Visible = tbSpaces.Visible = false;
                    break;
            }
            if(holdingID != null)
            {
                Text = "Edit " + holdingType + " Holding";

                switch (holdingType)
                {
                    case "Wealth":
                        dgEditHolding.DataSource = House.HouseQry("Wealth", holdingID);

                        tbName.Text = dgEditHolding.Rows[0].Cells[1].Value.ToString();
                        switch(dgEditHolding.Rows[0].Cells[2].Value.ToString())
                        {
                            case "Lifestyle":
                                cbWealthHoldingType.SelectedIndex = 1;
                                break;
                            case "Personage":
                                cbWealthHoldingType.SelectedIndex = 2;
                                break;
                            case "Settlement":
                                cbWealthHoldingType.SelectedIndex = 3;
                                break;
                        }
                        chbLimit.Checked = Convert.ToBoolean(dgEditHolding.Rows[0].Cells[3].Value);
                        tbWealth.Text = dgEditHolding.Rows[0].Cells[4].Value.ToString();
                        tbDefense.Text = dgEditHolding.Rows[0].Cells[5].Value.ToString();
                        tbLand.Text = dgEditHolding.Rows[0].Cells[6].Value.ToString();
                        tbPower.Text = dgEditHolding.Rows[0].Cells[7].Value.ToString();
                        tbTime.Text = dgEditHolding.Rows[0].Cells[8].Value.ToString();
                        tbRequirement.Text = dgEditHolding.Rows[0].Cells[9].Value.ToString();
                        rtbDescription.Text = dgEditHolding.Rows[0].Cells[10].Value.ToString();
                        rtbBenfits.Text = dgEditHolding.Rows[0].Cells[11].Value.ToString();
                        tbHouseFortune.Text = dgEditHolding.Rows[0].Cells[12].Value.ToString();
                        tbWeaGain.Text = dgEditHolding.Rows[0].Cells[13].Value.ToString();
                        tbPowGain.Text = dgEditHolding.Rows[0].Cells[14].Value.ToString();
                        tbPopGain.Text = dgEditHolding.Rows[0].Cells[15].Value.ToString();
                        tbLawGain.Text = dgEditHolding.Rows[0].Cells[16].Value.ToString();
                        tbLanGain.Text = dgEditHolding.Rows[0].Cells[17].Value.ToString();
                        tbInfGain.Text = dgEditHolding.Rows[0].Cells[18].Value.ToString();
                        tbDefGain.Text = dgEditHolding.Rows[0].Cells[19].Value.ToString();
                        tbWeaLoss.Text = dgEditHolding.Rows[0].Cells[20].Value.ToString();
                        tbPowLoss.Text = dgEditHolding.Rows[0].Cells[21].Value.ToString();
                        tbPopLoss.Text = dgEditHolding.Rows[0].Cells[22].Value.ToString();
                        tbLawLoss.Text = dgEditHolding.Rows[0].Cells[23].Value.ToString();
                        tbLanLoss.Text = dgEditHolding.Rows[0].Cells[24].Value.ToString();
                        tbInfLoss.Text = dgEditHolding.Rows[0].Cells[25].Value.ToString();
                        tbDefLoss.Text = dgEditHolding.Rows[0].Cells[26].Value.ToString();
                        tbLawPenaltyReduction.Text = dgEditHolding.Rows[0].Cells[27].Value.ToString();
                        tbPopulationPenaltyReduction.Text = dgEditHolding.Rows[0].Cells[28].Value.ToString();
                        tbHouseAction.Text = dgEditHolding.Rows[0].Cells[29].Value.ToString();
                        break;
                    case "Wealth Improvement":
                        
                        break;
                    case "Influence":

                        break;
                    case "Influence Improvement":

                        break;
                    case "Defense":

                        break;
                    case "Unit Type":

                        break;
                }
            }
            else
            {
                Text = "Create new " + holdingType + " Holding";
            }
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void CbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbWealthHoldingType.Text)
            {
                case "Estate":
                    lbTypeDescription.Text = "Estate Holdings represent concentrated, organized holdings intended to make the most of a domain’s natural resources. These are usually agricultural or husbandry related, although some may involve the harvest of natural resources. Not all domains where such resources are gathered must have these holdings, however. These holdings represent such operations on a scale large enough to influence the fortunes of the master House, generally producing not just enough for those who dwell there, but a surplus that can be sold. In either event, any given domain can have only one estate holding at a time.";
                    chbLimit.Enabled = false; chbLimit.Checked = true;
                    break;
                case "Lifestyle":
                    lbTypeDescription.Text = "Lifestyle Wealth Holdings reflect the sorts of luxuries that only the truly wealthy Houses can afford. They often provide improvements to the living conditions in a Community or Defensive Holding. Because these Holdings often build into the main keep or seat, some of them also cost points of Defense—such Holdings can reduce the overall defensibility of a castle, and so resources have to be allocated appropriately to include them.";
                    chbLimit.Enabled = false; chbLimit.Checked = false;
                    break;
                case "Personage":
                    lbTypeDescription.Text = "Personage Holdings represent either skilled individuals or small gatherings of such individuals. In general, they require the presence of a Community or Defensive Holding. Unlike with other Holdings, there are no limits on the number of Personage Wealth Holdings that may be purchased in a given domain.";
                    chbLimit.Enabled = false; chbLimit.Checked = false;
                    break;
                case "Settlement":
                    lbTypeDescription.Text = "Settlement Holdings require a population of some size in order to be built. Generally speaking, they require either a Community (Hamlet, Town or City) or Defensive Holding (Tower, Hall or Castle) in order to construct. A hamlet or tower may have one such Holding, a small town or hall may have two, a large town or castle may have four and there is no limit to how many larger communities or defensive holdings may have. These limits apply to all Settlement Wealth Holdings save where noted.";
                    chbLimit.Enabled = true; chbLimit.Checked = true;
                    break;
            }
        }

        private void CbImprovementType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgHoldings.DataSource = House.HouseQry(cbImprovementType.Text);
            object[] defense = new object[dgHoldings.RowCount];
            string item;
            for (int i = 0; i < dgHoldings.RowCount; i++)
            {
                item = dgHoldings.Rows[i].Cells[1].Value.ToString();
                if (Convert.ToInt32(dgHoldings.Rows[i].Cells[4].Value) > 0) { item += " Wea: " + dgHoldings.Rows[i].Cells[4].Value.ToString(); }
                if (Convert.ToInt32(dgHoldings.Rows[i].Cells[5].Value) > 0) { item += " Def: " + dgHoldings.Rows[i].Cells[5].Value.ToString(); }
                if (Convert.ToInt32(dgHoldings.Rows[i].Cells[6].Value) > 0) { item += " Lan: " + dgHoldings.Rows[i].Cells[6].Value.ToString(); }
                if (Convert.ToInt32(dgHoldings.Rows[i].Cells[7].Value) > 0) { item += " Pow: " + dgHoldings.Rows[i].Cells[7].Value.ToString(); }
                defense[i] = item;
            }
            cbImprovementHolding.Items.Clear();
            cbImprovementHolding.Items.AddRange(defense);
            cbImprovementHolding.SelectedIndex = 0;
        }

        private void BtCreate_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                switch (holdingType)
                {
                    case "Wealth":

                        Validation.SetNullTo(tbWealth); Validation.SetNullTo(tbDefense); Validation.SetNullTo(tbLand); Validation.SetNullTo(tbPower);
                        Validation.SetNullTo(tbWeaGain); Validation.SetNullTo(tbPowGain); Validation.SetNullTo(tbPopGain); Validation.SetNullTo(tbLawGain); Validation.SetNullTo(tbLanGain); Validation.SetNullTo(tbInfGain); Validation.SetNullTo(tbDefGain);
                        Validation.SetNullTo(tbWeaLoss); Validation.SetNullTo(tbPopLoss); Validation.SetNullTo(tbPopLoss); Validation.SetNullTo(tbLawLoss); Validation.SetNullTo(tbLawLoss); Validation.SetNullTo(tbInfLoss); Validation.SetNullTo(tbDefLoss);
                        Validation.SetNullTo(tbHouseFortune); Validation.SetNullTo(tbLawPenaltyReduction); Validation.SetNullTo(tbPopulationPenaltyReduction);
                        Validation.SetNullTo(tbRequirement, "None");

                        if(holdingID == null)
                        {
                            House.InsertWealth(tbName.Text, cbWealthHoldingType.Text, chbLimit.Checked.ToString(), tbWealth.Text, tbDefense.Text, tbLand.Text, tbPower.Text, tbTime.Text, tbRequirement.Text, rtbDescription.Text, rtbBenfits.Text, tbHouseFortune.Text, tbWeaGain.Text, tbPowGain.Text, tbPopGain.Text, tbLawGain.Text, tbLanGain.Text, tbInfGain.Text, tbDefGain.Text, tbWeaLoss.Text, tbPowLoss.Text, tbPopLoss.Text, tbLawLoss.Text, tbLanLoss.Text, tbInfLoss.Text, tbDefLoss.Text, tbLawPenaltyReduction.Text, tbPopulationPenaltyReduction.Text, tbHouseAction.Text);
                        }
                        else
                        {
                            House.UpdateWealth(holdingID, tbName.Text, cbWealthHoldingType.Text, chbLimit.Checked.ToString(), tbWealth.Text, tbDefense.Text, tbLand.Text, tbPower.Text, tbTime.Text, tbRequirement.Text, rtbDescription.Text, rtbBenfits.Text, tbHouseFortune.Text, tbWeaGain.Text, tbPowGain.Text, tbPopGain.Text, tbLawGain.Text, tbLanGain.Text, tbInfGain.Text, tbDefGain.Text, tbWeaLoss.Text, tbPowLoss.Text, tbPopLoss.Text, tbLawLoss.Text, tbLanLoss.Text, tbInfLoss.Text, tbDefLoss.Text, tbLawPenaltyReduction.Text, tbPopulationPenaltyReduction.Text, tbHouseAction.Text);
                        }
                        
                        Close();

                        break;
                    case "Wealth Improvement":
                        Validation.SetNullTo(tbWealth); Validation.SetNullTo(tbDefense); Validation.SetNullTo(tbLand); Validation.SetNullTo(tbPower); Validation.SetNullTo(tbInfluence);
                        Validation.SetNullTo(tbWeaGain); Validation.SetNullTo(tbPowGain); Validation.SetNullTo(tbPopGain); Validation.SetNullTo(tbLawGain); Validation.SetNullTo(tbLanGain); Validation.SetNullTo(tbInfGain); Validation.SetNullTo(tbDefGain);
                        Validation.SetNullTo(tbWeaLoss); Validation.SetNullTo(tbPopLoss); Validation.SetNullTo(tbPopLoss); Validation.SetNullTo(tbLawLoss); Validation.SetNullTo(tbLawLoss); Validation.SetNullTo(tbInfLoss); Validation.SetNullTo(tbDefLoss);
                        Validation.SetNullTo(tbHouseFortune); Validation.SetNullTo(tbLawPenaltyReduction); Validation.SetNullTo(tbPopulationPenaltyReduction);

                        House.InsertWealthImprovement(dgHoldings.Rows[cbImprovementHolding.SelectedIndex].Cells[0].Value.ToString(), tbName.Text, chbLimit.Checked.ToString(), tbWealth.Text, tbDefense.Text, tbLand.Text, tbPower.Text, tbInfluence.Text, tbTime.Text, tbRequirement.Text, rtbDescription.Text, rtbBenfits.Text, tbHouseFortune.Text, tbWeaGain.Text, tbPowGain.Text, tbPopGain.Text, tbLawGain.Text, tbLanGain.Text, tbInfGain.Text, tbDefGain.Text, tbWeaLoss.Text, tbPowLoss.Text, tbPopLoss.Text, tbLawLoss.Text, tbLanLoss.Text, tbInfLoss.Text, tbDefLoss.Text, tbLawPenaltyReduction.Text, tbPopulationPenaltyReduction.Text, tbHouseAction.Text, chbRepeatable.Checked.ToString());
                        Close();
                        break;
                    case "Influence":
                        Validation.SetNullTo(tbInfluence);
                        Validation.SetNullTo(tbWeaGain); Validation.SetNullTo(tbPowGain); Validation.SetNullTo(tbPopGain); Validation.SetNullTo(tbLawGain); Validation.SetNullTo(tbLanGain); Validation.SetNullTo(tbInfGain); Validation.SetNullTo(tbDefGain);
                        Validation.SetNullTo(tbLawPenaltyReduction); Validation.SetNullTo(tbPopulationPenaltyReduction);

                        House.InsertInfluence(tbName.Text, tbInfluence.Text, rtbDescription.Text, rtbBenfits.Text, tbWeaGain.Text, tbPowGain.Text, tbPopGain.Text, tbLawGain.Text, tbLanGain.Text, tbInfGain.Text, tbDefGain.Text, tbLawPenaltyReduction.Text, tbPopulationPenaltyReduction.Text);
                        Close();
                        break;
                    case "Influence Improvement":
                        Validation.SetNullTo(tbInfluence);
                        Validation.SetNullTo(tbWeaGain); Validation.SetNullTo(tbPowGain); Validation.SetNullTo(tbPopGain); Validation.SetNullTo(tbLawGain); Validation.SetNullTo(tbLanGain); Validation.SetNullTo(tbInfGain); Validation.SetNullTo(tbDefGain);
                        Validation.SetNullTo(tbLawPenaltyReduction); Validation.SetNullTo(tbPopulationPenaltyReduction);

                        House.InsertInfluenceImprovment(dgHoldings.Rows[cbInfluenceHoldings.SelectedIndex].Cells[0].Value.ToString(), tbName.Text, tbInfluence.Text, rtbDescription.Text, rtbBenfits.Text, tbWeaGain.Text, tbPowGain.Text, tbPopGain.Text, tbLawGain.Text, tbLanGain.Text, tbInfGain.Text, tbDefGain.Text, tbLawPenaltyReduction.Text, tbPopulationPenaltyReduction.Text);
                        Close();
                        break;
                    case "Defense":
                        Validation.SetNullTo(tbDefense);
                        Validation.SetNullTo(tbSpaces);

                        House.InsertDefense(tbName.Text, tbDefense.Text, tbTime.Text, rtbDescription.Text, rtbBenfits.Text, tbSpaces.Text);
                        Close();
                        break;
                    case "Unit Type":
                        Validation.SetNullTo(tbDisciplineModifier); Validation.SetNullTo(tbMovement);
                        Validation.SetNullTo(tbArmorRTG); Validation.SetNullTo(tbArmorRTGUpg); Validation.SetNullTo(tbFightingDamage); Validation.SetNullTo(tbFightingDamageUpg);

                        House.InsertUnitType(tbName.Text, tbPower.Text, tbDisciplineModifier.Text, cbKeyAbilities1.Text, cbKeyAbilities2.Text, cbKeyAbilities3.Text, rtbDescription.Text, tbArmorRTG.Text, tbArmorRTGUpg.Text, tbArmorPenalty.Text, tbArmorPenaltyUpg.Text, tbBulk.Text, tbBulkUpg.Text, tbFightingDamage.Text, tbFightingDamageUpg.Text, tbMarksmanshipDamage.Text, tbMarksmanshipDamageUpg.Text, cblbMarksmanshipRange.Text, tbMovement.Text);
                        Close();
                        break;
                }
            }
            else
            {
                MessageBox.Show("The holding needs a name.");
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
