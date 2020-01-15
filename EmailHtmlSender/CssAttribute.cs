using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailHtmlSender
{
    class CssAttribute
    {
        public static string ClassTag = ".";

        public static string IdTag = "#";

        public string Name { get; set; }

        public string Properties { get; set; }

        public CssAttribute(string name, string prop)
        {
            Name = name;
            Properties = prop;
        }
    }
}
