using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailHtmlSender
{
    class HtmlClass
    {
        public string Name { get; set; }

        public string Properties { get; set; }

        public HtmlClass(string name, string prop)
        {
            Name = name;
            Properties = prop;
        }
    }
}
