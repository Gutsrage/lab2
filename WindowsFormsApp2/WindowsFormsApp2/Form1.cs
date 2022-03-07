using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1,23";         
            textBox2.Text = "15,4";
            textBox3.Text = "252";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "X=" + x.ToString();
            textBox4.Text += Environment.NewLine + "Y=" + y.ToString();
            textBox4.Text += Environment.NewLine + "Z=" + z.ToString();
            double a = (Math.Pow(y, (x + 1))) / ((Math.Pow(Math.Abs(y-2),(1/3)))+3);
            double b = (x + (y / 2)) / (2 * Math.Abs(x + y));
            double c = Math.Pow((x+1),-1/Math.Sin(z));
            double g = a + (b * c);
            textBox4.Text += Environment.NewLine + "Результат G = " + g.ToString();

        }
    }
}
