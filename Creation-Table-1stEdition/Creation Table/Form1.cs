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
namespace Creation_Table
{
    public partial class wlc : Form
    {
        public wlc()
        {
            InitializeComponent();
            Directory.CreateDirectory("Users");
        }

        private void sign_Click(object sender, EventArgs e)
        {
            if (user.Text==""||pass.Text=="")
            {
                MessageBox.Show("Invalid User Name or Password.","Invalid Data"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (Directory.Exists("Users\\"+user.Text))
                {
                    MessageBox.Show("Username is already used.", "Invalid User Name"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(sign_up_user());
                tablelist tab = new tablelist(user.Text);
                Hide();
                tab.ShowDialog();
                this.Close();
            }

            
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("Users\\"+user.Text))
            {
               
                if (checkPass())
                {
                    MessageBox.Show("login successfully.");
                    tablelist tab = new tablelist(user.Text);
                    Hide();
                    tab.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Password.","Login Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    pass.Clear();
                    return;
                }
            }
            MessageBox.Show("User not found.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void wlc_Load(object sender, EventArgs e)
        {

        }
        private string sign_up_user()
        {
            Directory.CreateDirectory("Users\\" + user.Text);
            XmlWriter de = XmlWriter.Create("Users\\" + user.Text + "\\" + user.Text + ".xml");
            de.Close();
            XmlWriter file= XmlWriter.Create("Users\\" + user.Text + "\\password.xml");
            file.WriteStartDocument();
            file.WriteStartElement("Password");
            file.WriteString(pass.Text.ToString());
            file.WriteEndElement();
            file.WriteEndDocument();
            file.Close();
            return "Registration success";
        }
        private bool checkPass()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Users\\" + user.Text + "\\password.xml");
            XmlNodeList node = doc.GetElementsByTagName("Password");
            return ((string)node[0].InnerText == pass.Text);

        }
    }
}
