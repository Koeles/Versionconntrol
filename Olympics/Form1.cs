using Olympics.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace Olympics
{
    public partial class Form1 : Form
    {

        List<Olympicresult> result = new List<Olympicresult>();
        public Form1()
        {
            InitializeComponent();

            Betolt("Summer_olympic_Medals.csv");
            Combofeltolt();
            Osztalyozas();
        }

        private void Osztalyozas()
        {
            foreach (Olympicresult item in result)
            {
                item.Position = helyezes(item);
            }
        }

        int helyezes(Olympicresult res)
        {
            int counter = 0;
            var szurt = from x in result where x.Year == res.Year && x.Country != res.Country select x;
            foreach (Olympicresult item in szurt)
            {
                if (item.Medals[0] > res.Medals[0]) counter++;
                else if ((item.Medals[0] == res.Medals[0]) && (res.Medals[1] > res.Medals[1])) counter++;
                else if ((item.Medals[0] == res.Medals[0]) && (res.Medals[1] == res.Medals[1]) && (res.Medals[2] > res.Medals[2]))counter++;

            }
            return counter + 1;
        }
        private void Combofeltolt()
        {
            var years = (from x in result orderby x.Year select x.Year).Distinct();
            cbev.DataSource = years.ToList();
        }

        void Betolt(string fajlnev)
        {
            using (StreamReader sr = new StreamReader(fajlnev))
            {
                sr.ReadLine(); 
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] mezok = sor.Split(',');
                    Olympicresult or = new Olympicresult();
                    or.Year = int.Parse(mezok[0]);
                    or.Country = mezok[3];
                    int[] mtomb = new int[3];
                    mtomb[0]= int.Parse(mezok[5]);
                    mtomb[1] = int.Parse(mezok[6]);
                    mtomb[2] = int.Parse(mezok[7]);
                    or.Medals = mtomb;
                    result.Add(or);

                    
                }
            }
        }

        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
        private void btexp_Click(object sender, EventArgs e)
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;


                Excelfeltolt();

                xlApp.Visible = true;
                xlApp.UserControl = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;

            }
        }

        private void Excelfeltolt()
        {
            var headers = new string[]
            {
                "Helyezés",
                "Ország",
                "Arany",
                "Ezüst",
                "Bronz",
            };
            for (int i =0; i <headers.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = headers[i];
            }
            var filteredresult = from x in result where x.Year == (int)cbev.SelectedItem orderby x.Position select x;

            int aktsor = 2;
            foreach (var item in filteredresult)
            {
                xlSheet.Cells[aktsor, 1] = item.Position;
                xlSheet.Cells[aktsor, 2] = item.Country;
                for (int i = 0; i < 3; i++)
                {
                    xlSheet.Cells[aktsor, 3 + i]=item.Medals[i];
                }
                aktsor++;
            }
        }
    }
}
