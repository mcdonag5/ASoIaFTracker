using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class CreateNewWealthHolding : Form
    {
        ///// VARIABLES START ///////////////////////////////////////////////////////


        ///// VARIABLES END /////////////////////////////////////////////////////////

        ///// METHODS START /////////////////////////////////////////////////////////


        ///// METHODS END ///////////////////////////////////////////////////////////
        public CreateNewWealthHolding()
        {
            InitializeComponent();
        }

        private void CreateNewWealthHolding_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void CbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbType.Text)
            {
                case "Estate":
                    lbTypeDescription.Text = "Estate Holdings represent concentrated, organized holdings intended to make the most of a domain’s natural resources. These are usually agricultural or husbandry related, although some may involve the harvest of natural resources. Not all domains where such resources are gathered must have these holdings, however. These holdings represent such operations on a scale large enough to influence the fortunes of the master House, generally producing not just enough for those who dwell there, but a surplus that can be sold. In either event, any given domain can have only one estate holding at a time.";
                    break;
                case "Lifestyle":
                    lbTypeDescription.Text = "Lifestyle Wealth Holdings reflect the sorts of luxuries that only the truly wealthy Houses can afford. They often provide improvements to the living conditions in a Community or Defensive Holding. Because these Holdings often build into the main keep or seat, some of them also cost points of Defense—such Holdings can reduce the overall defensibility of a castle, and so resources have to be allocated appropriately to include them.";
                    break;
                case "Personage":
                    lbTypeDescription.Text = "Personage Holdings represent either skilled individuals or small gatherings of such individuals. In general, they require the presence of a Community or Defensive Holding. Unlike with other Holdings, there are no limits on the number of Personage Wealth Holdings that may be purchased in a given domain.";
                    break;
                case "Settlement":
                    lbTypeDescription.Text = "Settlement Holdings require a population of some size in order to be built. Generally speaking, they require either a Community (Hamlet, Town or City) or Defensive Holding (Tower, Hall or Castle) in order to construct. A hamlet or tower may have one such Holding, a small town or hall may have two, a large town or castle may have four and there is no limit to how many larger communities or defensive holdings may have. These limits apply to all Settlement Wealth Holdings save where noted.";
                    break;
            }
        }



        ///// EVENTS END ////////////////////////////////////////////////////////////

    }
}
