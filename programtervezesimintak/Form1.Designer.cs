
namespace programtervezesimintak
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
            this.components = new System.ComponentModel.Container();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.Createtimer = new System.Windows.Forms.Timer(this.components);
            this.Conveyort = new System.Windows.Forms.Timer(this.components);
            this.btncar = new System.Windows.Forms.Button();
            this.btnball = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbc = new System.Windows.Forms.Button();
            this.btnp = new System.Windows.Forms.Button();
            this.btncsc = new System.Windows.Forms.Button();
            this.btnpc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Location = new System.Drawing.Point(2, 220);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(801, 235);
            this.mainpanel.TabIndex = 0;
            // 
            // Createtimer
            // 
            this.Createtimer.Enabled = true;
            this.Createtimer.Interval = 3000;
            this.Createtimer.Tick += new System.EventHandler(this.Createtimer_Tick);
            // 
            // Conveyort
            // 
            this.Conveyort.Enabled = true;
            this.Conveyort.Interval = 10;
            this.Conveyort.Tick += new System.EventHandler(this.Conveyort_Tick);
            // 
            // btncar
            // 
            this.btncar.Location = new System.Drawing.Point(68, 128);
            this.btncar.Name = "btncar";
            this.btncar.Size = new System.Drawing.Size(75, 23);
            this.btncar.TabIndex = 1;
            this.btncar.Text = "ball";
            this.btncar.UseVisualStyleBackColor = true;
            this.btncar.Click += new System.EventHandler(this.btncar_Click);
            // 
            // btnball
            // 
            this.btnball.Location = new System.Drawing.Point(229, 127);
            this.btnball.Name = "btnball";
            this.btnball.Size = new System.Drawing.Size(75, 23);
            this.btnball.TabIndex = 2;
            this.btnball.Text = "car";
            this.btnball.UseVisualStyleBackColor = true;
            this.btnball.Click += new System.EventHandler(this.btnball_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "coming";
            // 
            // btnbc
            // 
            this.btnbc.Location = new System.Drawing.Point(68, 158);
            this.btnbc.Name = "btnbc";
            this.btnbc.Size = new System.Drawing.Size(75, 23);
            this.btnbc.TabIndex = 4;
            this.btnbc.UseVisualStyleBackColor = true;
            this.btnbc.Click += new System.EventHandler(this.btnbc_Click);
            // 
            // btnp
            // 
            this.btnp.Location = new System.Drawing.Point(349, 126);
            this.btnp.Name = "btnp";
            this.btnp.Size = new System.Drawing.Size(75, 23);
            this.btnp.TabIndex = 5;
            this.btnp.Text = "Present";
            this.btnp.UseVisualStyleBackColor = true;
            this.btnp.Click += new System.EventHandler(this.btnp_Click);
            // 
            // btncsc
            // 
            this.btncsc.Location = new System.Drawing.Point(349, 158);
            this.btncsc.Name = "btncsc";
            this.btncsc.Size = new System.Drawing.Size(75, 23);
            this.btncsc.TabIndex = 6;
            this.btncsc.UseVisualStyleBackColor = true;
            this.btncsc.Click += new System.EventHandler(this.btncsc_Click);
            // 
            // btnpc
            // 
            this.btnpc.Location = new System.Drawing.Point(349, 188);
            this.btnpc.Name = "btnpc";
            this.btnpc.Size = new System.Drawing.Size(75, 23);
            this.btnpc.TabIndex = 7;
            this.btnpc.UseVisualStyleBackColor = true;
            this.btnpc.Click += new System.EventHandler(this.btnpc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpc);
            this.Controls.Add(this.btncsc);
            this.Controls.Add(this.btnp);
            this.Controls.Add(this.btnbc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnball);
            this.Controls.Add(this.btncar);
            this.Controls.Add(this.mainpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Timer Createtimer;
        private System.Windows.Forms.Timer Conveyort;
        private System.Windows.Forms.Button btncar;
        private System.Windows.Forms.Button btnball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbc;
        private System.Windows.Forms.Button btnp;
        private System.Windows.Forms.Button btncsc;
        private System.Windows.Forms.Button btnpc;
    }
}

