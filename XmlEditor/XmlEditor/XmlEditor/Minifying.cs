using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlEditor
{

    public static class Minifying
    {


        public static string minify(string xmlString)
        {
            Stack<char> xmlStack = new Stack<char>();
            Stack<char> arrows = new Stack<char>();

            char[] xml = xmlString.ToCharArray();
            int xmlStringLength = xml.Length;

            for (int i = xmlStringLength - 1; i >= 0; i--)
            {
                if (xml[i] == '>')
                {
                    if (arrows.Count == 0)
                    {
                        arrows.Push('>');
                        xmlStack.Push('>');
                        
                        continue;
                    }
                    else //error
                    {
                        MessageBox.Show("XML is not consistent", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return null;
                    }
                }
                else if (xml[i] == '<')
                {
                    if (arrows.Count == 1)
                    {
                        arrows.Pop();
                        xmlStack.Push('<');
                        continue;
                    }
                    else //error
                    {
                        MessageBox.Show("XML is not consistent", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }

                if ((xml[i] == '\n' || xml[i] == '\t') )

                { continue; }

                if (xml[i] == ' ' && (xml[i + 1] == '<' || xml[i - 1] == '>'))
                {
                    continue;
                }
                if (xml[i] == ' ' && xml[i + 1] == ' ')
                {
                    continue;
                }

                xmlStack.Push(xml[i]);

            }
            //show_after_minify
            int count = xmlStack.Count;

            string output = "";
            for (int i = 0; i < count; i++)
            {
                output += xmlStack.Peek();
                xmlStack.Pop();
            }

            return output;
            
        }

    }

}
