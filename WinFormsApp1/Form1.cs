namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A simple Tic Tac Toe game", "About..", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        decimal x = 0;

        void Reset()
        {
            button1.Text = "-";
            button2.Text = "-";
            button3.Text = "-";
            button4.Text = "-";
            button5.Text = "-";
            button6.Text = "-";
            button7.Text = "-";
            button8.Text = "-";
            button9.Text = "-";
            x = 0;
        }

        string verificare()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text)
                return button1.Text;
            if (button4.Text == button5.Text && button5.Text == button6.Text)
                return button4.Text;
            if (button7.Text == button8.Text && button8.Text == button9.Text)
                return button7.Text;
            if (button1.Text == button4.Text && button4.Text == button7.Text)
                return button1.Text;
            if (button2.Text == button5.Text && button5.Text == button8.Text)
                return button2.Text;
            if (button3.Text == button6.Text && button6.Text == button9.Text)
                return button3.Text;
            if (button1.Text == button5.Text && button5.Text == button9.Text)
                return button1.Text;
            if (button3.Text == button5.Text && button5.Text == button7.Text)
                return button3.Text;
            return "-";
        }
        void Win()
        {
            if (verificare() == "X")
            {
                MessageBox.Show("X wins", "Winner", MessageBoxButtons.OK);
                Reset();
            }
            else if (verificare() == "0")
            {
                MessageBox.Show("0 wins", "Winner", MessageBoxButtons.OK);
                Reset();
            }
            else if (verificare() == "-" && x == 9)
            {
                MessageBox.Show("Draw", "Winner", MessageBoxButtons.OK);
                Reset();
            }


        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "-")
            {
                ++x;
                if (x % 2 == 0)

                    button1.Text = "0";
                else
                    button1.Text = "X";
                Win();


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "-")
            {
                ++x;
                if (x % 2 == 0)

                    button2.Text = "0";
                else
                    button2.Text = "X";
                Win();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "-")
            {
                ++x;
                if (x % 2 == 0)

                    button3.Text = "0";
                else
                    button3.Text = "X";
                Win();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "-")
            {
                ++x;
                if (x % 2 == 0)

                    button4.Text = "0";
                else
                    button4.Text = "X";
                Win();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "-")
            {
                ++x;
                if (x % 2 == 0)

                    button5.Text = "0";
                else
                    button5.Text = "X";
                Win();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "-")
            {
                ++x;
                if (x % 2 == 0)

                    button6.Text = "0";
                else
                    button6.Text = "X";
                Win();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "-")
            {
                ++x;
                if (x % 2 == 0)

                    button7.Text = "0";
                else
                    button7.Text = "X";
                Win();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "-")
            {
                ++x;
                if (x % 2 == 0)

                    button8.Text = "0";
                else
                    button8.Text = "X";
                Win();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "-")
            {
                ++x;
                if (x % 2 == 0)

                    button9.Text = "0";
                else
                    button9.Text = "X";
                Win();
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}