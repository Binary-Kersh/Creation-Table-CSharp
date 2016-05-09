using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Creation_Table
{
    public partial class delCol : Form
    {
        public string usern, tablen;
        public int idx;
        public readwrite rw;
        public delCol(string user,string tname)
        {
            InitializeComponent();
            tablen = tname;
            usern = user;
            rw = new readwrite(usern);
            rw.read();
            idx = -1;
            for(int i=0;i<rw.tablename.Count;i++)
            {
                if(tablen==rw.tablename[i])
                {
                    idx = i;
                }
            }
        }

        private void delCol_Load(object sender, EventArgs e)
        {
            for(int i=0;i<rw.li[idx].Count;i++)
            {
                colList.Items.Add(rw.li[idx][i][0]);
            }
        }

        private void colDel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete those columns?", "Deleting columns", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                List<List<List<string>>> newli = new List<List<List<string>>>();
                for (int i = 0; i < rw.li.Count; i++)
                {
                    if (i == idx)
                    {
                        List<List<string>> tmp = new List<List<string>>();
                        for (int j = 0; j < rw.li[i].Count; j++)
                        {
                            Boolean flag = false;
                            foreach (string s in colList.CheckedItems)
                            {
                                if (s == rw.li[i][j][0])
                                    flag = true;
                            }
                            if (!flag)
                            {
                                tmp.Add(rw.li[i][j]);
                            }
                        }
                        newli.Add(tmp);
                    }
                    else
                    {
                        newli.Add(rw.li[i]);
                    }
                }
                rw.li = newli;
                rw.write();
                MessageBox.Show("Columns Deleted successfully");
                this.Close();
            }
        }
    }

}
