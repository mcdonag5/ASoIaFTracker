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
    public partial class ChangeResourcesForm : Form
    {
        ///// VARIABLES START ////////////////////////////////////////////////////// 
        DbConn mysqlConn = new DbConn();
        DevLog DevLog = new DevLog();
        House House = new House();
        public int houseID;
        int[] HouseFortunesArry = 
            {-3,-3,-3,-2,-1,-3,1,-1,1,-2,-1,
            1,3,-1,2,1,-2,-1,2,-2,2,
            1,1,-2,1,1,2,2,3,-2,2,
            1,1,1,1,2,3,1,1,1,1,
            1,3};

        public ChangeResourcesForm(int ID)
        {
            houseID = ID;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (tbRoll.Text != "" && Convert.ToInt32(tbRoll.Text) >= 0)
            {
                int x = 0;
                if (Convert.ToInt32(tbRoll.Text) < HouseFortunesArry.Length-1)
                {
                    x = HouseFortunesArry[Convert.ToInt32(tbRoll.Text)];
                } else
                {
                    x = HouseFortunesArry[HouseFortunesArry.Length-1];
                }
                string fortune = "";
                switch(x)
                {
                    case -3:
                        fortune = "Disaster";
                        break;
                    case -2:
                        fortune = "Curse";
                        break;
                    case -1:
                        fortune = "Decline";
                        break;
                    case 1:
                        fortune = "Growth";
                        break;
                    case 2:
                        fortune = "Blessing";
                        break;
                    case 3:
                        fortune = "Boon";
                        break;
                }
                cbFortune.Text = fortune;
            }
            else
            {

                lbFortuneText.Text = "";
            }
        }

        private void cbRealm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fortuneText = "";
            switch (cbFortune.Text)
            {
                case "Disaster":
                    fortuneText = "A Disaster is an event of catastrophic proportions and sets the house back in a significant way. Examples include the outbreak of plague, the disfavor of a lord or king, the disgrace of a staunch ally, widespread lawlessness, or a combination of any of these dire events. Disaster reduces a single resource by 1–6 points or two resources by 1–3 points.";
                    break;
                case "Curse":
                    fortuneText = "A Curse is an unfortunate downturn in events that could weaken the house in some way. Curses are significant setbacks, and they can include brigands, bad weather, blights, desertion, lawlessness, and other effects. A Curse reduces one resource by 1–3 points or two resources by 1 point.";
                    break;
                case "Decline":
                    fortuneText = "When Decline results, it reflects a diminishing of one or more of the house’s resources. Decline reveals a shift in the house’s fortunes, such as the loss of land, the weakening of defenses, an outbreak of sickness, and other minor but unfortunate developments. Decline should reduce one resource by 1 point.";
                    break;
                case "Growth":
                    fortuneText = "A Growth result reflects the improvement of one or more of the house’s resources. It might result in a gift of land, a sudden swell in population, an upturn in the economy, and so on. Growth should improve one resource by 1 point.";
                    break;
                case "Blessing":
                    fortuneText = "A Blessing is a minor benefit, an upturn in events that improves the house in some way. Blessings might be useful alliances, receiving an invitation to participate in a notable tournament, a visit from a powerful lord, and so on. Blessings improve one resource by 1–3 points or two resources by 1 point each.";
                    break;
                case "Boon":
                    fortuneText = "A Boon is a fortune of considerable benefit and value to the house. Its occurrence might signify favor from a lord or the king, a windfall, a beneficial alliance, a business opportunity, or a profitable marriage. A boon should always improve one of a house’s resources by 1–6 points or two of a house’s resources by 1–3 points.";
                    break;
            }
            lbFortuneText.Text = fortuneText;
        }
    }
}
