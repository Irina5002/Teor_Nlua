using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teor_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(textBox1.Text);
            double B = Convert.ToDouble(textBox2.Text);
            double C = Convert.ToDouble(textBox3.Text);
            double D = Convert.ToDouble(textBox4.Text);
            double E = Convert.ToDouble(textBox5.Text);
            double N = Convert.ToDouble(textBox6.Text);
            double count = 0;
            double x = 0;
            bool a = false;
            bool b = false;
            bool c = false;
            bool d = false;
            bool f = false;
            Random rnd = new Random();
            Random ra = new Random(rnd.Next(10000));
            Random rb = new Random(rnd.Next(10000));
            Random rc = new Random(rnd.Next(10000));
            Random rd = new Random(rnd.Next(10000));
            Random re = new Random(rnd.Next(10000));

            for (int i = 0; i < N; i++)
            {

                x = ra.NextDouble();
                a = (A >= x);
                x = rb.NextDouble();
                b = (B >= x);
                x = rc.NextDouble();
                c = (C >= x);
                x = rd.NextDouble();
                d = (D >= x);
                x = re.NextDouble();
                f = (E >= x);

                bool trying = (!a || !b) || (c && !d) || f;
                if (trying) count++;
            }
            var Th_1 = (1 - A) + (1 - B) - (1 - A) * (1 - B);
            var Th_2 = C * (1 - D);
            var Th = Th_1 + Th_2 - Th_1 * Th_2;
            var Resoult = Th + E - Th * E;
            textBox7.Text = Resoult.ToString();
            textBox8.Text = (count / N).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
