using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool whoHaveStep;
        private string strFirstPlayer;
        private string strSecondPlayer;

        public string StrFirstPlayer { get => strFirstPlayer; set => strFirstPlayer = value; }
        public string StrSecondPlayer { get => strSecondPlayer; set => strSecondPlayer = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = SetPlayerText();
            CheckForWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = SetPlayerText();
            CheckForWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = SetPlayerText();
            CheckForWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = SetPlayerText();
            CheckForWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = SetPlayerText();
            CheckForWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = SetPlayerText();
            CheckForWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = SetPlayerText();
            CheckForWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = SetPlayerText();
            CheckForWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = SetPlayerText();
            CheckForWinner();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = null;
            button2.Text = null;
            button3.Text = null;
            button4.Text = null;
            button5.Text = null;
            button6.Text = null;
            button7.Text = null;
            button8.Text = null;
            button9.Text = null;
            label3.Text = null;
            whoHaveStep = false;
            DisAbledButtons(true);
        }

        private string SetPlayerText()
        {
            label2.Text = whoHaveStep ? strFirstPlayer : strSecondPlayer;
            whoHaveStep = !whoHaveStep;
            return whoHaveStep ? "X" : "O";
        }

        private void CheckForWinner()
        {

            if((button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") ||
               (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "") ||
               (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "") ||

               (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") ||
               (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") ||
               (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "") ||

               (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") ||
               (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "") 
               )
            {
                label3.Text = "Ура!" + "\"" + (whoHaveStep ? strFirstPlayer : strSecondPlayer) +
                    "\"" + "виграв";
                DisAbledButtons(false);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DisAbledButtons(bool turnOffButtons)
        {
                button1.Enabled = turnOffButtons;
                button2.Enabled = turnOffButtons;
                button3.Enabled = turnOffButtons;
                button4.Enabled = turnOffButtons;
                button5.Enabled = turnOffButtons;
                button6.Enabled = turnOffButtons;
                button7.Enabled = turnOffButtons;
                button8.Enabled = turnOffButtons;
                button9.Enabled = turnOffButtons;
        }
    }
}
