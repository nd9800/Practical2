using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2.Models
{
    class InfoItem
    {
        public InfoItem(string name, string passw)
        {
            this.name = name;
            this.passw = passw;
        }
        public string name { get; set; }
        public string passw { get; set; }
    }
}
