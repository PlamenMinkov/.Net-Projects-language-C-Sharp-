using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        int player = 1, mask = -1,wins1=0,wins2=0;
        private void b1_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                b1.Text = "X";
                player *= mask;
            }
            else
            {
                b1.Text = "O";
                player *= mask;
            }
            winner();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                bt2.Text = "X";
                player *= mask;
            }
            else
            {
                bt2.Text = "O";
                player *= mask;
            }
            winner();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                bt3.Text = "X";
                player *= mask;
            }
            else
            {
                bt3.Text = "O";
                player *= mask;
            }
            winner();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                bt4.Text = "X";
                player *= mask;
            }
            else
            {
                bt4.Text = "O";
                player *= mask;
            }
            winner();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                bt5.Text = "X";
                player *= mask;
            }
            else
            {
                bt5.Text = "O";
                player *= mask;
            }
            winner();
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                bt6.Text = "X";
                player *= mask;
            }
            else
            {
                bt6.Text = "O";
                player *= mask;
            }
            winner();
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                bt7.Text = "X";
                player *= mask;
            }
            else
            {
                bt7.Text = "O";
                player *= mask;
            }
            winner();
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                bt8.Text = "X";
                player *= mask;
            }
            else
            {
                bt8.Text = "O";
                player *= mask;
            }
            winner();
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                bt9.Text = "X";
                player *= mask;
            }
            else
            {
                bt9.Text = "O";
                player *= mask;
            }
            winner();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            b1.Text = "";
            bt2.Text = "";
            bt3.Text = "";
            bt4.Text = "";
            bt5.Text = "";
            bt6.Text = "";
            bt7.Text = "";
            bt8.Text = "";
            bt9.Text = "";
            win.Text = "";
        }
        public void winner()
        {
            if (b1.Text == "X" && bt2.Text == "X" && bt3.Text == "X"
                || b1.Text == "X" && bt4.Text == "X" && bt7.Text == "X"
                || b1.Text == "X" && bt5.Text == "X" && bt9.Text == "X"
                || bt2.Text == "X" && bt5.Text == "X" && bt8.Text == "X"
                || bt3.Text == "X" && bt6.Text == "X" && bt9.Text == "X"
                || bt3.Text == "X" && bt5.Text == "X" && bt7.Text == "X"
                || bt4.Text == "X" && bt5.Text == "X" && bt6.Text == "X"
                || bt7.Text == "X" && bt8.Text == "X" && bt9.Text == "X")
            {
                win.Text = "First Player Win";
                wins1++;
                res1.Text = Convert.ToString(wins1);
            }
            if (b1.Text == "O" && bt2.Text == "O" && bt3.Text == "O"
                || b1.Text == "O" && bt4.Text == "O" && bt7.Text == "O"
                || b1.Text == "O" && bt5.Text == "O" && bt9.Text == "O"
                || bt2.Text == "O" && bt5.Text == "O" && bt8.Text == "O"
                || bt3.Text == "O" && bt6.Text == "O" && bt9.Text == "O"
                || bt3.Text == "O" && bt5.Text == "O" && bt7.Text == "O"
                || bt4.Text == "O" && bt5.Text == "O" && bt6.Text == "O"
                || bt7.Text == "O" && bt8.Text == "O" && bt9.Text == "O")
            {
                win.Text = "Second Player Win";
                wins2++;
                res2.Text = Convert.ToString(wins2);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
