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
using System.Xml;

namespace Creation_Table
{
    public partial class tablelist : Form
    {
        public string userName;
        public tablelist(string name)
        { 
            userName = name;
            InitializeComponent();
        }
        public tablelist()
        {
        }
        private void fillTable()
        {
            readwrite tables = new readwrite(userName);
            tables.read();
            tableFill fill = new tableFill();
            fill.userTables(tables.tablename, this);
        }
        private void tablelist_Load(object sender, EventArgs e)
        {
            fillTable();
        }

        private void del_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(userName);
            f.ShowDialog();
            this.table.Columns.Clear();
            fillTable();
        }
        private void add_Click(object sender, EventArgs e)
        {
            this.Hide();
            newtable temp = new newtable(userName);
            temp.ShowDialog();
        }
        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.table.Columns.Add("da", "ok");
            var send = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                OpenTable t = new OpenTable(table.SelectedCells[0].Value.ToString(), userName);
                t.ShowDialog();
            }
        }
    }
    
}
