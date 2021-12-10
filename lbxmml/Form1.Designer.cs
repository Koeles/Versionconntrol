
namespace lbxmml
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chartRatedata = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tolpicker = new System.Windows.Forms.DateTimePicker();
            this.igpicker = new System.Windows.Forms.DateTimePicker();
            this.cbvaluta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRatedata)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // chartRatedata
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRatedata.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRatedata.Legends.Add(legend2);
            this.chartRatedata.Location = new System.Drawing.Point(460, 38);
            this.chartRatedata.Name = "chartRatedata";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartRatedata.Series.Add(series2);
            this.chartRatedata.Size = new System.Drawing.Size(347, 322);
            this.chartRatedata.TabIndex = 1;
            this.chartRatedata.Text = "chart1";
            // 
            // tolpicker
            // 
            this.tolpicker.Location = new System.Drawing.Point(460, 12);
            this.tolpicker.Name = "tolpicker";
            this.tolpicker.Size = new System.Drawing.Size(112, 20);
            this.tolpicker.TabIndex = 2;
            this.tolpicker.ValueChanged += new System.EventHandler(this.tolpicker_ValueChanged);
            // 
            // igpicker
            // 
            this.igpicker.Location = new System.Drawing.Point(578, 12);
            this.igpicker.Name = "igpicker";
            this.igpicker.Size = new System.Drawing.Size(118, 20);
            this.igpicker.TabIndex = 3;
            this.igpicker.ValueChanged += new System.EventHandler(this.tolpicker_ValueChanged);
            // 
            // cbvaluta
            // 
            this.cbvaluta.FormattingEnabled = true;
            this.cbvaluta.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.cbvaluta.Location = new System.Drawing.Point(702, 11);
            this.cbvaluta.Name = "cbvaluta";
            this.cbvaluta.Size = new System.Drawing.Size(95, 21);
            this.cbvaluta.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbvaluta);
            this.Controls.Add(this.igpicker);
            this.Controls.Add(this.tolpicker);
            this.Controls.Add(this.chartRatedata);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRatedata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRatedata;
        private System.Windows.Forms.DateTimePicker tolpicker;
        private System.Windows.Forms.DateTimePicker igpicker;
        private System.Windows.Forms.ComboBox cbvaluta;
    }
}

