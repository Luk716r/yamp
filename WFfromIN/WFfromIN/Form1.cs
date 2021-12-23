using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFfromIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double sum(double a,double b)
        { return a + b; }
        public static double subtraction(double a,double b)
        { return a - b; }
        public static double division(double a,double b)
        { if (b == 0) return 0;
            return a / b; }
        public static double multiplication(double a,double b)
        { return a * b; }
        public static double comparison(double a,double b)
        {
            if(a<=b) return 0;    
            else if(a>=b) return 1;
            else return -1;
        }
        public static double ResOne(double upper, double lower,double korner,double cvar)
        {
            return (upper*upper*korner/2-lower*lower*korner/2)+cvar;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Com;
            //нахождение первого интеграла
            textBox9.Text = Convert.ToString(ResOne(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text)));
        //нахождение второго интеграла
            textBox10.Text = Convert.ToString(ResOne(Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text), Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox8.Text)));
            //нахождение суммы интегралов
            textBox11.Text = Convert.ToString(sum(Convert.ToDouble(textBox9.Text), Convert.ToDouble(textBox10.Text)));
           //вычитание интегралов
            textBox12.Text = Convert.ToString(subtraction(Convert.ToDouble(textBox9.Text), Convert.ToDouble(textBox10.Text)));
            //деление интегралов
            textBox13.Text = Convert.ToString(division(Convert.ToDouble(textBox9.Text), Convert.ToDouble(textBox10.Text)));
            // умножение интегралов
            textBox14.Text = Convert.ToString(multiplication(Convert.ToDouble(textBox9.Text), Convert.ToDouble(textBox10.Text)));
            Com = comparison(Convert.ToDouble(textBox9.Text), Convert.ToDouble(textBox10.Text));
            if(Com == 0)
            {
                textBox15.Text = "R1<=R2";
            }
            else if(Com == 1)
            {
                textBox15.Text = "R1>=R2";
            }
            else
            {
                textBox15.Text = "R1=R2";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
