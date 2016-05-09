using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace Creation_Table
{
    class tableFill
    {
        string tablen;
        readwrite tmp;
        public tableFill() { }
        public tableFill(string tname,string usern)
        {
            tablen = tname;
            tmp = new readwrite(usern);
        }
        public List<List<StringValue>> currenttable()
        {
            tmp.read();
            int idx = -1;
            for(int i=0;i<tmp.tablename.Count;i++)
            {
                if (tmp.tablename[i] == tablen)
                {
                    idx = i;
                    break;
                }
            }
            List<List<StringValue>> x = new List<List<StringValue>>();
            for(int i=0;i<tmp.li[idx].Count;i++)
            {
                List<StringValue> lst = new List<StringValue>();
                for(int j=0;j<tmp.li[idx][i].Count;j++)
                {
                    StringValue y = new StringValue(tmp.li[idx][i][j]);
                    lst.Add(y);
                }
                x.Add(lst);
            }
            return x;
        }

        public void dataGrid_fill(List<List<StringValue>> dataList,List<String> coln, OpenTable tables )
        {
            tables.dataGridView1.Columns.Clear();
            //MessageBox.Show("tableSize " + dataList.Count + " / " + "colNames" + coln.Count);
            int NoCol =(int) coln.Count;
            MessageBox.Show(coln.Count.ToString());
            for(int i=0;i<coln.Count;i++)
            {
                tables.dataGridView1.Columns.Add(coln[i], coln[i]);
            }
            //dataList = conv(dataList);
            foreach (List<StringValue> s in dataList)
            {
                string[] s1= new string[s.Count];
                for (int i = 0; i < s.Count; i++)
                    s1[i] = s[i].Value;

                //MessageBox.Show("size" + s.Count);
                tables.dataGridView1.Rows.Add(s1);

            }
        }
        /**********************************/
        public List<List<StringValue>> conv(List<List<StringValue>>old)
        {
            List<List<StringValue>> nw = new List<List<StringValue>>();
            if (old.Count > 0)
            {
                for (int i = 6; i < old[0].Count; i++)
                {
                    List<StringValue> tmp = new List<StringValue>();
                    for (int j = 0; j < old.Count; j++)
                    {
                        tmp.Add(old[j][i]);
                    }
                    nw.Add(tmp);
                }
            }
            
            return nw;
        }
        public List<string>colname(List<List<StringValue>>curli)
        {
            List<string> ans = new List<string>();
            for(int i=0;i<curli.Count;i++)
            {
                ans.Add(curli[i][0].Value);
            }
            return ans;
        }
        /**********************************/
        public void userTables(List<string> list,tablelist tables)
        {
            List<StringValue> lst = new List<StringValue>();
            for(int i=0;i<list.Count;i++)
            {
                StringValue x = new StringValue(list[i]);
                lst.Add(x);
            }
            tables.table.DataSource = lst;
            tables.table.Columns[0].HeaderText = "Tables";
        }
    }
}
