﻿using System;
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

namespace WindowsFormsApp1.Forms
{
    public partial class NewLandFeatureForm : Form
    {
        ///// VARIABLES START //////////////////////////////////////////////////////
        DevLog DevLog = new DevLog();
        House House;
        string landID;
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////

        ///// METHODS END //////////////////////////////////////////////////////////
        public NewLandFeatureForm(int ID, int holdingID, string landName)
        {
            House = new House(ID);
            landID = holdingID.ToString();
            InitializeComponent();

            lbName.Text = landName;

            dgLandFeature.DataSource = House.HouseQry("LandFeature");
            object[] landFeature = new object[dgLandFeature.RowCount];
            string item;
            for (int i = 0; i < dgLandFeature.RowCount; i++)
            {
                item = dgLandFeature.Rows[i].Cells[1].Value.ToString() + " - Land: " + dgLandFeature.Rows[i].Cells[2].Value.ToString();
                if(Convert.ToInt32(dgLandFeature.Rows[i].Cells[3].Value)>0) { item += " Pop: " + Convert.ToInt32(dgLandFeature.Rows[i].Cells[3].Value.ToString()); }
                landFeature[i] = item;
            }
            cbLandFeature.Items.Clear();
            cbLandFeature.Items.AddRange(landFeature);
            cbLandFeature.SelectedIndex = 0;

        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void cbLandFeature_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbNote.Enabled = Convert.ToInt32(dgLandFeature.Rows[cbLandFeature.SelectedIndex].Cells[4].Value) > 0 ? true : false;
        }

        private void btBuy_Click(object sender, EventArgs e)
        {
            string notes = "";
            if(Convert.ToInt32(dgLandFeature.Rows[cbLandFeature.SelectedIndex].Cells[4].Value) > 0) { notes = rtbNote.Text; }
            House.InsertLandFeatureHolding(dgLandFeature.Rows[cbLandFeature.SelectedIndex].Cells[0].Value.ToString(), landID, tbName.Text, "");
        }

        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
