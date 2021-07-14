using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlEditor
{
    public class HAlgo
    {
        private HNode root_HNode;
        private List<HNode> value_HNode;

        private List<HNode> build_BinaryTree(string Value)
        {
            List<HNode> HNodes = get_InitialNodeList();

            Value.ToList().ForEach(a => HNodes[a].Count++);

            HNodes = HNodes
                .Where(a => (a.Count > 0))
                .OrderBy(a => (a.Count))
                .ThenBy(a => (a.CharacterValue))
                .ToList();

            HNodes = update_NodeParents(HNodes);

            root_HNode = HNodes[0];
            HNodes.Clear();

            sort_Nodes(root_HNode, HNodes);

            return HNodes;
        }

        public void Compress(string fileName, string savefileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);

            if (fileInfo.Exists == true)
            {
                string fileContents = "";

                using (StreamReader theStreamReader = new StreamReader(File.OpenRead(fileName)))
                {
                    fileContents = theStreamReader.ReadToEnd();
                }

                List<HNode> HNodes = build_BinaryTree(fileContents);

                value_HNode = HNodes
                    .Where(a => (a.CharacterValue.HasValue == true))
                    .OrderBy(a => (a.BinaryWord))
                    .ToList();


                Dictionary<char, string> char2BinaryWordDictionary = new Dictionary<char, string>();
                string y = ")";
                foreach (HNode HNode in value_HNode)
                {
                    y = y + "(" + HNode.CharacterValue.Value + "-" + HNode.BinaryWord + ")";
                    char2BinaryWordDictionary.Add(HNode.CharacterValue.Value, HNode.BinaryWord);
                }

                y = y + "(";
              //  MessageBox.Show(y);
                StringBuilder stringBuilder = new StringBuilder();
                List<byte> byteList = new List<byte>();
                for (int i = 0; i < fileContents.Length; i++)
                {
                    string word = "";


                    stringBuilder.Append(char2BinaryWordDictionary[fileContents[i]]);

                    while (stringBuilder.Length >= 8)
                    {
                        word = stringBuilder.ToString().Substring(0, 8);

                        stringBuilder.Remove(0, word.Length);
                    }

                    if (String.IsNullOrEmpty(word) == false)
                    {
                        byteList.Add(Convert.ToByte(word, 2));
                    }
                }

                if (stringBuilder.Length > 0)
                {
                    string word = stringBuilder.ToString();

                    if (String.IsNullOrEmpty(word) == false)
                    {
                        byteList.Add(Convert.ToByte(word, 2));
                    }
                }

                string compressedFileName = Path.Combine(savefileName, String.Format("{0}.compressed", savefileName));
                if (File.Exists(compressedFileName) == true)
                {
                    File.Delete(compressedFileName);
                }

                using (FileStream fileStream = File.OpenWrite(compressedFileName))
                {
                    fileStream.Write(byteList.ToArray(), 0, byteList.Count);
                }

                StreamWriter outputtxt = new StreamWriter(compressedFileName + "_HuffMann.txt");
                outputtxt.Write(y);
                outputtxt.Close();
            }
        }

        public string Decompress(string fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);
            FileInfo hfileInfo = new FileInfo(fileName + "_HuffMann.txt");
            if (fileInfo.Exists && hfileInfo.Exists)
            {

                string compressedFileName = String.Format("{0}.compressed", fileInfo.FullName.Replace(fileInfo.Extension, ""));

                byte[] buffer = null;
                using (FileStream fileStream = File.OpenRead(compressedFileName))
                {
                    buffer = new byte[fileStream.Length];
                    fileStream.Read(buffer, 0, buffer.Length);
                }
                string y = "";
                using (StreamReader sr = new StreamReader(compressedFileName + "_HuffMann.txt"))
                {

                    y = sr.ReadToEnd();
                    sr.Close();

                }
               
                List<char> ch = new List<char>();
                List<string> st = new List<string>();
                String e = "";
                for (int i=0; i<y.Length; i++)
                {
                    
                    if (i < y.Length-2) {
                        if (y[i] == ')' && y[i + 1] == '(')
                        {
                            e = y.Substring(i+2, y.IndexOf(")(", i + 2) - (i + 2));
                            if (e[0] != '\n' && e[0] != ' ')
                            {
                                ch.Add(e[0]);
                                st.Add(e.Substring(2));
                            }
                            else if (e[0] == '\n')
                            {
                                ch.Add(e[0]);
                                st.Add("n" + e.Substring(2));
                               
                            }
                            else if (e[0] == ' ')
                            {
                                ch.Add(e[0]);
                                st.Add("s" + e.Substring(2));
                            }
                            
                            i += (e.Length+1);
                        } }
                    else
                    {
                        ;
                    }
                }


                string binaryWord2 = "";
                string entry = "";
                bool isFound = false;
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < buffer.Length; i++)
                {
                    string binaryWord = "";
                    byte aByte = buffer[i];

                    if (aByte == 0)
                    {
                        binaryWord = st[0];
                    }
                    else
                    {
                        binaryWord = Convert.ToString(aByte, 2);
                    }

                    if ((binaryWord.Length < 8) && (i < (buffer.Length - 1)))
                    {
                        StringBuilder binary_StringBuilder = new StringBuilder(binaryWord);
                        while (binary_StringBuilder.Length < 8)
                        {
                            binary_StringBuilder.Insert(0, "0");
                        }

                        binaryWord = binary_StringBuilder.ToString();
                    }
                    int dictionaryCounts = st.Count;

                    for (int u = 0;  u<binaryWord.Length ; u++)//optimization
                    {
                        binaryWord2 += binaryWord[u];

                        for (int j = 0; j < dictionaryCounts; j++)
                        {
                            entry = st[j];
                            if (entry.Equals(binaryWord2) && entry[0] != 's' && entry[0] != 'n')
                            {
                                stringBuilder.Append(ch[j]);
                                binaryWord2 = "";
                                break;
                            }
                            else if (entry[0] == 's')
                            {
                                entry = entry.Substring(1);
                                if (entry.Equals(binaryWord2))
                                {
                                    stringBuilder.Append(' ');
                                    binaryWord2 = "";
                                    break;
                                }
                            }
                            else if (entry[0] == 'n')
                            {
                                entry = entry.Substring(1);
                                if (entry.Equals(binaryWord2))
                                {
                                    stringBuilder.Append('\n');
                                    binaryWord2 = "";
                                    break;
                                }
                            }
                        }
                    }
                }

                string uncompressedFileName = Path.Combine(fileInfo.Directory.FullName, String.Format("{0}.uncompressed.xml", fileInfo.Name.Replace(fileInfo.Extension, "")));

                if (File.Exists(uncompressedFileName) == true)
                {
                    File.Delete(uncompressedFileName);
                }
                string s = "";
                using (StreamWriter streamWriter = new StreamWriter(File.OpenWrite(uncompressedFileName)))
                {
                    s = stringBuilder.ToString();
                    streamWriter.Write(stringBuilder.ToString());
                }
                return s;
            }
            else
            {
                MessageBox.Show("Check Compression File and Huffman Code File exist", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Check Compression File and Huffman Code File exist";
            }
        }

        private static List<HNode> get_InitialNodeList()
        {
            List<HNode> get_InitialNodeList = new List<HNode>();

            for (int i = Char.MinValue; i < Char.MaxValue; i++)
            {
                get_InitialNodeList.Add(new HNode((char)(i)));
            }

            return get_InitialNodeList;
        }

        private static void sort_Nodes(HNode Node, List<HNode> Nodes) //Recursive
        {
            if (Nodes.Contains(Node) == false)
            {
                Nodes.Add(Node);
            }

            if (Node.LeftNode != null)
            {
                sort_Nodes(Node.LeftNode, Nodes);
            }

            if (Node.RightNode != null)
            {
                sort_Nodes(Node.RightNode, Nodes);
            }
        }

        private static List<HNode> update_NodeParents(List<HNode> Nodes)
        {
            while (Nodes.Count > 1)
            {
                int iOperations = (Nodes.Count / 2);
                for (int iOperation = 0, i = 0, j = 1; iOperation < iOperations; iOperation++, i += 2, j += 2)
                {
                    if (j < Nodes.Count)
                    {
                        HNode parent_HNode = new HNode(Nodes[i], Nodes[j]);
                        Nodes.Add(parent_HNode);

                        Nodes[i] = null;
                        Nodes[j] = null;
                    }
                }

                Nodes = Nodes
                    .Where(m => (m != null))
                    .OrderBy(m => (m.Count))   //  Choose the lowest weightings first
                    .ToList();
            }

            return Nodes;
        }
    }
}
