using lbxmml.Entitites;
using lbxmml.MNBServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace lbxmml
{
    public partial class Form1 : Form
    {

        BindingList<Ratedata> _rates= new BindingList<Ratedata>();
        BindingList<string> currencies = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
            cbvaluta.DataSource = currencies;
            Refreshdata();
        }

        private void Refreshdata()
        {
            if (cbvaluta.SelectedItem == null) return;
                _rates.Clear();
            loadXml(getRates());
            dataGridView1.DataSource = _rates;

            makeChart();
        }

        private void makeChart()
        {
            chartRatedata.DataSource = _rates;
            Series sorozatok = chartRatedata.Series[0];
            sorozatok.ChartType = SeriesChartType.Line;
            sorozatok.XValueMember = "Date";
            sorozatok.YValueMembers = "value";

            var jelmagyarazat = chartRatedata.Legends[0];
            jelmagyarazat.Enabled = false;
            var diagramterulet = chartRatedata.ChartAreas[0];
            diagramterulet.AxisY.IsStartedFromZero = false;
            diagramterulet.AxisY.MajorGrid.Enabled = false;
            diagramterulet.AxisX.MajorGrid.Enabled = false;


        }

        private void loadXml(string xmlstring)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlstring);
            foreach (XmlElement item in xml.DocumentElement)
            {
                Ratedata r = new Ratedata();
                r.Date = DateTime.Parse(item.GetAttribute("date"));
                var childElement = (XmlElement)item.ChildNodes[0];
                r.Currency = childElement.GetAttribute("curr");
                decimal unit = decimal.Parse(childElement.GetAttribute("unit"));
                r.Value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    r.Value = r.Value / unit;
                _rates.Add(r);
            }
        }

        private string getRates()
        {
            
            var mnbService = new MNBArfolyamServiceSoapClient();
            GetExchangeRatesRequestBody req = new GetExchangeRatesRequestBody();
            req.currencyNames = cbvaluta.SelectedItem.ToString();//"EUR";
            req.startDate = tolpicker.Value.ToString("yyyy-MM-dd");//2020-01-01";
            req.endDate = igpicker.Value.ToString("yyyy-MM-dd");//"2020-06-30";
            var response = mnbService.GetExchangeRates(req);
            return response.GetExchangeRatesResult;
        }
        private string getCurrencies()
        {

            var mnbServvice = new MNBArfolyamServiceSoapClient();
            GetCurrenciesRequestBody req = new GetCurrenciesRequestBody();
            var resp = mnbServvice.GetCurrencies(req);
            return resp.GetCurrenciesResult;

        }


        private void tolpicker_ValueChanged(object sender, EventArgs e)
        {

            Refreshdata();
        }

     
    }
}
