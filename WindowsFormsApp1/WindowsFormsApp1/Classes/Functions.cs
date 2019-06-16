using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Functions
    {
        public string HoldingName(string type,string name)
        {
            if(name != "") { type += " - " + name; }
            return type;
        }
    }
}
