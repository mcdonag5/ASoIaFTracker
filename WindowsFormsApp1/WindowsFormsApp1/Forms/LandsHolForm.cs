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
        public string holdingType = "";
        public string currentView = "";
        public int currentIndex;
        public string lastWealthPlace = "";
        public string lastHoldingID = "";

        int[] costs;
        public bool dorne;
        int nextMaleCost = 20;
        int nextFemaleCost = 10;
        //Arrays
        Label[] addType;
        TextBox[] addName;
        CheckBox[] addBulit;
        Button[] addDelete;
        Label[] addDesc;

        String[] influenceComboBox1 = new string[] { "Influence", "Heir" };
        //Classes
        DevLog DevLog = new DevLog();
        House House;
        //Forms
        NewLandForm newLandForm;
        NewLandFeatureForm newLandFeatureForm;
        NewDefenseForm newDefenseForm;
        NewWealthForm NewWealthForm;
        NewWealthImprovementForm NewWealthImprovement;
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////
        public void ChangeHolding (string type,string holding)
        {
            DevLog.LogItem("Changing to "+ type +": " + holding + " Holding");
            //check for changes to save
            switch (holdingType)
            {
                //All Land Holding Form
                case "Land":
                    switch (currentView)
                    {
                        case "Land":
                            if (tbName.Text != dgLand.Rows[currentIndex].Cells[4].Value.ToString() || rtbNotes.Text != dgLand.Rows[currentIndex].Cells[5].Value.ToString())
                            {
                                DevLog.LogItem("Found changes and updating Land");
                                House.UpdateLandDetails(Convert.ToInt32(dgLand.Rows[currentIndex].Cells[1].Value), tbName.Text, rtbNotes.Text);
                                dgLand.DataSource = House.HouseQry("LandHolding");
                                cb1.Items[currentIndex] = dgLand.Rows[currentIndex].Cells[9].Value.ToString() + "-" + dgLand.Rows[currentIndex].Cells[4].Value.ToString();
                            }
                            for (int i = 0; i < addType.Length && i < dgImp.RowCount; i++)
                            {
                                if (addName[i].Text != dgImp.Rows[i].Cells[3].Value.ToString())
                                {
                                    DevLog.LogItem("Found changes and updating Land Feature: " + i);
                                    House.UpdateLandFeatureDetails(dgImp.Rows[i].Cells[0].Value.ToString(), addName[i].Text);
                                }
                            }
                            break;
                        case "Defense":
                            if (tbName.Text != dgDef.Rows[currentIndex].Cells[3].Value.ToString() || rtbNotes.Text != dgLand.Rows[currentIndex].Cells[5].Value.ToString() || dgDef.Rows[currentIndex].Cells[4].Value.ToString() != chbBuilt.Checked.ToString())
                            {
                                DevLog.LogItem("Found changes and updating Defense");
                                House.UpdateDefenseDetails(dgDef.Rows[currentIndex].Cells[0].Value.ToString(), tbName.Text, rtbNotes.Text, chbBuilt.Checked.ToString());
                                dgDef.DataSource = House.HouseQry("DefenseHolding", dgLand.Rows[cb1.SelectedIndex].Cells[1].Value.ToString());
                                cb2.Items[currentIndex] = dgDef.Rows[currentIndex].Cells[9].Value.ToString() + "-" + dgDef.Rows[currentIndex].Cells[3].Value.ToString();
                            }
                            break;
                        case "Feature":
                            if (tbName.Text != dgLandFea.Rows[currentIndex].Cells[3].Value.ToString() || rtbNotes.Text != dgLandFea.Rows[currentIndex].Cells[4].Value.ToString())
                            {
                                DevLog.LogItem("Found changes and updating Feature");
                                House.UpdateLandFeatureDetails(dgLandFea.Rows[currentIndex].Cells[0].Value.ToString(), tbName.Text, rtbNotes.Text);
                                dgLandFea.DataSource = House.HouseQry("LandHoldingCommunity", dgLand.Rows[cb1.SelectedIndex].Cells[1].Value.ToString());
                                cb2.Items[currentIndex + dgDef.RowCount] = dgLandFea.Rows[currentIndex].Cells[6].Value.ToString() + "-" + dgLandFea.Rows[currentIndex].Cells[3].Value.ToString();
                            }
                            break;
                        case "Wealth":
                            DevLog.LogItem(dgWea.Rows[currentIndex].Cells[7].Value.ToString() + " = " + chbBuilt.Checked.ToString());
                            if (tbName.Text != dgWea.Rows[currentIndex].Cells[6].Value.ToString() || rtbNotes.Text != dgWea.Rows[currentIndex].Cells[8].Value.ToString() || dgWea.Rows[currentIndex].Cells[7].Value.ToString() != chbBuilt.Checked.ToString())
                            {
                                DevLog.LogItem("Found changes and updating Wealth Holding");
                                House.UpdateWealthDetails(dgWea.Rows[currentIndex].Cells[1].Value.ToString(), tbName.Text, rtbNotes.Text, chbBuilt.Checked.ToString());
                                dgWea.DataSource = House.WealthHolding(lastWealthPlace, lastHoldingID);
                                cb3.Items[currentIndex] = dgWea.Rows[currentIndex].Cells[12].Value.ToString() + "-" + dgWea.Rows[currentIndex].Cells[6].Value.ToString();
                            }
                            for (int i = 0; i < addType.Length && i < dgImp.RowCount; i++)
                            {
                                if (addBulit[i].Checked.ToString() != dgImp.Rows[i].Cells[4].Value.ToString())
                                {
                                    DevLog.LogItem("Found changes and updating Wealth Holding Imp: " + i);
                                    House.UpdateWealthImprovementDetails(dgImp.Rows[i].Cells[1].Value.ToString(), addBulit[i].Checked.ToString());
                                }
                            }
                            break;
                    }
                    break;
                //Influence Holdings
                case "Influence":
                    switch (currentView)
                    {
                        case "Influence":
                            if(tbName.Text != dgInfluence.Rows[currentIndex].Cells[4].Value.ToString() || rtbNotes.Text != dgInfluence.Rows[currentIndex].Cells[6].Value.ToString())
                            {
                                DevLog.LogItem("Found change: updating");
                                House.UpdateInfluenceHoldings(dgInfluence.Rows[currentIndex].Cells[1].Value.ToString(), tbName.Text, rtbNotes.Text);
                                dgInfluence.DataSource = House.HouseQry("InfluenceHoldings");
                                cb2.Items[currentIndex] = dgHeir.Rows[currentIndex].Cells[2].Value.ToString();
                            }
                            break;
                        case "Heir":
                            if (tbName.Text != dgHeir.Rows[currentIndex].Cells[2].Value.ToString() || rtbNotes.Text != dgHeir.Rows[currentIndex].Cells[4].Value.ToString())
                            {
                                DevLog.LogItem("Found change: updating");
                                House.UpdateHeir(dgHeir.Rows[currentIndex].Cells[0].Value.ToString(), tbName.Text, rtbNotes.Text);
                                dgHeir.DataSource = House.HouseQry("Heir");
                                cb2.Items[currentIndex] = dgHeir.Rows[currentIndex].Cells[2].Value.ToString();
                            }
                            break;
                    }
                    break;
            }
            //change layout if holding type changed
            if(holdingType != type)
            {
                holdingType = type;
                switch (holdingType)
                {
                    case "Land":
                        tsddbNewLand.Visible = true;
                        tsddbNewInf.Visible = false;

                        cb3.Visible = true;
                        
                        UpdateLandComboBox();
                        break;
                    case "Influence":
                        tsddbNewLand.Visible = false;
                        tsddbNewInf.Visible = true;

                        cb3.Visible = false;

                        cb1.Items.Clear();
                        cb1.Items.AddRange(influenceComboBox1);
                        cb1.SelectedIndex = 0;
                        break;
                }

                Text = House.name + " "+holdingType+" Holdings";
            }

            currentView = holding;
           
            //clear form
            lbTypeName.Text = "";
            lbCost.Text = "";
            chbBuilt.Visible = false;
            lbType.Text = "";
            lbDesc.Text = "";
            lbBenfits.Text = "";
            rtbNotes.Text = "";
            tbName.Text = "";
            for (int i = 0; i < addType.Length; i++)
            {
                addType[i].Visible = addName[i].Visible = addDelete[i].Visible = addBulit[i].Visible = addDesc[i].Visible = false;
            }
            
            int costDef = 0;
            int costLan = 0;
            int costPop = 0;
            int costWea = 0;
            int costPow = 0;
            int costInf = 0;

            //Load new holding
            switch (holdingType)
            {
                //All Land Holding Form
                case "Land":
                    switch (currentView)
                    {
                        case "Land":
                            currentIndex = cb1.SelectedIndex;

                            tsbDeleteCurrent.Enabled = true;
                            landFeatureToolStripMenuItem.Enabled = true;
                            defenseHoldingToolStripMenuItem.Enabled = true;
                            wealthHoldingToolStripMenuItem.Enabled = true;
                            wealthImprovementToolStripMenuItem.Enabled = false;

                            lbTypeName.Text = dgLand.Rows[currentIndex].Cells[9].Value.ToString();
                            tbName.Text = dgLand.Rows[currentIndex].Cells[4].Value.ToString();
                            costLan = Convert.ToInt32(dgLand.Rows[currentIndex].Cells[10].Value) - Convert.ToInt32(dgLand.Rows[currentIndex].Cells[6].Value);
                            rtbNotes.Text = dgLand.Rows[currentIndex].Cells[5].Value.ToString();

                            dgImp.DataSource = House.HouseQry("LandHoldingFeature", dgLand.Rows[currentIndex].Cells[1].Value.ToString());
                            for (int i = 0; i < addType.Length && i < dgImp.RowCount; i++)
                            {
                                addType[i].Visible = addName[i].Visible = addDelete[i].Visible = true;

                                costLan += Convert.ToInt32(dgImp.Rows[i].Cells[7].Value);
                                addType[i].Text = dgImp.Rows[i].Cells[6].Value.ToString();
                                addName[i].Text = dgImp.Rows[i].Cells[3].Value.ToString();
                            }

                            lbType.Text = "Land Holding";

                            UpdateWeaComboBox("LanHol_ID", dgLand.Rows[cb1.SelectedIndex].Cells[1].Value.ToString());

                            UpdateDefLanFeaComboBox();

                            break;
                        case "Defense":
                            currentIndex = cb2.SelectedIndex;

                            tsbDeleteCurrent.Enabled = true;
                            landFeatureToolStripMenuItem.Enabled = false;
                            defenseHoldingToolStripMenuItem.Enabled = false;
                            wealthHoldingToolStripMenuItem.Enabled = true;
                            wealthImprovementToolStripMenuItem.Enabled = false;

                            lbTypeName.Text = dgDef.Rows[currentIndex].Cells[9].Value.ToString();
                            tbName.Text = dgDef.Rows[currentIndex].Cells[3].Value.ToString();
                            chbBuilt.Visible = true; chbBuilt.Checked = dgDef.Rows[currentIndex].Cells[4].Visible.ToString() == "True" ? true : false;
                            lbType.Text = "Defense Holding";
                            lbDesc.Text = dgDef.Rows[currentIndex].Cells[12].Value.ToString();
                            lbBenfits.Text = "Benfit: " + dgDef.Rows[currentIndex].Cells[13].Value.ToString();
                            rtbNotes.Text = dgDef.Rows[currentIndex].Cells[5].Value.ToString();
                            costDef += Convert.ToInt32(dgDef.Rows[currentIndex].Cells[10].Value);

                            UpdateWeaComboBox("DefHol_ID", dgDef.Rows[currentIndex].Cells[0].Value.ToString());
                            break;
                        case "Feature":
                            currentIndex = cb2.SelectedIndex - dgDef.RowCount;

                            tsbDeleteCurrent.Enabled = true;
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
                            currentIndex = cb3.SelectedIndex;

                            tsbDeleteCurrent.Enabled = true;
                            landFeatureToolStripMenuItem.Enabled = false;
                            defenseHoldingToolStripMenuItem.Enabled = false;
                            wealthHoldingToolStripMenuItem.Enabled = false;
                            wealthImprovementToolStripMenuItem.Enabled = true;

                            lbTypeName.Text = dgWea.Rows[cb3.SelectedIndex].Cells[12].Value.ToString();
                            tbName.Text = dgWea.Rows[cb3.SelectedIndex].Cells[6].Value.ToString();
                            lbType.Text = dgWea.Rows[cb3.SelectedIndex].Cells[13].Value.ToString() + " Wealth Holdings";
                            DevLog.LogItem(dgWea.Rows[currentIndex].Cells[7].Visible.ToString());
                            chbBuilt.Visible = true; chbBuilt.Checked = dgWea.Rows[currentIndex].Cells[7].Value.ToString() == "True" ? true : false;
                            lbDesc.Text = dgWea.Rows[cb3.SelectedIndex].Cells[21].Value.ToString();
                            lbBenfits.Text = Environment.NewLine + dgWea.Rows[cb3.SelectedIndex].Cells[22].Value.ToString() + Environment.NewLine;
                            rtbNotes.Text = dgWea.Rows[cb3.SelectedIndex].Cells[8].Value.ToString();

                            costWea += Convert.ToInt32(dgWea.Rows[cb3.SelectedIndex].Cells[15].Value);
                            costDef += Convert.ToInt32(dgWea.Rows[cb3.SelectedIndex].Cells[16].Value);
                            costLan += Convert.ToInt32(dgWea.Rows[cb3.SelectedIndex].Cells[17].Value);
                            costPow += Convert.ToInt32(dgWea.Rows[cb3.SelectedIndex].Cells[18].Value);

                            dgImp.DataSource = House.HouseQry("WealthHoldingImprovement", dgWea.Rows[cb3.SelectedIndex].Cells[1].Value.ToString());
                            for (int i = 0; i < addType.Length && i < dgImp.RowCount; i++)
                            {
                                costWea += Convert.ToInt32(dgImp.Rows[i].Cells[10].Value);
                                costDef += Convert.ToInt32(dgImp.Rows[i].Cells[11].Value);
                                costLan += Convert.ToInt32(dgImp.Rows[i].Cells[12].Value);
                                costLan += Convert.ToInt32(dgImp.Rows[i].Cells[13].Value);
                                costInf += Convert.ToInt32(dgImp.Rows[i].Cells[14].Value);

                                addType[i].Visible = addBulit[i].Visible = addDelete[i].Visible = addDesc[i].Visible = true;

                                addBulit[i].Checked = dgImp.Rows[i].Cells[4].Value.ToString() == "True" ? true : false;
                                addType[i].Text = dgImp.Rows[i].Cells[8].Value.ToString();
                                addDesc[i].Text = dgImp.Rows[i].Cells[17].Value.ToString() + Environment.NewLine + Environment.NewLine + dgImp.Rows[i].Cells[18].Value.ToString() + Environment.NewLine;
                            }
                            break;
                        default:
                            landFeatureToolStripMenuItem.Enabled = false;
                            defenseHoldingToolStripMenuItem.Enabled = false;
                            wealthHoldingToolStripMenuItem.Enabled = false;
                            wealthImprovementToolStripMenuItem.Enabled = false;

                            tsbDeleteCurrent.Enabled = false;
                            break;
                    }
                    break;
                //Influence Holdings
                case "Influence":
                    switch (currentView)
                    {
                        case "Influence":
                            tsbDeleteCurrent.Enabled = true;
                            infImpprovmentToolStripMenuItem.Enabled = true;
                            currentIndex = cb2.SelectedIndex;

                            currentIndex = cb2.SelectedIndex;

                            lbTypeName.Text = dgInfluence.Rows[currentIndex].Cells[10].Value.ToString();
                            costInf = Convert.ToInt32(dgInfluence.Rows[currentIndex].Cells[11].Value) - Convert.ToInt32(dgInfluence.Rows[currentIndex].Cells[7].Value);
                            tbName.Text = dgInfluence.Rows[currentIndex].Cells[4].Value.ToString();
                            lbDesc.Text = dgInfluence.Rows[currentIndex].Cells[12].Value.ToString();
                            lbBenfits.Text = Environment.NewLine + Environment.NewLine + "Benfit: " + dgInfluence.Rows[currentIndex].Cells[13].Value.ToString();
                            rtbNotes.Text = dgInfluence.Rows[currentIndex].Cells[6].Value.ToString();
                            dgInflImp.DataSource = House.HouseQry("InfluenceHolding", dgInfluence.Rows[currentIndex].Cells[1].Value.ToString());
                            for (int i = 0; i < addType.Length && i < dgInflImp.RowCount; i++)
                            {
                                costInf += Convert.ToInt32(dgInflImp.Rows[i].Cells[8].Value) - Convert.ToInt32(dgInflImp.Rows[i].Cells[4].Value);

                                addType[i].Visible = addDelete[i].Visible = addDesc[i].Visible = true;
                                
                                addType[i].Text = dgInflImp.Rows[i].Cells[7].Value.ToString();
                                addDesc[i].Text = dgInflImp.Rows[i].Cells[9].Value.ToString() + Environment.NewLine + Environment.NewLine + "Benfit: " + dgInflImp.Rows[i].Cells[10].Value.ToString() + Environment.NewLine;
                            }

                            break;
                        case "Heir":
                            tsbDeleteCurrent.Enabled = true;
                            infImpprovmentToolStripMenuItem.Enabled = false;
                            currentIndex = cb2.SelectedIndex;

                            string gender = dgHeir.Rows[currentIndex].Cells[3].Value.ToString() == "M" ? "Male" : "Female";
                            lbTypeName.Text = gender + " Heir";
                            costInf += costs[currentIndex];
                            tbName.Text = dgHeir.Rows[currentIndex].Cells[2].Value.ToString();
                            rtbNotes.Text = dgHeir.Rows[currentIndex].Cells[4].Value.ToString();
                            break;
                        default:
                            tsbDeleteCurrent.Enabled = false;
                            infImpprovmentToolStripMenuItem.Enabled = false;
                            break;
                    }
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
        //Update Land ComboBox
        public void UpdateLandComboBox()
        {
            DevLog.LogItem("Getting land holdings");
            dgLand.DataSource = House.HouseQry("LandHolding");
            object[] landHoldings = new object[dgLand.RowCount];

            for (int i = 0; i < dgLand.RowCount; i++)
            {
                landHoldings[i] = dgLand.Rows[i].Cells[9].Value.ToString() + "-" + dgLand.Rows[i].Cells[4].Value.ToString();
            }
            cb1.Items.Clear();
            cb1.Items.AddRange(landHoldings);
            cb2.Items.Clear();
            cb3.Items.Clear();
        }

        public void UpdateDefLanFeaComboBox()
        {
            dgLandFea.DataSource = House.HouseQry("LandHoldingCommunity", dgLand.Rows[cb1.SelectedIndex].Cells[1].Value.ToString());
            dgDef.DataSource = House.HouseQry("DefenseHolding", dgLand.Rows[cb1.SelectedIndex].Cells[1].Value.ToString());
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
            cb2.Items.Clear();
            cb2.Items.AddRange(landFeaDefHoldings);
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
            cb3.Items.Clear();
            cb3.Items.AddRange(weaHoldings);
        }
        //Update Influence ComboBox
        public void UpdateInfComboBox()
        {
            dgInfluence.DataSource = House.HouseQry("InfluenceHoldings");
            if (dgInfluence.RowCount > 0)
            {
                object[] influence = new object[dgInfluence.RowCount];
                for (int i = 0; i < dgInfluence.RowCount; i++)
                {
                    influence[i] = dgInfluence.Rows[i].Cells[10].Value.ToString() + "-" + dgInfluence.Rows[i].Cells[4].Value.ToString();
                }
                cb2.Items.Clear();
                cb2.Items.AddRange(influence);
            }
        }

        public void UpdateHeirComboBox()
        {
            dgHeir.DataSource = House.HouseQry("Heir");
            DevLog.LogItem("dgHeir.RowCount = " + dgHeir.RowCount);
            object[] heirs = new object[dgHeir.RowCount];
            for (int i = 0; i < dgHeir.RowCount; i++)
            {
                heirs[i] = dgHeir.Rows[i].Cells[2].Value.ToString();
            }
            cb2.Items.Clear();
            cb2.Items.AddRange(heirs);
        }

        //Delete
        public void DeleteFeature(int feaNum)
        {
            switch(currentView)
            {
                case "Land":
                    House.DeleteLandFeature(dgImp.Rows[feaNum].Cells[0].Value.ToString());
                    break;
                case "Wealth":
                    House.DeleteWealthImprovement(dgImp.Rows[feaNum].Cells[1].Value.ToString());
                    break;
            }
            ChangeHolding(holdingType,currentView);
        }
        ///// METHODS END //////////////////////////////////////////////////////////
        public LandsHolForm(int houseID, string houseName, string openingHoldingType, string realm)
        {
            House = new House(houseID, houseName);
            dorne = realm == "Dorne" ? true : false;
            InitializeComponent();

            addType = new Label[] { lbAddType1,lbAddType2,lbAddType3, lbAddType4, lbAddType5 };
            addName = new TextBox[] { tbAddName1,tbAddName2,tbAddName3,tbAddName4,tbAddName5};
            addBulit = new CheckBox[] { chbAddBuilt1,chbAddBuilt2,chbAddBuilt3,chbAddBuilt4,chbAddBuilt5};
            addDelete = new Button[] { btAddDelete1, btAddDelete2, btAddDelete3, btAddDelete4, btAddDelete5 };
            addDesc = new Label[] { lbAddDesc1, lbAddDesc2, lbAddDesc3, lbAddDesc4, lbAddDesc5 };

            ChangeHolding(openingHoldingType, "");
        }

        private void LandsHolForm_Load(object sender, EventArgs e)
        {
            dgHeir.DataSource = House.HouseQry("Heir");
            if (dgHeir.RowCount > 0)
            {
                costs = new int[dgHeir.RowCount];
                int male = 0;
                int female = 0;
                for (int i = 0; i < dgHeir.RowCount; i++)
                {
                    if (dgHeir.Rows[i].Cells[3].Value.ToString() == "M" || dorne)
                    {
                        male++;
                        switch (male)
                        {
                            case 1:
                                costs[i] = 20;
                                nextMaleCost = 10;
                                break;
                            case 2:
                                costs[i] = 10;
                                nextMaleCost = 5;
                                break;
                            default:
                                costs[i] = 5;
                                break;
                        }
                    }
                    else
                    {
                        female++;
                        switch (female)
                        {
                            case 1:
                                costs[i] = 10;
                                nextFemaleCost = 5;
                                break;
                            default:
                                costs[i] = 5;
                                break;
                        }
                    }
                }
            }
                ChangeHolding(holdingType, "");
            if (Visible == false) { Visible = true; }
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        //Combo boxes
        private void CbLandHolding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb1.SelectedIndex != -1)
            {
                switch (holdingType)
                {
                    case "Land":
                        ChangeHolding(holdingType, "Land");
                        break;
                    case "Influence":
                        ChangeHolding(holdingType, "");
                        switch (cb1.Text)
                        {
                            case "Influence":
                                UpdateInfComboBox();
                                break;
                            case "Heir":
                                UpdateHeirComboBox();
                                break;
                        }
                        break;
                }
            }
        }

        private void CbDefLanFea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb2.SelectedIndex != -1)
            {
                switch (holdingType)
                {
                    case "Land":
                        if (cb2.SelectedIndex < dgDef.RowCount)
                        {
                            ChangeHolding("Land", "Defense");
                        }
                        else
                        {
                            ChangeHolding("Land", "Feature");
                        }
                        break;
                    case "Influence":
                        ChangeHolding("Influence", cb1.Text);
                        break;
                }
            }
                
            
        }

        private void CbWealthHolding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb3.SelectedIndex != -1)
            {
                ChangeHolding("Land", "Wealth");
            }
        }
        //Stripmenu
        private void LandHoldingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeHolding("Land", "");
            newLandForm = new NewLandForm(House.ID,House.name);
            newLandForm.FormClosing += new FormClosingEventHandler(LandsHolForm_Load);
            this.Visible = false;
            newLandForm.ShowDialog();
        }

        private void LandFeatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeHolding("Land", "");
            newLandFeatureForm = new NewLandFeatureForm(House.ID, House.name, Convert.ToInt32(dgLand.Rows[currentIndex].Cells[1].Value), dgLand.Rows[currentIndex].Cells[9].Value.ToString() + "-" + dgLand.Rows[currentIndex].Cells[4].Value.ToString());
            newLandFeatureForm.FormClosing += new FormClosingEventHandler(LandsHolForm_Load);
            Visible = false;
            newLandFeatureForm.ShowDialog();
        }

        private void DefenseHoldingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeHolding("Land", "");
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
                    ID = dgLand.Rows[cb1.SelectedIndex].Cells[1].Value.ToString();
                    placeName = dgLand.Rows[cb1.SelectedIndex].Cells[9].Value.ToString();
                    if (dgLand.Rows[currentIndex].Cells[4].Value.ToString() != "") { placeName += " - " + dgLand.Rows[currentIndex].Cells[4].Value.ToString(); }
                    break;
            }
            ChangeHolding("Land", "");
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
            ChangeHolding("","");
            if (newLandForm != null) { newLandForm.Close(); }
            if (newLandFeatureForm != null) { newLandFeatureForm.Close(); }
            if (newDefenseForm != null) { newDefenseForm.Close(); }
            if (NewWealthForm != null) { NewWealthForm.Close(); }
            if (NewWealthImprovement != null) { NewWealthImprovement.Close(); }
        }

        private void btAddDelete1_Click(object sender, EventArgs e)
        {
            DeleteFeature(0);
        }

        private void btAddDelete2_Click(object sender, EventArgs e)
        {
            DeleteFeature(1);
        }

        private void btAddDelete3_Click(object sender, EventArgs e)
        {
            DeleteFeature(2);
        }

        private void btAddDelete4_Click(object sender, EventArgs e)
        {
            DeleteFeature(3);
        }

        private void btAddDelete5_Click(object sender, EventArgs e)
        {
            DeleteFeature(4);
        }

        private void tsbDeleteCurrent_Click(object sender, EventArgs e)
        {
            switch(currentView)
            {
                case "Land":

                    break;
                case "Defense":

                    break;
                case "Feature":

                    break;
                case "Wealth":

                    break;
                case "Influence":

                    break;
                case "Heir":
                    int x = Convert.ToInt32(dgHeir.Rows[currentIndex].Cells[0].Value);
                    DevLog.LogItem("Show yes no messagebox");
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove " + dgHeir.Rows[currentIndex].Cells[2].Value.ToString() + ". ID: " + x + ".", "Delete Heir", MessageBoxButtons.YesNo);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            DevLog.LogItem("Clicked yes on messagebox");
                            House.DeleteHeir(x);
                            cb1.SelectedIndex = -1;
                            cb1.SelectedIndex = 1;
                            Visible = true;
                            break;
                        case DialogResult.No:
                            DevLog.LogItem("Clicked no on messagebox");
                            break;
                    }
                    break;
            }
        }

        private void toolStripMenuIViewLand_Click(object sender, EventArgs e)
        {
            ChangeHolding("Land", "");
        }

        private void toolStripMenuViewInf_Click(object sender, EventArgs e)
        {
            ChangeHolding("Influence", "");
        }


        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
