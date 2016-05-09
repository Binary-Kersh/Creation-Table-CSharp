using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Creation_Table
{
    public partial class AddCol : Form
    {
        public String tabName,userName;
        List<List<string>> list = new List<List<string>>();
        public AddCol(String name,String user,List<List<string>>l)
        {
            tabName = name;
            userName = user;
            list = l;
            InitializeComponent();
        }
        public AddCol()
        {
            InitializeComponent();
        }

        private void AddCol_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Greater_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            
            if (Datatype.GetItemText(Datatype.SelectedItem).ToString()!="Integer "
                &&Datatype.GetItemText(Datatype.SelectedItem).ToString()!="Decimal")
            {
                Greater.Text = "0";
                Smaller.Text = "10000000";
            }
            else if (Datatype.GetItemText(Datatype.SelectedItem).ToString() == "Decimal")
            {
                int c=0,ch=1,cc=0;
                for (int i=0;i<Greater.Text.Length;i++)
                {
                    if (Greater.Text[i] <= '9' && Greater.Text[i] >= '0') { }
                    else if (Greater.Text[i] == '.') c++;
                    else if (Greater.Text[i] == '-') cc++;
                    else ch = 0; 
                }
                if (ch==0||c>1||cc>1) 
                {
                    MessageBox.Show("Please enter only numbers in Constrains.");
                    return;
                }
                else if (cc==1&&Greater.Text[0]!='-')
                {
                    MessageBox.Show("Please enter only numbers in Constrains.");
                    return;
                }
                c = 0;
                ch = 1;
                cc = 0;
                for (int i=0;i<Smaller.Text.Length;i++)
                {
                    if (Smaller.Text[i] <= '9' && Smaller.Text[i] >= '0') { }
                    else if (Smaller.Text[i] == '.') c++;
                    else if (Smaller.Text[i] == '-') cc++;
                    else ch = 0; 
                }
                if (ch==0||c>1||cc>1) 
                {
                    MessageBox.Show("Please enter only numbers in Constrains.");
                    return;
                }
                else if (cc == 1 && Smaller.Text[0] != '-')
                {
                    MessageBox.Show("Please enter only numbers in Constrains.");
                    return;
                }
            }
            else
            {
                bool check = true;
                string great = Greater.Text;
                int cc = 0;
                for (int i = 0; i < great.Length; i++)
                {
                    if (great[i] <= '9' && great[i] >= '0') { }
                    else if (great[i] == '-') cc++;
                    else check = false;
                }
                if (cc > 1) check = false;
                else if (cc == 1 && great[0] != '-') check = false;
                string small = Smaller.Text;
                cc = 0;
                for (int i = 0; i < small.Length; i++)
                {
                    if (small[i] <= '9' && small[i] >= '0') { }
                    else if (small[i] == '-') cc++;
                    else check = false;
                }
                if (cc > 1) check = false;
                else if (cc == 1 && great[0] != '-') check = false;
                if (check == false)
                {
                    MessageBox.Show("Please enter only numbers in Constrains.");
                    return;
                }
            }
            Boolean uniq = false;
            int idx = -1;
            for (int i = 0; i < ColName.Text.Length;i++ )
            {
                if (ColName.Text[i] == ' ')
                {
                    MessageBox.Show("Please don't add Spaces to Column Name.");
                    return;
                }
            }
            readwrite rw = new readwrite(userName);
            rw.read();
            for(int i=0;i<rw.tablename.Count;i++)
            {
                if (rw.tablename[i] == tabName)
                {
                    idx = i;
                    break;
                }
            }
            for(int i=0;i<rw.li[idx].Count;i++)
            {
                MessageBox.Show(rw.li[idx][i][0] + " " + ColName.Text);
                if (rw.li[idx][i][0] == ColName.Text)
                    uniq = true;
            }
            if(uniq==true)
            {
                MessageBox.Show("this column already exist!");
                return;
            }
            if (Datatype.GetItemText(Datatype.SelectedItem).ToString()=="")
            {
                MessageBox.Show("Please choose Data Type to the Column.");
                return;
            }
            if (Primary.Checked==true)
            {
                Null.Checked = false;
            }
            List<string> ll = new List<string>();
            ll.Add(ColName.Text);
            ll.Add(Datatype.GetItemText(Datatype.SelectedItem));
            ll.Add(Null.Checked.ToString());
            ll.Add(Primary.Checked.ToString());
            ll.Add(Greater.Text);
            ll.Add(Smaller.Text);
            list.Add(ll);
            OpenTable t = new OpenTable(list,tabName, userName, ColName.Text, Datatype.GetItemText(Datatype.SelectedItem), Null.Checked, Primary.Checked, Greater.Text, Smaller.Text);
            t.Show();
            this.Close();
        }
    }
}
