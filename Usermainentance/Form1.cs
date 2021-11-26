using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            label1.Text = Resource1.LastName;
            label2.Text = Resource1.FirstName;
            button1.Text = Resource1.add;

            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user u = new user();
            u.Lastname = textBox1.Text;
            u.FirstName = textBox2.Text;
            users.Add(u);
        }
    }
}
