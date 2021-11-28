using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usermainentance.entities;

namespace Usermainentance
{
    public partial class Form1 : Form
    {
        BindingList<user> users = new BindingList<user>();
        public Form1()
        {
            InitializeComponent();
            label3.Text = Resource1.FullName;
            button1.Text = Resource1.add;
            button2.Text = Resource1.Fajlbairas;
            button3.Text = Resource1.Delete;
            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user u = new user();
            // u.Lastname = textBox1.Text;
            //u.FirstName = textBox2.Text;
            u.FullName = textBox3.Text;
            users.Add(u);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog()==DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    foreach  (user item in users)
                   sw.WriteLine(item.ID + ";" + item.FullName);
                   
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            user valasztott = (user)listBox1.SelectedItem;
            users.Remove(valasztott);
        }
    }
}
