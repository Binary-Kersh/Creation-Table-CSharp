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
using System.Xml.Serialization;

namespace Creation_Table
{
    [Serializable]
    public partial class newtable : Form
    {
        public String userName;
        public newtable(String name)
        {
            userName = name;
            InitializeComponent();
        }
        public newtable()
        {
            InitializeComponent();
        }

        private void newtable_Load(object sender, EventArgs e)
        {
            
        }
        private void create_Click(object sender, EventArgs e)
        {
            readwrite opj = new readwrite(userName);
            opj.read();
            Boolean uniq = false;
            for (int i=0;i<opj.tablename.Count;i++)
            {
                if (tname.Text==opj.tablename[i])
                {
                    uniq = true;
                }
            }
            if (uniq == true)
                MessageBox.Show("Table already exist.");
            else
            {
                this.Hide();
                opj.tablename.Add(tname.Text);
                List<List<string>> list = new List<List<string>>();
                opj.li.Add(list);
                opj.write();
                tablelist t = new tablelist(userName);
                t.ShowDialog();
            }
        }
    }
}
