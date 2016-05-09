using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Creation_Table
{
    public partial class Form2 : Form
    {
        public string userName;
        public readwrite rw;
        public Form2(string name)
        {
            userName = name;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rw = new readwrite(userName);
            rw.read();
            for (int i = 0; i < rw.tablename.Count; i++)
                checkedListBox1.Items.Add(rw.tablename[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete those tables?", "Deleting tables", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                List<int> ls = new List<int>();
                for (int i = 0; i < rw.tablename.Count; i++)
                {
                    foreach (string s in checkedListBox1.CheckedItems)
                    {
                        if (s == rw.tablename[i])
                        {
                            ls.Add(i);
                            break;
                        }
                    }
                }
                int idx = 0;
                List<List<List<string>>> newli = new List<List<List<string>>>();
                for (int i = 0; i < rw.li.Count; i++)
                {
                    if (idx < ls.Count && ls[idx] == i)
                    {
                        idx++;
                    }
                    else
                    {
                        newli.Add(rw.li[i]);
                    }
                }
                rw.li = newli;
                rw.write();
                MessageBox.Show("Tables deleted successfully");
                this.Close();
            }
        }
    }
}
