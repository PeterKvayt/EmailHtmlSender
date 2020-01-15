using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailHtmlSender
{
    class DocumentFormatter
    {
        public static string ReplaceClasses(string htmlDoc, string cssDoc)
        {
            List<CssClass> classes = FindClasses(cssDoc);

            foreach (CssClass item in classes)
            {
                htmlDoc = Replace(htmlDoc, "class=\"" + item.Name + "\"", item.Properties);
            }

            return htmlDoc;
        }

        //pickup classes from .css file
        private static List<CssClass> FindClasses(string cssDoc)
        {
            List<CssClass> classes = new List<CssClass> { };

            for (int i = 0; i < cssDoc.Length; i++)
            {
                string cssClass = "";
                string style = "";

                GetProperties(ref cssClass, ref style, cssDoc, ref i, CssClass.Tag);

                if (cssClass != "" & style != "")
                {
                    style.Replace("\n", "");
                    style.Trim();

                    classes.Add(new CssClass(cssClass, style));
                }
            }

            return classes;
        }

        //return name and properties
        private static void GetProperties(ref string name, ref string prop, string doc, ref int i, string tag)
        {
            if (doc[i].ToString() == tag)
            {
                i++;

                while (doc[i].ToString() != "{")
                {
                    name += doc[i].ToString();
                    i++;
                }
                i++;
                while (doc[i].ToString() != "}")
                {
                    prop += doc[i].ToString();
                    i++;
                }
            }
        }

        //replace on style attribute
        private static string Replace(string htmlDoc, string name, string style)
        {
            style = "style=\"" + style + "\"";

            //string result = regex.Replace(htmlDoc, style);
            return htmlDoc.Replace(name, style);
        }
    }
}
