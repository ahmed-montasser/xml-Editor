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
        public List<string> operation2(List<string> xml)
        {
            int spaces=0;
            for(int i=0;i<xml.Count();i++)
            {
                if (xml[i].Contains("</"))
                {
                    if (brackets_number(xml[i]) != 2)
                    {
                        spaces--;
                    }
                }
                for(int j=0;j<spaces;j++)
                {xml[i]=xml[i].Insert(0,"    ");}
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
