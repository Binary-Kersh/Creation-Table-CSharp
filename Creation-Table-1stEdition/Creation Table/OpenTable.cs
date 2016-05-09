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
    public partial class OpenTable : Form
    {
        public string tabName, userName, ColumnName = "", Datatype;
        public Boolean NULL = false, Primary = false, first = false;
        public string great = "0", small = "1000000";
        List<List<string>> tempcol = new List<List<string>>();
        public OpenTable(string name, string user)
        {
            tabName = name;
            userName = user;
            InitializeComponent();
        }
        public OpenTable(List<List<string>> l, string name, string user, string ColName, string DataType, Boolean nuull, Boolean primary, string greater, string smaller)
        {
            first = true;
            tabName = name;
            userName = user;
            ColumnName = ColName;
            Datatype = DataType;
            NULL = nuull;
            Primary = primary;
            great = greater;
            small = smaller;
            tempcol = l;
            //MessageBox.Show("NumofColums: " + tempcol.Count.ToString());
            InitializeComponent();
        }
        public OpenTable()
        {
            InitializeComponent();
        }
        private void OpenTable_Load(object sender, EventArgs e)
        {
            tableFill fill = new tableFill(tabName, userName);
            List<List<StringValue>> list = new List<List<StringValue>>();
            list = fill.currenttable();
            fill.dataGrid_fill(fill.conv(list), fill.colname(list), this);
            if (first == true)
            {
                this.dataGridView1.Columns.Add(ColumnName, ColumnName);
            }
        }
        public List<List<string>> transformcell()
        {
            List<List<string>> list = new List<List<string>>();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                List<string> l = new List<string>();
                int counter = 0;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    try
                    {
                        l.Add(item.Cells[i].Value.ToString());
                    }
                    catch
                    {
                        l.Add("/**********************/$%^&*!@#$%^&$@#!@#123215464" + counter);
                        counter++;
                    }
                }
                list.Add(l);
            }
            return list;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void add_column_Click(object sender, EventArgs e)
        {
            if (tempcol.Count() == 1)
            {
                MessageBox.Show("You have to save the Table first.");
            }
            else
            {
                AddCol x = new AddCol(tabName, userName, tempcol);
                x.Show();
                this.Close();
            }
        }

        private void new_col_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            List<List<string>> data = transformcell();
            readwrite obj = new readwrite(userName);
            obj.read();
            int y = 0;
            for (int i = 0; i < obj.tablename.Count; i++)
            {
                if (obj.tablename[i] == tabName)
                {
                    y = i;
                    if (tempcol.Count != 0)
                        obj.li[i].Add(tempcol[0]);
                    for (int h = 0; h < data.Count; h++)
                    {
                        List<string> x = new List<string>();
                        for (int k = 0; k < 6; k++)
                        {
                            x.Add(obj.li[i][h][k]);
                        }
                        obj.li[i][h] = x;
                        for (int k = 0; k < data[h].Count - 1; k++)
                            obj.li[i][h].Add(data[h][k]);
                    }
                }
            }
            List<List<string>> temp = obj.li[y];
            Boolean ok = true;
            for (int i = 0; i < temp.Count; i++)
            {
                HashSet<string> hset = new HashSet<string>();
                int counterfornull = 0;
                for (int h = 6; h < temp[i].Count; h++)
                {
                    hset.Add(temp[i][h]);
                    if (temp[i][h] == "/**********************/$%^&*!@#$%^&$@#!@#123215464" + counterfornull)
                    {
                        if (temp[i][2] == "False")
                        {
                            ok = false;
                        }
                        temp[i][h] = "";
                        counterfornull++;
                        continue;
                    }
                    if (temp[i][1] == "Integer ")
                    {
                        for (int k = 0; k < temp[i][h].Count(); k++)
                        {
                            if (k == 0 && temp[i][h][k] == '-') ;
                            else if (temp[i][h][k] > '9' || temp[i][h][k] < '0')
                                ok = false;
                        }
                        if (ok == true && temp[i][4] != string.Empty)
                        {
                            y = Int32.Parse(temp[i][h]);
                            int z = Int32.Parse(temp[i][4]);
                            if (y < z)
                                ok = false;
                        }
                        if (ok == true && temp[i][5] != string.Empty)
                        {
                            y = Int32.Parse(temp[i][h]);
                            int z = Int32.Parse(temp[i][5]);
                            if (y > z)
                                ok = false;
                        }
                    }
                    else if (temp[i][1] == "Decimal")
                    {
                        int user8be = 0;
                        for (int k = 0; k < temp[i][h].Count(); k++)
                            if (temp[i][h][k] == '-' && k == 0) ;
                            else if ((temp[i][h][k] > '9' || temp[i][h][k] < '0') && temp[i][h][k] != '.')
                                ok = false;
                            else if (temp[i][h][k] == '.')
                                user8be++;
                        if (user8be > 1)
                            ok = false;
                        if (ok == true && temp[i][4] != string.Empty)
                        {
                            double r = double.Parse(temp[i][h]);
                            double z = double.Parse(temp[i][4]);
                            if (r < z)
                                ok = false;
                        }
                        if (ok == true && temp[i][5] != string.Empty)
                        {
                            double r = double.Parse(temp[i][h]);
                            double z = double.Parse(temp[i][5]);
                            if (r > z)
                                ok = false;
                            //MessageBox.Show(r + " " + z);
                        }
                    }
                    else if (temp[i][1] == "String")
                    {
                        for (int k = 0; k < temp[i][h].Count(); k++)
                            if (temp[i][h][k] == ' ')
                                ok = false;
                    }

                }
                if (temp[i][3] == "True" && hset.Count != temp[i].Count() - 6)
                {
                    ok = false;
                }
            }
            if (ok == true)
            {
                obj.write();
                tempcol.Clear();
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Can not save with errors >_<");
            }
        }

        private void delete_column_Click(object sender, EventArgs e)
        {
            if (tempcol.Count() == 1)
            {
                MessageBox.Show("You have to save the Table first.");
            }
            else
            {
                delCol f = new delCol(userName, tabName);
                f.ShowDialog();
                tableFill fill = new tableFill(tabName, userName);
                List<List<StringValue>> list = new List<List<StringValue>>();
                list = fill.currenttable();
                fill.dataGrid_fill(fill.conv(list), fill.colname(list), this);
            }
        }

        private void delete_row_Click(object sender, EventArgs e)
        {
            if (tempcol.Count() == 1)
            {
                MessageBox.Show("You have to save the Table first.");
            }
            else
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete those columns?", "Deleting columns", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {

                    int selectedRow = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(selectedRow);
                    readwrite obj = new readwrite(userName);
                    obj.read();
                    int idx = -1;
                    for (int i = 0; i < obj.tablename.Count; i++)
                    {
                        if (obj.tablename[i] == tabName)
                            idx = i;
                    }

                    for (int i = 0; i < obj.li[idx].Count; i++)
                    {
                        obj.li[idx][i].RemoveAt(selectedRow + 6);
                    }

                    obj.write();
                }
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            List<List<string>> data = transformcell();
            readwrite obj = new readwrite(userName);
            obj.read();
            int y = 0;
            for (int i = 0; i < obj.tablename.Count; i++)
            {
                if (obj.tablename[i] == tabName)
                {
                    y = i;
                    if (tempcol.Count != 0)
                        obj.li[i].Add(tempcol[0]);
                    for (int h = 0; h < data.Count; h++)
                    {
                        List<string> x = new List<string>();
                        for (int k = 0; k < 6; k++)
                        {
                            x.Add(obj.li[i][h][k]);
                        }
                        obj.li[i][h] = x;
                        for (int k = 0; k < data[h].Count - 1; k++)
                            obj.li[i][h].Add(data[h][k]);
                    }
                }
            }
            List<List<string>> temp = obj.li[y];
            Boolean ok = true;
            int targetcol = e.ColumnIndex, targetrow = e.RowIndex + 6;
            if (temp[targetcol][1] == "Integer ")
            {
                for (int k = 0; k < temp[targetcol][targetrow].Count(); k++)
                {
                    if (k == 0 && temp[targetcol][targetrow][k] == '-') ;
                    else if (temp[targetcol][targetrow][k] > '9' || temp[targetcol][targetrow][k] < '0')
                        ok = false;
                }
                if (ok == true && temp[targetcol][4] != string.Empty)
                {
                    y = Int32.Parse(temp[targetcol][targetrow]);
                    int z = Int32.Parse(temp[targetcol][4]);
                    if (y < z)
                        ok = false;
                }
                if (ok == true && temp[targetcol][5] != string.Empty)
                {
                    y = Int32.Parse(temp[targetcol][targetrow]);
                    int z = Int32.Parse(temp[targetcol][5]);
                    if (y > z)
                        ok = false;
                }
            }
            else if (temp[targetcol][1] == "Decimal")
            {
                int user8be = 0;
                for (int k = 0; k < temp[targetcol][targetrow].Count(); k++)
                    if (temp[targetcol][targetrow][k] == '-' && k == 0) ;
                    else if ((temp[targetcol][targetrow][k] > '9' || temp[targetcol][targetrow][k] < '0') && temp[targetcol][targetrow][k] != '.')
                        ok = false;
                    else if (temp[targetcol][targetrow][k] == '.')
                        user8be++;
                if (user8be > 1)
                    ok = false;
                if (ok == true && temp[targetcol][4] != string.Empty)
                {
                    double r = double.Parse(temp[targetcol][targetrow]);
                    double z = double.Parse(temp[targetcol][4]);
                    if (r < z)
                        ok = false;
                }
                if (ok == true && temp[targetcol][5] != string.Empty)
                {
                    double r = double.Parse(temp[targetcol][targetrow]);
                    double z = double.Parse(temp[targetcol][5]);
                    if (r > z)
                        ok = false;
                    //MessageBox.Show(r + " " + z);
                }
            }
            else if (temp[targetcol][1] == "String")
            {
                for (int k = 0; k < temp[targetcol][targetrow].Count(); k++)
                    if (temp[targetcol][targetrow][k] == ' ')
                        ok = false;
            }
            if (ok == false)
            {
                dataGridView1.CurrentCell.ErrorText = "Invalid Data";
            }
           
        }
    }

}