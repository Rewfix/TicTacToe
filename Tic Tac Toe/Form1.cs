using System;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool xTurn = true;
        void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (xTurn)
                b.Text = "X";
            else
                b.Text = "O";
            xTurn = !xTurn;
            b.Enabled = false;
            CheckWin(b);
        }

        void CheckWin(Button prB)
        {
            void MSb()
            {
                DialogResult a = MessageBox.Show("Победили " + prB.Text, "", MessageBoxButtons.RetryCancel);
                if (DialogResult.Retry == a)
                    Application.Restart();
                else
                    Application.Exit();
            }

            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Enabled == false) MSb();
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Enabled == false) MSb();
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Enabled == false) MSb();

            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Enabled == false) MSb();
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Enabled == false) MSb();
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Enabled == false) MSb();

            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Enabled == false) MSb();
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Enabled == false) MSb();

            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false 
                && button3.Enabled == false && button5.Enabled == false && button6.Enabled == false
                && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                DialogResult a = MessageBox.Show("Ничья", "", MessageBoxButtons.RetryCancel);
                if (DialogResult.Retry == a)
                    Application.Restart();
                else
                    Application.Exit();
            }
        }

        void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}