using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba6
{
    public partial class Form1 : Form
    {
        double y,x;
        double l = -20;
        double r = 20;
        double s = 0.1;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox3.Text);
            double c = Convert.ToDouble(textBox4.Text);
            chart1.Series[0].Points.Clear();
            if (radioButton1.Checked==false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false && radioButton7.Checked == false && radioButton8.Checked == false)
            {
                MessageBox.Show("Не выбрана функция");
                return;
            }
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Не выбраны параметры");
                return;
            }
            if (radioButton1.Checked)
            {
                x =l;
                while (x <= r)
                {
                    var x1 = Math.Round(x, 1);
                    if (x1 == x0)
                    {
                        Console.WriteLine("asd");
                        y = x0 * a + b;
                        chart1.Series[1].Points.AddXY(x0, y);
                        x += s;
                    }
                    else
                    {
                        y = x * a + b;
                        chart1.Series[0].Points.AddXY(x, y);
                        x += s;
                    }
                }
            }
            if (radioButton2.Checked)
            {
                x = l;
                while (x <= r)
                {
                    var x1 = Math.Round(x, 1);
                    if (x1 == x0)
                    {
                        y = a * Math.Sin(x0 * b) + c;
                        chart1.Series[1].Points.AddXY(x0, y);
                        x += s;
                    }
                    else
                    {
                        y = a * Math.Sin(x * b) + c;
                        chart1.Series[0].Points.AddXY(x, y);
                        x += s;
                    }
                }
            }
            if (radioButton3.Checked)
            {
                x = l;
                while (x <= r)
                {
                    var x1 = Math.Round(x, 1);
                    if (x1 == x0)
                    {
                        y = a * Math.Cos(x0 * b) + c;
                        chart1.Series[1].Points.AddXY(x0, y);
                        x += s;
                    }
                    else
                    {
                        y = a * Math.Cos(x * b) + c;
                        chart1.Series[0].Points.AddXY(x, y);
                        x += s;
                    }
                }
            }
            if (radioButton4.Checked)
            {
                x = l;
                while (x <= r)
                {
                    var x1 = Math.Round(x, 1);
                    if (x1 == x0)
                    {
                        y = a * Math.Tan(x0 * b) + c;
                        chart1.Series[1].Points.AddXY(x0, y);
                        x += s;
                    }
                    else
                    {
                        y = a * Math.Tan(x * b) + c;
                        chart1.Series[0].Points.AddXY(x, y);
                        x += s;
                    }
                }
            }
            if (radioButton5.Checked)
            {
                x = l;
                while (x <= r)
                {
                    var x1 = Math.Round(x, 1);
                    if (x1 == x0)
                    {
                        if (Math.Tan(x * b + c) == 0)
                        {
                            x += s;
                        }
                        y = a * (1 / Math.Tan(x0 * b + c));
                        chart1.Series[1].Points.AddXY(x0, y);
                        x += s;
                    }
                    else
                    {
                        if (Math.Tan(x * b + c) == 0)
                        {
                            x += s;
                        }
                        y = a * (1 / Math.Tan(x * b + c));
                        chart1.Series[0].Points.AddXY(x, y);
                        x += s;
                    }
                }
            }
            if (radioButton6.Checked)
            {
                x = l;
                while (x <= r)
                {
                    var x1 = Math.Round(x, 1);
                    if (x1 == x0)
                    {
                        y = b * Math.Pow(x0, a);
                        chart1.Series[1].Points.AddXY(x0, y);
                        x += s;
                    }
                    else
                    {
                        y = b * Math.Pow(x, a);
                        chart1.Series[0].Points.AddXY(x, y);
                        x += s;
                    }
                }
            }
            if (radioButton7.Checked)
            {
                x = l;
                while (x <= r)
                {
                    var x1 = Math.Round(x, 1);
                    if (x1 == x0)
                    {
                        y = Math.Pow(a, x0 + b);
                        chart1.Series[1].Points.AddXY(x0, y);
                        x += s;
                    }
                    else
                    {
                        y = Math.Pow(a, x + b);
                        chart1.Series[0].Points.AddXY(x, y);
                        x += s;
                    }
                }
            }
            if (radioButton8.Checked)
            {
                x = l;
                while (x <= r)
                {
                    var x1 = Math.Round(x, 1);
                    if (x1 == x0)
                    {
                        if ((x - Math.Pow(x, 0.5)) + 1 == 0)
                        {
                            x += s;
                        }
                        else if (x == 0)
                        {
                            x += s;
                        }
                        y = Math.Pow((Math.Sin(x0) + a * x0) / ((x0 - Math.Pow(x0, 0.5)) + 1), (b / x0));
                        chart1.Series[1].Points.AddXY(x, y);
                        x += s;
                    }
                    else
                    {
                        if ((x - Math.Pow(x, 0.5)) + 1 == 0)
                        {
                            x += s;
                        }
                        else if (x == 0)
                        {
                            x += s;
                        }
                        y = Math.Pow((Math.Sin(x) + a * x) / ((x - Math.Pow(x, 0.5)) + 1), (b / x));
                        chart1.Series[0].Points.AddXY(x, y);
                        x += s;
                    }
                }
            }
        }
    }
}
