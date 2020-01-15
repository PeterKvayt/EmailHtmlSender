using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailHtmlSender
{
    class DocumentFormatter
    {
        public static List<CssClass> ReplaceClasses(string htmlDoc, string cssDoc)
        {
            List<CssClass> classes = new List<CssClass> { };

            for (int i = 0; i < cssDoc.Length; i++)
            {
                string cssClass = "";
                string style = "";

                GetProperties(ref cssClass, ref style, cssDoc, ref i, CssClass.Tag);

                classes.Add(new CssClass(cssClass, style));

                //if (cssDoc[i].ToString() == ".")
                //{
                //    string cssClass = "";
                //    string style = "";
                //    i++;

                //    while (cssDoc[i].ToString() != "{")
                //    {
                //        cssClass += cssDoc[i].ToString();
                //        i++;
                //    }
                //    i++;
                //    while (cssDoc[i].ToString() != "}")
                //    {
                //        style += cssDoc[i].ToString();
                //        i++;
                //    }

                //    classes.Add(new CssClass(cssClass, style));
                //}
            }

            return classes;
        }

        private static void GetProperties(ref string name, ref string prop, string doc, ref int i, string tag)
        {
            //List<T> tempClasses = new List<T> { };

            //for (int i = 0; i < doc.Length; i++)
            //{
                //doc.Replace("\n", "");
                
                if (doc[i].ToString() == tag)
                {
                //string cssClass = "";

                    //prop = "";
                    //name = "";
                    i++;

                    while (doc[i].ToString() != "{")
                    {
                        //cssClass += doc[i].ToString();
                        name += doc[i].ToString();
                        i++;
                    }
                    i++;
                    while (doc[i].ToString() != "}")
                    {
                        //style += doc[i].ToString();
                        prop += doc[i].ToString();
                        i++;
                    }
                    int a = 10; 
                    //tempClasses.Add(new T(cssClass, style));
                }
            //}
        }
    }
}
