using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double count2 = 0.0,count1 =0.0;
        int count = 0;
        string simbol = "",maskSimbol="";
        public Calculator()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text.Text += 3;
            count1 = double.Parse(text.Text);
            
        }

        private void one_Click(object sender, EventArgs e)
        {
            text.Text += 1;
            count1 = double.Parse(text.Text);
        }

        private void two_Click(object sender, EventArgs e)
        {
            text.Text += 2;
            count1 = double.Parse(text.Text);
        }

        private void four_Click(object sender, EventArgs e)
        {
            text.Text += 4;
            count1 = double.Parse(text.Text);
        }

        private void five_Click(object sender, EventArgs e)
        {
            text.Text += 5;
            count1 = double.Parse(text.Text);
        }

        private void six_Click(object sender, EventArgs e)
        {
            text.Text += 6;
            count1 = double.Parse(text.Text);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            text.Text += 7;
            count1 = double.Parse(text.Text);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            text.Text += 8;
            count1 = double.Parse(text.Text);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            text.Text += 9;
            count1 = double.Parse(text.Text);
        }

        private void comma_Click(object sender, EventArgs e)
        {
            text.Text += ",";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            text.Text += 0;
            count1 = double.Parse(text.Text);
        }

        private void equally_Click(object sender, EventArgs e)
        {
            if (count1 != 0)
            {
                text.Text = "!";
                switch (maskSimbol)
                {
                    case "+": count2 += count1; break;
                    case "-": count2 -= count1; break;
                    case "*": count2 *= count1; break;
                    case "/": count2 /= count1; break;
                    case "%": count2 %= count1; break;
                    default:
                        break;
                }
            }
            
            text.Text = "";
            if (count2 == 0) text.Text += count1;
            else 
            text.Text += count2;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            simbol = maskSimbol;
            count++;
            
            maskSimbol = "+";
            if (count > 1)
            {
                switch (simbol)
                {
                    case "+": count2 += count1; break;
                    case "-": count2 -= count1; break;
                    case "*": count2 *= count1; break;
                    case "/": count2 /= count1; break;
                    case "%": count2 %= count1; break;
                    default: break;
                }
            }
            else count2 = count1;

            count1 = 0; text.Text = "";
        }

        private void root_Click(object sender, EventArgs e)
        {          

            count1 = Math.Sqrt(count1);
            text.Text = ""; 
        }

        private void minus_Click(object sender, EventArgs e)
        {
            simbol = maskSimbol;
            count++;

            maskSimbol = "-";
            if (count > 1)
            {
                switch (simbol)
                {
                    case "+": count2 += count1; break;
                    case "-": count2 -= count1; break;
                    case "*": count2 *= count1; break;
                    case "/": count2 /= count1; break;
                    case "%": count2 %= count1; break;
                    default: break;
                }
            }
            else count2 = count1;

            count1 = 0; text.Text = "";
        }

        private void multiplied_Click(object sender, EventArgs e)
        {
            simbol = maskSimbol;
            count++;

            maskSimbol = "*";
            if (count > 1)
            {
                switch (simbol)
                {
                    case "+": count2 += count1; break;
                    case "-": count2 -= count1; break;
                    case "*": count2 *= count1; break;
                    case "/": count2 /= count1; break;
                    case "%": count2 %= count1; break;
                    default: break;
                }
            }
            else count2 = count1;

            count1 = 0; text.Text = "";
        }

        private void divided_Click(object sender, EventArgs e)
        {
            simbol = maskSimbol;
            count++;

            maskSimbol = "/";
            if (count > 1)
            {
                switch (simbol)
                {
                    case "+": count2 += count1; break;
                    case "-": count2 -= count1; break;
                    case "*": count2 *= count1; break;
                    case "/": count2 /= count1; break;
                    case "%": count2 %= count1; break;
                    default: break;
                }
            }
            else count2 = count1;

            count1 = 0; text.Text = "";
        }

        private void percent_Click(object sender, EventArgs e)
        {
            simbol = maskSimbol;
            count++;

            maskSimbol = "%";
            if (count > 1)
            {
                switch (simbol)
                {
                    case "+": count2 += count1; break;
                    case "-": count2 -= count1; break;
                    case "*": count2 *= count1; break;
                    case "/": count2 /= count1; break;
                    case "%": count2 %= count1; break;
                    default: break;
                }
            }
            else count2 = count1;

            count1 = 0; text.Text = "";
        }

        
    }
}
