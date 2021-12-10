using programtervezesimintak.Abstractions;
using programtervezesimintak.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programtervezesimintak
{
    public partial class Form1 : Form
    {
        List<Toy>_toys= new List<Toy>();
        Toy _nextToy;


        private IToyfactory toyFactory;

        public IToyfactory Factory
        {
            get { return toyFactory; }
            set { 
                toyFactory = value;
                Displaynext();
            }
        }

        private void Displaynext()
        {
            if (_nextToy != null) Controls.Remove(_nextToy);
            _nextToy = Factory.CreateNew();
            _nextToy.Top = label1.Top + label1.Height + 20;
            _nextToy.Left = label1.Left;
            Controls.Add(_nextToy);
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new Carfactory();
        }

        private void Createtimer_Tick(object sender, EventArgs e)
        {
            Toy b = Factory.CreateNew();
            _toys.Add(b);
            b.Left = -b.Width;
            mainpanel.Controls.Add(b);
        }

        private void Conveyort_Tick(object sender, EventArgs e)
        {
            if (_toys.Count == 0) return;

            Toy lasttoy = _toys[0];
            
            foreach (Toy item in _toys)
            {
                item.MoveToy();
                if (item.Left > lasttoy.Left) lasttoy = item;
            }
            if (lasttoy.Left>1000)
            {
                _toys.Remove(lasttoy);
                mainpanel.Controls.Remove(lasttoy);
            }
        }

        private void btncar_Click(object sender, EventArgs e)
        {
             Factory = new Ballfactory() { BallColor = btnbc.BackColor };
        }

        private void btnball_Click(object sender, EventArgs e)
        {
            Factory = new Carfactory();
        }
        private void btnp_Click(object sender, EventArgs e)
        {
            Factory = new Presentfactory() { PColor = btnbc.BackColor };
        }

        private void btnbc_Click(object sender, EventArgs e)
        {
            Button kattintott = (Button)sender;
            ColorDialog cd = new ColorDialog();
            cd.Color = kattintott.BackColor;
            if (cd.ShowDialog() != DialogResult.OK) return;
            kattintott.BackColor = cd.Color;

        }

        

        private void btnpc_Click(object sender, EventArgs e)
        {
            Button kattintott = (Button)sender;
            ColorDialog cd = new ColorDialog();
            cd.Color = kattintott.BackColor;
            if (cd.ShowDialog() != DialogResult.OK) return;
            kattintott.BackColor = cd.Color;
        }

        private void btncsc_Click(object sender, EventArgs e)
        {
            Button kattintott = (Button)sender;
            ColorDialog cd = new ColorDialog();
            cd.Color = kattintott.BackColor;
            if (cd.ShowDialog() != DialogResult.OK) return;
            kattintott.BackColor = cd.Color;
        }

       
    }
}
