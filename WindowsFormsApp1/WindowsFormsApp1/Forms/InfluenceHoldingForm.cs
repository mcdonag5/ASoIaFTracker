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
    public partial class InfluenceHoldingForm : Form
    {

        ///// VARIABLES START //////////////////////////////////////////////////////
        
        //Classes
        DevLog DevLog = new DevLog();
        House House;
        //Forms

        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////

        ///// METHODS END //////////////////////////////////////////////////////////
        public InfluenceHoldingForm(int houseID, string houseName)
        {
            House = new House(houseID, houseName);

            InitializeComponent();

            Name = House.name + " Influence Holdings";
        }

        private void InfluenceHoldingForm_Load(object sender, EventArgs e)
        {
            if (Visible == false) { Visible = true; }
            DevLog.LogItem("Getting Heir details");
            dgInfluence.DataSource = House.HouseQry("Heir");
            if (dgInfluence.RowCount > 0)
            {
                object[] influence = new object[dgInfluence.RowCount];
                for (int i = 0; i < dgInfluence.RowCount; i++)
                {
                    influence[i] = dgInfluence.Rows[i].Cells[2].Value.ToString();
                }
                cbInfluence.Items.Clear();
                cbInfluence.Items.AddRange(influence);
                cbInfluence.SelectedIndex = 0;
            }

        }
        ///// EVENTS START //////////////////////////////////////////////////////////

        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
