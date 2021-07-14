using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlEditor
{
    public class HNode
    {

        private string mBinaryWord;
        private bool is_LeftNode;
        private bool is_RightNode;
        private HNode leftNode;
        private HNode parentNode;
        private HNode rightNode;
        private char? ch_Value;
        private int count;

        public HNode()
        {
        }

        public HNode(char characterValue)
        {
            ch_Value = characterValue;
        }

        public HNode(HNode Left, HNode Right)
        {
            leftNode = Left;
            leftNode.parentNode = this;
            leftNode.is_LeftNode = true;

            rightNode = Right;
            rightNode.parentNode = this;
            rightNode.is_RightNode = true;

            count = (leftNode.Count + rightNode.Count);
        }


        public HNode LeftNode
        {
            get
            {
                return leftNode;
            }
        }

        public HNode ParentNode
        {
            get
            {
                return parentNode;
            }
        }

        public HNode RightNode
        {
            get
            {
                return rightNode;
            }
        }

        public char? CharacterValue
        {
            get
            {
                return ch_Value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }

        public string BinaryWord
        {
            get
            {
                string mReturnValue = "";

                if (String.IsNullOrEmpty(mBinaryWord) == true)
                {
                    StringBuilder stringBuilder = new StringBuilder();

                    HNode huffmanNode = this;

                    while (huffmanNode != null)
                    {
                        if (huffmanNode.is_LeftNode == true)
                        {
                            stringBuilder.Insert(0, "0");
                        }

                        if (huffmanNode.is_RightNode == true)
                        {
                            stringBuilder.Insert(0, "1");
                        }

                        huffmanNode = huffmanNode.parentNode;
                    }

                    mReturnValue = stringBuilder.ToString();
                    mBinaryWord = mReturnValue;
                }
                else
                {
                    mReturnValue = mBinaryWord;
                }

                return mReturnValue;
            }
        }

        public override string ToString()
        {
            StringBuilder myStringBuilder = new StringBuilder();

            if (ch_Value.HasValue == true)
            {
                myStringBuilder.AppendFormat("'{0}' ({1}) - {2} ({3})", ch_Value.Value, count, BinaryWord, BinaryWord.BinaryStringToInt32());
            }
            else
            {
                if ((leftNode != null) && (rightNode != null))
                {
                    if ((leftNode.CharacterValue.HasValue == true) && (rightNode.CharacterValue.HasValue == true))
                    {
                        myStringBuilder.AppendFormat("{0} + {1} ({2})", leftNode.CharacterValue, rightNode.CharacterValue, count);
                    }
                    else
                    {
                        myStringBuilder.AppendFormat("{0}, {1} - ({2})", leftNode, rightNode, count);
                    }
                }
                else
                {
                    myStringBuilder.Append(count);
                }
            }

            return myStringBuilder.ToString();
        }
    }
}
