using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailHtmlSender
{
    class DocumentFormatter
    {
        public static void ReplaceClasses(string htmlDoc, string cssDoc)
        {
            List<CssClass> classes = new List<CssClass> { };

            for (int i = 0; i < cssDoc.Length; i++)
            {
                if (cssDoc[i].ToString() == ".")
                {
                    string cssClass = "";
                    string style = "";
                    i++;

                    while (cssDoc[i].ToString() != "{")
                    {
                        cssClass += cssDoc[i].ToString();
                        i++;
                    }
                    i++;
                    while (cssDoc[i].ToString() != "}")
                    {
                        style += cssDoc[i].ToString();
                        i++;
                    }

                    CssClass htmlClass = new CssClass(cssClass, style);
                }
            }
        }
    }
}
