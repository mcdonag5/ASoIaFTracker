using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class LandsHolForm : Form
    {
        ///// VARIABLES START //////////////////////////////////////////////////////
        //Classes
        DevLog DevLog = new DevLog();
        House House;
        //Forms
        NewLandForm newLandForm;
        NewLandFeatureForm newLandFeatureForm;
        NewDefenseForm newDefenseForm;
        NewWealthForm NewWealthForm;
        NewWealthImprovementForm NewWealthImprovement;

        public int houseID;
        public string currentView = "";
        public int currentIndex;
        public string lastWealthPlace = "";
        public string lastHoldingID = "";
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////
        public void ChangeHolding (string toolStrip)
        {
            DevLog.LogItem("Changing to a " + toolStrip + " Holding");
            switch (currentView)
            {
                case "Land":
                    if (tbName.Text != dgLand.Rows[currentIndex].Cells[4].Value.ToString()|| rtbNotes.Text != dgLand.Rows[currentIndex].Cells[5].Value.ToString())
                    {
                        DevLog.LogItem("Found changes and updating");
                        House.UpdateLandDetails(Convert.ToInt32(dgLand.Rows[currentIndex].Cells[1].Value), tbName.Text, rtbNotes.Text);
                        dgLand.DataSource = House.HouseQry("LandHolding");
                        cbLandHolding.Items[currentIndex] = dgLand.Rows[currentIndex].Cells[9].Value.ToString() + "-" + dgLand.Rows[currentIndex].Cells[4].Value.ToString();
                    }
                    break;
                case "Defense":
                    if(tbName.Text != dgDef.Rows[currentIndex].Cells[3].Value.ToString() || rtbNotes.Text != dgLand.Rows[currentIndex].Cells[5].Value.ToString() || dgDef.Rows[currentIndex].Cells[4].Value.ToString() != chbBuilt.Checked.ToString())
                    {
                        DevLog.LogItem("Found changes and updating");
                        House.UpdateDefenseDetails(dgDef.Rows[currentIndex].Cells[0].Value.ToString(), tbName.Text, rtbNotes.Text, chbBuilt.Checked.ToString());
                        dgDef.DataSource = House.HouseQry("DefenseHolding", dgLand.Rows[cbLandHolding.SelectedIndex].Cells[1].Value.ToString());
                        cbDefLanFea.Items[currentIndex] = dgDef.Rows[currentIndex].Cells[9].Value.ToString() + "-" + dgDef.Rows[currentIndex].Cells[3].Value.ToString();
                    }
                    break;
                case "Feature":
                    if (tbName.Text != dgLandFea.Rows[currentIndex].Cells[3].Value.ToString() || rtbNotes.Text != dgLandFea.Rows[currentIndex].Cells[4].Value.ToString())
                    {
                        DevLog.LogItem("Found changes and updating");
                        House.UpdateLandFeatureDetails(dgLandFea.Rows[currentIndex].Cells[0].Value.ToString(),tbName.Text,rtbNotes.Text);
                        dgLandFea.DataSource = House.HouseQry("LandHoldingCommunity", dgLand.Rows[cbLandHolding.SelectedIndex].Cells[1].Value.ToString());
                        cbDefLanFea.Items[currentIndex+dgDef.RowCount] = dgLandFea.Rows[currentIndex].Cells[6].Value.ToString() + "-" + dgLandFea.Rows[currentIndex].Cells[3].Value.ToString();
                    }
                    break;
                case "Wealth":
                    DevLog.LogItem(dgWea.Rows[currentIndex].Cells[7].Value.ToString() + " = " + chbBuilt.Checked.ToString());
                    if (tbName.Text != dgWea.Rows[currentIndex].Cells[6].Value.ToString()|| rtbNotes.Text != dgWea.Rows[currentIndex].Cells[8].Value.ToString()||dgWea.Rows[currentIndex].Cells[7].Value.ToString() != chbBuilt.Checked.ToString())
                    {
                        DevLog.LogItem("Found changes and updating");
                        House.UpdateWealthDetails(dgWea.Rows[currentIndex].Cells[1].Value.ToString(),tbName.Text,rtbNotes.Text, chbBuilt.Checked.ToString());
                        dgWea.DataSource = House.WealthHolding(lastWealthPlace, lastHoldingID);
                        cbWealthHolding.Items[currentIndex] = dgWea.Rows[currentIndex].Cells[12].Value.ToString() + "-" + dgWea.Rows[currentIndex].Cells[6].Value.ToString();
                    }
                    break;
            }

            currentView = toolStrip;
            lbCost.Text = "";
            lbDesc.Text = "";
            lbBenfits.Text = "";
            lbAddions.Text = "";
            lbImprovemnt.Text = "";
            rtbNotes.Text = "";
            tbName.Text = "";
            chbBuilt.Visible = false;

            int costDef = 0;
            int costLan = 0;
            int costPop = 0;
            int costWea = 0;
            int costPow = 0;
            int costInf = 0;
            switch (toolStrip)
            {
                case "Land":
                    currentIndex = cbLandHolding.SelectedIndex;

                    landFeatureToolStripMenuItem.Enabled = true;
                    defenseHoldingToolStripMenuItem.Enabled = true;
                    wealthHoldingToolStripMenuItem.Enabled = true;
                    wealthImprovementToolStripMenuItem.Enabled = false;

                    lbTypeName.Text = dgLand.Rows[currentIndex].Cells[9].Value.ToString();
                    tbName.Text = dgLand.Rows[currentIndex].Cells[4].Value.ToString();
                    costLan = Convert.ToInt32(dgLand.Rows[currentIndex].Cells[10].Value) - Convert.ToInt32(dgLand.Rows[currentIndex].Cells[6].Value);
                    rtbNotes.Text = dgLand.Rows[currentIndex].Cells[5].Value.ToString();
                    //Land Fea
                    dgImp.DataSource = House.HouseQry("LandHoldingFeature", dgLand.Rows[currentIndex].Cells[1].Value.ToString());
                    for (int n = 0; n < dgImp.RowCount; n++)
                    {
                        costLan += Convert.ToInt32(dgImp.Rows[n].Cells[7].Value);
                        lbAddions.Text += dgImp.Rows[n].Cells[6].Value.ToString() + " - " + dgImp.Rows[n].Cells[3].Value.ToString() + Environment.NewLine;
                    }
                    //Land Fea Towns
                    dgImp.DataSource = House.HouseQry("LandHoldingCommunity", dgLand.Rows[currentIndex].Cells[1].Value.ToString());
                    for (int n = 0; n < dgImp.RowCount; n++)
                    {
                        costLan += Convert.ToInt32(dgImp.Rows[n].Cells[7].Value);
                        lbAddions.Text += dgImp.Rows[n].Cells[6].Value.ToString() + " - " + dgImp.Rows[n].Cells[3].Value.ToString() + Environment.NewLine;
                    }
                    lbType.Text = "Land Holding";

                    UpdateWeaComboBox("LanHol_ID", dgLand.Rows[cbLandHolding.SelectedIndex].Cells[1].Value.ToString());

                    UpdateDefLanFeaComboBox();

                    break;
                case "Defense":
                    currentIndex = cbDefLanFea.SelectedIndex;

                    landFeatureToolStripMenuItem.Enabled = false;
                    defenseHoldingToolStripMenuItem.Enabled = false;
                    wealthHoldingToolStripMenuItem.Enabled = true;
                    wealthImprovementToolStripMenuItem.Enabled = false;

                    lbTypeName.Text = dgDef.Rows[currentIndex].Cells[9].Value.ToString();
                    tbName.Text = dgDef.Rows[currentIndex].Cells[3].Value.ToString();
                    chbBuilt.Visible = true; chbBuilt.Checked = dgDef.Rows[currentIndex].Cells[4].Visible.ToString()=="True" ? true : false;
                    lbType.Text = "Defense Holding";
                    lbDesc.Text = dgDef.Rows[currentIndex].Cells[12].Value.ToString();
                    lbBenfits.Text = "Benfit: " + dgDef.Rows[currentIndex].Cells[13].Value.ToString();
                    rtbNotes.Text = dgDef.Rows[currentIndex].Cells[5].Value.ToString();
                    costDef += Convert.ToInt32(dgDef.Rows[currentIndex].Cells[10].Value);

                    UpdateWeaComboBox("DefHol_ID", dgDef.Rows[currentIndex].Cells[0].Value.ToString());
                    break;
                case "Feature":
                    currentIndex = cbDefLanFea.SelectedIndex - dgDef.RowCount;

                    landFeatureToolStripMenuItem.Enabled = false;
                    defenseHoldingToolStripMenuItem.Enabled = false;
                    wealthHoldingToolStripMenuItem.Enabled = true;
                    wealthImprovementToolStripMenuItem.Enabled = false;

                    lbTypeName.Text = dgLandFea.Rows[currentIndex].Cells[6].Value.ToString();
                    tbName.Text = dgLandFea.Rows[currentIndex].Cells[3].Value.ToString();
                    lbType.Text = "Land Feature Holding";
                    rtbNotes.Text = dgLandFea.Rows[currentIndex].Cells[4].Value.ToString();
                    costLan += Convert.ToInt32(dgLandFea.Rows[currentIndex].Cells[7].Value);
                    costPop += Convert.ToInt32(dgLandFea.Rows[currentIndex].Cells[8].Value);

                    UpdateWeaComboBox("LanHolFea_ID", dgLandFea.Rows[currentIndex].Cells[0].Value.ToString());
                    break;
                case "Wealth":
                    currentIndex = cbWealthHolding.SelectedIndex;

                    landFeatureToolStripMenuItem.Enabled = false;
                    defenseHoldingToolStripMenuItem.Enabled = false;
                    wealthHoldingToolStripMenuItem.Enabled = false;
                    wealthImprovementToolStripMenuItem.Enabled = true;

                    lbTypeName.Text = dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[12].Value.ToString();
                    tbName.Text = dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[6].Value.ToString();
                    lbType.Text = dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[13].Value.ToString() + " Wealth Holdings";
                    DevLog.LogItem(dgWea.Rows[currentIndex].Cells[7].Visible.ToString());
                    chbBuilt.Visible = true; chbBuilt.Checked = dgWea.Rows[currentIndex].Cells[7].Value.ToString() == "True" ? true : false;
                    lbDesc.Text = dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[21].Value.ToString();
                    lbBenfits.Text = "Benfits: " + dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[22].Value.ToString();
                    rtbNotes.Text = dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[8].Value.ToString();

                    costWea += Convert.ToInt32(dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[15].Value);
                    costDef += Convert.ToInt32(dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[16].Value);
                    costLan += Convert.ToInt32(dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[17].Value);
                    costPow += Convert.ToInt32(dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[18].Value);

                    dgImp.DataSource = House.HouseQry("WealthHoldingImprovement", dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[1].Value.ToString());
                    for (int t = 0; t < dgImp.RowCount; t++)
                    {
                        costWea += Convert.ToInt32(dgImp.Rows[t].Cells[10].Value);
                        costDef += Convert.ToInt32(dgImp.Rows[t].Cells[11].Value);
                        costLan += Convert.ToInt32(dgImp.Rows[t].Cells[12].Value);
                        costLan += Convert.ToInt32(dgImp.Rows[t].Cells[13].Value);
                        costInf += Convert.ToInt32(dgImp.Rows[t].Cells[14].Value);
                        lbImprovemnt.Text += dgImp.Rows[t].Cells[8].Value.ToString() + Environment.NewLine + dgImp.Rows[t].Cells[17].Value.ToString() + Environment.NewLine + "Benefit: " + dgImp.Rows[t].Cells[18].Value.ToString() + Environment.NewLine;

                    }
                    break;
                default:
                    landFeatureToolStripMenuItem.Enabled = false;
                    defenseHoldingToolStripMenuItem.Enabled = false;
                    wealthHoldingToolStripMenuItem.Enabled = false;
                    wealthImprovementToolStripMenuItem.Enabled = false;

                    break;
            }
            //Display Cost
            if (costWea > 0) { lbCost.Text += "Wealth: " + costWea + " "; }
            if (costDef > 0) { lbCost.Text += "Defense: " + costDef + " "; }
            if (costPow > 0) { lbCost.Text += "Power: " + costPow + " "; }
            if (costInf > 0) { lbCost.Text += "Influence: " + costInf + " "; }
            if (costLan > 0) { lbCost.Text += "Land: " + costLan + " "; }
            if (costPop > 0) { lbCost.Text += "Population: " + costPop + " "; }

        }
        public void UpdateLandComboBox()
        {
            DevLog.LogItem("Getting land holdings");
            dgLand.DataSource = House.HouseQry("LandHolding");
            object[] landHoldings = new object[dgLand.RowCount];

            for (int i = 0; i < dgLand.RowCount; i++)
            {
                landHoldings[i] = dgLand.Rows[i].Cells[9].Value.ToString() + "-" + dgLand.Rows[i].Cells[4].Value.ToString();
            }
            cbLandHolding.Items.Clear();
            cbLandHolding.Items.AddRange(landHoldings);
            cbDefLanFea.Items.Clear();
            cbWealthHolding.Items.Clear();
        }

        public void UpdateDefLanFeaComboBox()
        {
            dgLandFea.DataSource = House.HouseQry("LandHoldingCommunity", dgLand.Rows[cbLandHolding.SelectedIndex].Cells[1].Value.ToString());
            dgDef.DataSource = House.HouseQry("DefenseHolding", dgLand.Rows[cbLandHolding.SelectedIndex].Cells[1].Value.ToString());
            object[] landFeaDefHoldings = new object[dgLandFea.RowCount + dgDef.RowCount];
            for (int i = 0; i < dgDef.RowCount; i++)
            {
                landFeaDefHoldings[i] = dgDef.Rows[i].Cells[9].Value.ToString() + "-" + dgDef.Rows[i].Cells[3].Value.ToString();
            }
            for (int i = 0; i < dgLandFea.RowCount; i++)
            {
                DevLog.LogItem(dgLandFea.Rows[i].Cells[7].Value.ToString() + "-" + dgLandFea.Rows[i].Cells[3].Value.ToString());
                landFeaDefHoldings[i + dgDef.RowCount] = dgLandFea.Rows[i].Cells[6].Value.ToString() + "-" + dgLandFea.Rows[i].Cells[3].Value.ToString();
            }
            cbDefLanFea.Items.Clear();
            cbDefLanFea.Items.AddRange(landFeaDefHoldings);
        }

        public void UpdateWeaComboBox(string place, string holdingID)
        {
            lastWealthPlace = place;
            lastHoldingID = holdingID;
            dgWea.DataSource = House.WealthHolding(place, holdingID);
            object[] weaHoldings = new object[dgWea.RowCount];
            for (int i = 0; i < dgWea.RowCount; i++)
            {
                weaHoldings[i] = dgWea.Rows[i].Cells[12].Value.ToString() + "-" + dgWea.Rows[i].Cells[6].Value.ToString();
            }
            cbWealthHolding.Items.Clear();
            cbWealthHolding.Items.AddRange(weaHoldings);
        }
        ///// METHODS END //////////////////////////////////////////////////////////
        public LandsHolForm(int houseID, string houseName)
        {
            House = new House(houseID, houseName);
            InitializeComponent();
            Text = House.name + " Land Holdings";
        }

        private void LandsHolForm_Load(object sender, EventArgs e)
        {
            UpdateLandComboBox();
            Visible = true;
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        //Combo boxes
        private void CbLandHolding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeHolding("Land");
        }

        private void CbDefLanFea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDefLanFea.SelectedIndex < dgDef.RowCount)
            {
                ChangeHolding("Defense");
            }
            else
            {
                ChangeHolding("Feature");
            }
        }

        private void CbWealthHolding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeHolding("Wealth");
        }
        //Stripmenu
        private void LandHoldingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeHolding("");
            newLandForm = new NewLandForm(House.ID,House.name);
            newLandForm.FormClosing += new FormClosingEventHandler(LandsHolForm_Load);
            this.Visible = false;
            newLandForm.ShowDialog();
        }

        private void LandFeatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeHolding("");
            newLandFeatureForm = new NewLandFeatureForm(House.ID, House.name, Convert.ToInt32(dgLand.Rows[currentIndex].Cells[1].Value), dgLand.Rows[currentIndex].Cells[9].Value.ToString() + "-" + dgLand.Rows[currentIndex].Cells[4].Value.ToString());
            newLandFeatureForm.FormClosing += new FormClosingEventHandler(LandsHolForm_Load);
            Visible = false;
            newLandFeatureForm.ShowDialog();
        }

        private void DefenseHoldingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeHolding("");
            newDefenseForm = new NewDefenseForm(House.ID,House.name, Convert.ToInt32(dgLand.Rows[currentIndex].Cells[1].Value), dgLand.Rows[currentIndex].Cells[9].Value.ToString() + "-" + dgLand.Rows[currentIndex].Cells[4].Value.ToString());
            newDefenseForm.FormClosing += new FormClosingEventHandler(LandsHolForm_Load);
            Visible = false;
            newDefenseForm.ShowDialog();
        }

        private void WealthHoldingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string place = "";
            string ID = "";
            string placeName = "";
            switch(currentView)
            {
                case "Land":
                    place = "LanHol_ID";
                    ID = dgLand.Rows[currentIndex].Cells[1].Value.ToString();
                    placeName = dgLand.Rows[currentIndex].Cells[9].Value.ToString();
                    if(dgLand.Rows[currentIndex].Cells[4].Value.ToString() != "") { placeName += " - " + dgLand.Rows[currentIndex].Cells[4].Value.ToString(); }
                    break;
                case "Defense":
                    place = "DefHol_ID";
                    ID = dgDef.Rows[currentIndex].Cells[0].Value.ToString();
                    placeName = dgDef.Rows[currentIndex].Cells[9].Value.ToString() + "-" + dgDef.Rows[currentIndex].Cells[3].Value.ToString();
                    if (dgDef.Rows[currentIndex].Cells[3].Value.ToString() != "") { placeName += " - " + dgDef.Rows[currentIndex].Cells[3].Value.ToString(); }
                    break;
                case "Feature":
                    place = "LanHolFea_ID";
                    ID = dgLand.Rows[cbLandHolding.SelectedIndex].Cells[1].Value.ToString();
                    placeName = dgLand.Rows[cbLandHolding.SelectedIndex].Cells[9].Value.ToString();
                    if (dgLand.Rows[currentIndex].Cells[4].Value.ToString() != "") { placeName += " - " + dgLand.Rows[currentIndex].Cells[4].Value.ToString(); }
                    break;
            }
            ChangeHolding("");
            NewWealthForm = new NewWealthForm(House.ID, House.name, place, ID, placeName);
            NewWealthForm.FormClosing += new FormClosingEventHandler(LandsHolForm_Load);
            Visible = false;
            NewWealthForm.ShowDialog();
        }

        private void WealthImprovementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = dgWea.Rows[currentIndex].Cells[12].Value.ToString();
            if(dgWea.Rows[currentIndex].Cells[6].Value.ToString() != "") { name += "-"+dgWea.Rows[currentIndex].Cells[6].Value.ToString(); }
            NewWealthImprovement = new NewWealthImprovementForm(House.ID, House.name, dgWea.Rows[currentIndex].Cells[1].Value.ToString(), dgWea.Rows[currentIndex].Cells[2].Value.ToString(),name);
            NewWealthImprovement.FormClosing += new FormClosingEventHandler(LandsHolForm_Load);
            Visible = false;
            NewWealthImprovement.ShowDialog();
        }
        //Closing
        private void LandsHolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChangeHolding("");
            if (newLandForm != null) { newLandForm.Close(); }
            if (newLandFeatureForm != null) { newLandFeatureForm.Close(); }
            if (newDefenseForm != null) { newDefenseForm.Close(); }
            if (NewWealthForm != null) { NewWealthForm.Close(); }
            if (NewWealthImprovement != null) { NewWealthImprovement.Close(); }
        }






        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
