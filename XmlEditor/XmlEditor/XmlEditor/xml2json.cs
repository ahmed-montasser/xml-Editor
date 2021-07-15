using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XmlEditor
{
    public class xml2json
    {
        private string name_return(string x) 
        {
            if (x.IndexOf('<') != x.IndexOf("</"))
            {
                int start = x.IndexOf('<');
                int finish = x.IndexOf('>');
                string name = x.Substring(start + 1, finish - start - 1);
                return name;
            }
            else
            {
                int start = x.IndexOf('<')+1;
                int finish = x.IndexOf('>');
                string name = x.Substring(start + 1, finish - start - 1);
                return name;
            }
        }
        private string tag_return(string x)
        {
            string name="";
            if (x.IndexOf('<') == x.IndexOf("</"))
            {
            }
            else
            {
                int start = x.IndexOf('<');
                int finish = x.IndexOf('>');
                name = "\"" + x.Substring(start + 1, finish - start - 1) + "\":";
            }
            return name;
        }
        private string text_return(string x)
        {
            int start = x.IndexOf('>');
            int finish = x.IndexOf("</");
            string name = "\"" + x.Substring(start + 1, finish - start - 1) + "\"";
            return name;
        }
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
        private string extract_text(string x)
        {
            int start;
            string text="";
            if (x.IndexOf('<') < 500 && x.IndexOf('<') >= 0)
            { start = x.IndexOf('>') + 1; }
            else
            { start = 0; }
            int spaces = 0, first_letter = 0;
            for (int i = 0; start + i < x.Length; i++)
            {
                if (x[start + i] != ' ')
                {
                    first_letter++;
                    if (first_letter == 1) spaces = 0;
                    for (int j = 0; j < spaces; j++)
                    {
                        text += " ";
                    }
                    text += x[start + i];
                    spaces = 0;
                }
                else
                    spaces++;
            }
            return text;
        }
        private bool check_dup(List<string> x,int y,string z) 
        {
            int start = z.IndexOf('<');
            int finish = z.IndexOf('>');
            string mark1, mark2;
            if (start < 500 && start >= 0)
            {
                mark1 = "</" + z.Substring(start + 1, finish - start - 1);
                mark2 = "<" + z.Substring(start + 1, finish - start - 1);
            }
            else
            {
                mark1 = "</" + z;
                mark2 = "<" + z;
            }
            int j=0;
            int i;
            for( i = y; i < x.Count ; i++)
            {
                if (x[i].IndexOf(mark2) < 500 && x[i].IndexOf(mark2) >= 0 && i!=y)
                {
                    j--;
                }
                if (x[i].IndexOf(mark1) < 500 && x[i].IndexOf(mark1) >= 0)
                {
                    j++;
                    if (j==1)
                    break;
                }
            }
            if (j == 1)
            {
                for (int k =i+1; k < x.Count; k++)
                {
                    if (x[k].IndexOf('<') < 500 && x[k].IndexOf('<') >= 0)
                    {
                        if (x[k].IndexOf(mark2) < 500 && x[k].IndexOf(mark2) >= 0)
                        {
                            return true;
                        }
                        else
                            return false;
                    }
                }
            }
            return false;
        }
        private bool check_letters(string x)
        {
            for (int i =0; i < x.Length; i++)
            {
                if (x[i] != ' ')
                {
                    if (x[i] == '<')
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private bool check_short(List<string> x, int y, string z)
        {
            string temp =name_return(z);
            for (int i = y + 1; i < x.Count(); i++)
            {
                if (x[i].IndexOf('<') == x[i].IndexOf("</" + temp))
                    return true;
                else
                    return false;
            }
            return false;
        }
        private bool check_end(string x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != ' ')
                {
                    if (x.Substring(i,2) == "</")
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return true;
        }
        private char check_next(string x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != ' ')
                {
                    return x[i];
                }
            }
            return '^';
        }
        private int count_spaces(string x)
        {
            int i;
            for (i = 0; i < x.Length; i++)
            {
                if (x[i] != ' ')
                    break;
            }
            return i;
        }
        private List<string> pretify(List<string> xml, List<string> json)
        {
            int spaces;
            for (int i = 0; i < xml.Count(); i++)
            {
                spaces = count_spaces(xml[i]);
                for (int j = 0; j < spaces; j++)
                {
                    json[i]=json[i].Insert(0, " ");
                }

                json[i] = json[i].Insert(0, "    ");
            }
            json.Insert(0, "{");
            json.Add("}");
            return json;
        }
        private List<string> operation(List<string> xml)
        {
            int si_text = 0,dup=0,dup_cond=0,dup_p=-1;
            int f=-1;
            List<string> json = new List<string>();
            Stack<string> brackets = new Stack<string>();
            Stack<string> dups = new Stack<string>();
            for (int i = 0; i < xml.Count; i++)
            {
                int temporary = xml[i].IndexOf('<');
                json.Add("");
                if (si_text == 0)
                {
                    if (temporary < 500 && temporary >= 0)
                    {
                        if (temporary == xml[i].IndexOf("</"))
                        {
                            if (brackets.Count == 0)
                            {
                            }
                            else if (brackets.Peek() == name_return(xml[i]))
                            {
                                brackets.Pop();
                                json[i] += " }";
                            }
                        }
                        if (dup == 1)
                        {
                            if (name_return(xml[i]) == dups.Peek() && xml[i].IndexOf('<') != xml[i].IndexOf("</"))
                            {
                                dup--;
                                dup_cond = 1;
                            }
                            else
                                json[i] += tag_return(xml[i]);
                        }
                        else
                            json[i] += tag_return(xml[i]);
                        if (check_dup(xml, i, xml[i]))
                        {
                            if (dups.Count() == 0 || name_return(xml[i]) != dups.Peek())
                            {
                                json[i] += " [";
                                dup++;
                                dups.Push(name_return(xml[i]));
                                dup_p = i;
                            }
                        }
                        for (int m = i + 1; m < xml.Count; m++)
                        {
                            int temp = xml[m].IndexOf('<');
                            if (temp < 500 && temp >= 0)
                            {
                                if (brackets_number(xml[i]) == 2)
                                {
                                    json[i] += text_return(xml[i]);
                                    break;
                                }
                                if (temp != xml[m].IndexOf("</") && (dup != 1 || i == dup_p))
                                {
                                    if (!check_short(xml, i, xml[i]))
                                    {
                                        brackets.Push(name_return(xml[i]));
                                        json[i] += " {";
                                        break;
                                    }
                                }
                            }
                        }
                        if (dup_cond == 1)
                        {
                            dups.Pop();
                            if (check_dup(xml, i, xml[dup_p]))
                            {
                                dup = 1;
                                dups.Push(name_return(xml[dup_p]));
                                if (name_return(xml[dup_p]) == name_return(xml[i]) && xml[i].IndexOf("</") < 500 && xml[i].IndexOf("</") >= 0)
                                    json[i] += ",";
                            }
                            else
                            {
                                dup_cond--;
                                for (f = i; f < xml.Count(); f++)
                                {
                                    string temp3 = "</" + name_return(xml[i]);
                                    if (xml[f].IndexOf(temp3) < 500 && xml[f].IndexOf(temp3) > -1)
                                        break;
                                }
                            }
                        }
                        if (brackets_number(xml[i]) == 2) { }
                        else if (extract_text(xml[i]) != "")
                        {
                            if (check_end(xml[i + 1])) 
                            {
                                json[i] += " \"#text\": ";
                            }
                            json[i] += " \"" + extract_text(xml[i]);
                            for (int var = i + 1; var < xml.Count(); var++)
                            {
                                if (check_letters(xml[var]))
                                {
                                    si_text++;
                                }
                                else if (si_text == 0)
                                { json[i] += "\""; break; }
                                else
                                    break;
                            }
                        }
                        if (i == f)
                        {
                            f = -1;
                            json[i] += "]";
                        }
                    }
                }
                else
                {
                    json[i] += extract_text(xml[i]);
                    si_text--;
                    if (si_text == 0)
                        json[i] += "\"";
                }
            }
            return json;
        }
        public List<string> finalizing(List<string> xml)
        {
            List<string> json = operation(xml);
            for (int i = 0; i < json.Count()-1; i++)
            {
                int last = json[i].Last();
                if (last != ','&&last!= '{'&& last!='[')
                {
                        if (last != '"' || last != '}' || last != ']')
                        {
                            char x = check_next(json[i + 1]);
                            if (x == '"' || x == '{' || x == '[')
                                json[i] += ",";
                        }
                }
            }
            List<string> final_json = pretify(xml,json);
            return final_json;
        }
    }
}
