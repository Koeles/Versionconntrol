using Mikroszimulacio.Entities;
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

namespace Mikroszimulacio
{
    public partial class Form1 : Form
    {
        List<Person> Population;
        List<BirthProb> BirthProb ;
        List<DeathProb> DeathProb ;
        List<int> ferfiak = new List<int>();
        List<int> nok = new List<int>();

        Random rng = new Random();




        public Form1()
        {
            InitializeComponent();
            

           // Simulation();

        }

        private void Simulation(int zaroev, string fajlnev)
        {
            ferfiak.Clear();
            nok.Clear();
            Population = GetPopulation(fajlnev);
            BirthProb = GetBirthProb(@"C:\temp\születés.csv");
            DeathProb = GetDeathProb(@"C:\temp\halál.csv");

            for (int year = 2005; year < zaroev; year++)
            {
                for (int i = 0; i < Population.Count; i++)
                {
                    SzimulaciosLepes(Population[i], year);
                }

                int ferfiakszamna = (from x in Population where x.Gender == Gender.Male select x).Count();
                int nokszamna = (from x in Population where x.Gender == Gender.Female select x).Count();
                ferfiak.Add(ferfiakszamna);
                nok.Add(nokszamna);
                Console.Write(string.Format("Év:{0} Férfiak: {1} Nők: {2}", year, ferfiakszamna, nokszamna));

            }
            DisplayResult(zaroev);
        }

        void DisplayResult(int zaroev)
        {
            int counter = 0; 
            for (int year = 2005; year < zaroev; year++)
            {
                for (int i = 0; i < Population.Count; i++)
                {
                    richTextBox1.Text += string.Format("Szimulaciós év {0}\n\tFérfiak:{1}\n\tNők:{2}\n\n",year,ferfiak[counter],nok[counter]);
                    counter++;
                }

               

            }

        }
        private void SzimulaciosLepes(Person person, int year)
        {
            if (!person.IsALive) return;
            int kor = year - person.BirthYear;
            double halalv = (from x in DeathProb where x.Gender == person.Gender && x.Age == kor select x.p).FirstOrDefault();
            double veletlen = rng.NextDouble();

            if (veletlen <= halalv)
                person.IsALive = false;

            if (person.IsALive && person.Gender == Gender.Female)
            {
               
                double szulval = (from x in BirthProb where x.Age == kor select x.p).FirstOrDefault();
                
                if (veletlen <= szulval)
                {
                    Person baba = new Person();
                    baba.BirthYear = year;
                    baba.NbrOfChildren = 0;
                    baba.Gender = (Gender)(rng.Next(1, 3));
                    Population.Add(baba);
                }
            }
        }

        public List<Person> GetPopulation(string cvspath)
        {

            List<Person> result = new List<Person>();
            using (StreamReader sr = new StreamReader(cvspath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] items = line.Split(';');
                    Person p = new Person();
                    p.BirthYear = int.Parse(items[0]);
                    p.Gender=(Gender)Enum.Parse(typeof(Gender),items[1]);
                    p.NbrOfChildren = int.Parse(items[2]);
                    result.Add(p);
                }
            }
            return result;
        }
        public List<BirthProb> GetBirthProb(string cvspath)
        {

            List<BirthProb> result = new List<BirthProb>();
            using (StreamReader sr = new StreamReader(cvspath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] items = line.Split(';');
                    BirthProb b = new BirthProb();
                    b.Age = int.Parse(items[0]);
                   b.NbrOfChildren = int.Parse(items[1]);
                  b.p = double.Parse(items[2]);
                        result.Add(b);
                }
            }
            return result;
        }
        public List<DeathProb> GetDeathProb(string cvspath)
        {

            List<DeathProb> result = new List<DeathProb>();
            using (StreamReader sr = new StreamReader(cvspath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] items = line.Split(';');
                    DeathProb p = new DeathProb();
                    p.Age = int.Parse(items[1]);
                    p.Gender = (Gender)Enum.Parse(typeof(Gender), items[0]);
                    p.p = double.Parse(items[2]);
                    result.Add(p);
                }
            }
            return result;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            Simulation((int)numericUpDown1.Value,tbfajl.Text);
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) tbfajl.Text = ofd.FileName;
        }
    }
}
