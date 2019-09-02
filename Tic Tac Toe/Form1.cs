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
        bool turn = true;
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ABOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Chuong Le", "Tic_Tac_Toe ABOUT");
        }

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(turn)
            {
                b.Text ="X";
            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;
            checkForWinner();
            turn_count++;
        }
        private void checkForWinner()
        {
            bool got_a_winner = false;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text)&&(!A1.Enabled))
                got_a_winner = true;
            else if ((A4.Text == A5.Text) && (A5.Text == A6.Text)&&(!A4.Enabled))
                got_a_winner = true;
            else if ((A7.Text == A8.Text) && (A8.Text == A9.Text)&&(!A7.Enabled))
                got_a_winner = true;
            else if ((A1.Text == A4.Text) && (A4.Text == A7.Text) && (!A1.Enabled))
                got_a_winner = true;
            else if ((A2.Text == A5.Text) && (A5.Text == A8.Text) && (!A2.Enabled))
                got_a_winner = true;
            else if ((A3.Text == A6.Text) && (A6.Text == A9.Text) && (!A3.Enabled))
                got_a_winner = true;
            else if ((A1.Text == A5.Text) && (A5.Text == A9.Text) && (!A1.Enabled))
                got_a_winner = true;
            else if ((A3.Text == A5.Text) && (A5.Text == A7.Text) && (!A3.Enabled))
                got_a_winner = true;

            if (got_a_winner)
            {
                disableButtons();
                string winner = " ";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show(winner + " won!");

            }
            else
            {
                if(turn_count == 9)
                   MessageBox.Show("Draw!");
            }

 

        }
        private void disableButtons()
        {
            try
            {
                foreach(Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;

                }
            }
            catch { }
       
        }

        private void NEWGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";

                }
            }
            catch { }

        }
    }
}
