using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XmlEditor
{
    class prettify
    {
        private int brackets_number(string x)
        {
            int n = 0, m = 0;
            while (true)
            {
                if (x.IndexOf('<', m) < 500 && x.IndexOf('<', m) >= 0)
                { n++; m = x.IndexOf('<', m) + 1; }
                else
                    return n;
            }
        }
        private List<string> lines(List<string> xml)
        {
            List<string> xml_e = new List<string>();
            for (int i = 0; i < xml.Count(); i++)
            {
                string a = "", b = "";
                string x = xml[i];
                int m;
                for (m = 0; m < x.Length; m++)
                {
                    if (x[m] != ' ')
                    {
                        if (x[m] == '<')
                        {
                            a = x.Substring(m, x.IndexOf('>') - m + 1);
                            b = x.Substring(x.IndexOf('>') + 1, x.Length - x.IndexOf('>') - 1);
                            break;
                        }
                        else
                        {
                            if (x.Contains('<'))
                            {
                                a = x.Substring(m, x.IndexOf('<') - m + 1);
                                b = x.Substring(x.IndexOf('<'), x.Length - x.IndexOf('<') - 1);
                            }
                            else
                            {
                                a = x;
                            }
                            break;
                        }
                    }
                }
                for (int n = 0; n < i; n++)
                {
                    xml_e.Add(xml[n]);
                }
                xml_e.Add(a);
                if (b != "")
                {
                    i++;
                    xml_e.Add(b);
                }
                for (int n = i + 1; n < xml.Count(); n++)
                {
                    xml_e.Add(xml[n]);
                }
                xml.Clear();
                for (int n = 0; n < xml_e.Count(); n++)
                {
                    xml.Add(xml_e[n]);
                }
                xml_e.Clear();
            }
            return xml;
        }
        public List<string> operation2(List<string> xml)
        {
            List<string> xml_e = lines(xml);
            int spaces = 0;
            for (int i = 0; i < xml.Count(); i++)
            {
                if (xml[i].Contains("</"))
                {
                    if (brackets_number(xml[i]) != 2)
                    {
                        spaces--;
                    }
                }
                for (int j = 0; j < spaces; j++)
                { xml[i] = xml[i].Insert(0, "    "); }
                if (xml[i].Contains('<') && !xml[i].Contains("</"))
                {
                    if (brackets_number(xml[i]) != 2)
                    {
                        spaces++;
                    }
                }
                else
                { }
            }
            return xml;
        }
    }
}
