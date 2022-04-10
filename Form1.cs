using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("X", typeof(double));
            dt.Columns.Add("Y", typeof(double));
            double a = 0, b = 10, h = 0.1, x, y, n;
            if (!(atext.Text == "")) a = Convert.ToDouble(atext.Text);
            if (!(btext.Text == "")) b = Convert.ToDouble(btext.Text);
            if (!(textBox3.Text == ""))
            {
                n = Convert.ToDouble(textBox3.Text);
                h = (b - a) / n;
            }
            if (a <= 0) a = 0;
            this.chart1.Series[0].Points.Clear();
            x = a;
            while (x <= b)
            {
                y = Math.Pow(x, 1 / x);
                this.chart1.Series[0].Points.AddXY(x,y);
                x += h;
                dt.Rows.Add(x, y);
            }
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            this.chart1.Series[0].Points.Clear();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("X", typeof(double));
            dt.Columns.Add("Y", typeof(double));
            double a = -5, b = 5, h = 0.1, x, y,n;
            if (!(atext.Text == "")) a = Convert.ToDouble(atext.Text);
            if (!(btext.Text == "")) b = Convert.ToDouble(btext.Text);
            if (!(textBox3.Text == ""))
            {
                n = Convert.ToDouble(textBox3.Text);
                h = (b - a) / n;
            }
            this.chart1.Series[0].Points.Clear();
            x = a;
            while (x <= b)
            {
                y = (Math.Pow(x, 2)+1)/4;
                this.chart1.Series[0].Points.AddXY(x, y);
                x += h;
                dt.Rows.Add(x, y);
            }
            dataGridView1.DataSource = dt;
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("X", typeof(double));
            dt.Columns.Add("Y", typeof(double));
            double a = -5, b = 5, h = 0.1, x, y, n;
            if (!(atext.Text == "")) a = Convert.ToDouble(atext.Text);
            if (!(btext.Text == "")) b = Convert.ToDouble(btext.Text);
            if (!(textBox3.Text == ""))
            {
                n = Convert.ToDouble(textBox3.Text);
                h = (b - a) / n;
            }
            this.chart1.Series[0].Points.Clear();
            x = a;
            while (x <= b)
            {
                y = (Math.Pow(x, 2) - 1) / 4;
                this.chart1.Series[0].Points.AddXY(x, y);
                x += h;
                dt.Rows.Add(x, y);
            }
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("X", typeof(double));
            dt.Columns.Add("Y", typeof(double));
            dt.Columns.Add("T", typeof(double));
            double a = -5, b = 5, h = 0.1, x, y, t, n;
            if (!(atext.Text == "")) a = Convert.ToDouble(atext.Text);
            if (!(btext.Text == "")) b = Convert.ToDouble(btext.Text);
            if (!(textBox3.Text == ""))
            {
                n = Convert.ToDouble(textBox3.Text);
                h = (b - a) / n;
            }
            this.chart1.Series[0].Points.Clear();
            t = a;
            while (t <= b)
            {
                x = (Math.Pow(t, 2) + 1) / 4;
                y = (Math.Pow(t, 2) - 1) / 4;
                this.chart1.Series[0].Points.AddXY(x, y);
                t += h;
                dt.Rows.Add(x, y, t);
            }
            dataGridView1.DataSource = dt;
        }

        private void atext_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
