using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailHtmlSender
{
    class CssClass
    {
        public static string Tag = ".";

        public string Name { get; set; }

        public string Properties { get; set; }

        public CssClass(string name, string prop)
        {
            Name = name;
            Properties = prop;
        }
    }
}
