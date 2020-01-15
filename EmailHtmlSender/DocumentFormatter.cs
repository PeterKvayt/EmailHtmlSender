using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailHtmlSender
{
    static class DocumentFormatter
    {

        public static string ReplaceAttributes(string htmlDoc, string cssDoc)
        {
            htmlDoc = ReplaceClasses(htmlDoc, cssDoc);
            return ReplaceIds(htmlDoc, cssDoc);
        }

        //replace classes 
        private static string ReplaceClasses(string htmlDoc, string cssDoc)
        {
            List<CssAttribute> classes = FindClasses(cssDoc);

            foreach (CssAttribute item in classes)
            {
                htmlDoc = Replace(htmlDoc, "class=\"" + item.Name + "\"", item.Properties);
            }

            return htmlDoc;
        }

        //replace ids 
        private static string ReplaceIds(string htmlDoc, string cssDoc)
        {
            List<CssAttribute> ids = FindId(cssDoc);

            foreach (CssAttribute item in ids)
            {
                htmlDoc = Replace(htmlDoc, "id=\"" + item.Name + "\"", item.Properties);
            }

            return htmlDoc;
        }

        //pickup classes from .css file
        private static List<CssAttribute> FindClasses(string cssDoc)
        {
            List<CssAttribute> classes = new List<CssAttribute> { };

            for (int i = 0; i < cssDoc.Length; i++)
            {
                string cssClass = "";
                string style = "";

                GetProperties(ref cssClass, ref style, cssDoc, ref i, CssAttribute.ClassTag);

                if (cssClass != "" & style != "")
                {
                    style.Replace("\n", "");
                    style.Trim();

                    classes.Add(new CssAttribute(cssClass, style));
                }
            }

            return classes;
        }

        //pickup ids from .css file
        private static List<CssAttribute> FindId(string cssDoc)
        {
            List<CssAttribute> ids = new List<CssAttribute> { };

            for (int i = 0; i < cssDoc.Length; i++)
            {
                string id = "";
                string style = "";

                GetProperties(ref id, ref style, cssDoc, ref i, CssAttribute.IdTag);

                if (id != "" & style != "")
                {
                    style.Replace("\n", "");
                    style.Trim();

                    ids.Add(new CssAttribute(id, style));
                }
            }

            return ids;
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

            return htmlDoc.Replace(name, style);
        }
    }
}
