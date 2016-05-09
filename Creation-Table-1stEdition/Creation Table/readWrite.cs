using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Creation_Table
{
    public partial class readwrite
    {
        public string userName;
        public List<List<List<string>>> li;
        public List<string> tablename;
        public readwrite()
        { }
        public readwrite(string name)
        {
            userName = name;
            li = new List<List<List<string>>>();
            tablename = new List<string>();
        }
        public void read()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Users\\" + userName + "\\" + userName + ".xml");
                XmlNodeList nod = doc.GetElementsByTagName("table");
                li.Clear();
                tablename.Clear();
                for (int i = 0; i < nod.Count; i++)
                {
                    XmlNodeList child1 = nod[i].ChildNodes;
                    li.Add(new List<List<string>>());
                    tablename.Add(nod[i].Attributes[0].InnerText);
                    for (int h = 0; h < child1.Count; h++)
                    {
                        XmlNodeList child2 = child1[h].ChildNodes;
                        li[i].Add(new List<string>());
                        for (int k = 0; k < child2.Count; k++)
                        {
                            if (child2[k].Name == "data")
                            {
                                XmlNodeList child3 = child2[k].ChildNodes;
                                for (int e = 0; e < child3.Count; e++)
                                {
                                    li[i][h].Add(child3[e].InnerText);
                                }
                            }
                            else
                                li[i][h].Add(child2[k].InnerText);
                        }
                    }
                }
            }
            catch
            {

            }
        }
        public void write()
        {
            /*li[0].Add(new List<string>());
            for (int i = 0; i < 14;i++ )
                li[0][0].Add("tooooooz"+i);
            li[0].Add(new List<string>());
            for (int i = 0; i < 14;i++ )
                li[0][1].Add("bolll"+i);*/
            XmlWriter wr = XmlWriter.Create("Users\\" + userName + "\\" + userName + ".xml");
            wr.WriteStartDocument();
            wr.WriteStartElement(userName);
            for (int i = 0; i < li.Count; i++)
            {
                wr.WriteStartElement("table");
                wr.WriteAttributeString("name", tablename[i]);
                for (int h = 0; h < li[i].Count; h++)
                {
                    wr.WriteStartElement("columns" + h);
                    wr.WriteElementString("Name", li[i][h][0]);
                    wr.WriteElementString("DataType", li[i][h][1]);
                    wr.WriteElementString("NULL", li[i][h][2]);
                    wr.WriteElementString("Primary", li[i][h][3]);
                    wr.WriteElementString("Greater", li[i][h][4]);
                    wr.WriteElementString("Smaller", li[i][h][5]);
                    wr.WriteStartElement("data");
                    for (int k = 6; k < li[i][h].Count; k++)
                    {
                        /*if (k == 6)
                            MessageBox.Show(li[i][h][k]);*/
                        wr.WriteElementString("row" + (k - 5), li[i][h][k]);
                    }
                    wr.WriteEndElement();
                    wr.WriteEndElement();
                }
                wr.WriteEndElement();
            }
            wr.WriteEndElement();
            wr.Close();
        }
    }
}
