using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICTACTOE
{
   
    public partial class Form1 : Form
    {
        int count = 0;
        bool isXorO;
        

        void disAbler()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false; 
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;

        }

            public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            count = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                btn3.Text = "X";
btn3.Enabled = false;
                isXorO = false;
            }
            else if (!isXorO)
            {
                isXorO = true;
                count += 1;
                btn3.Text = "O";
                btn3.Enabled = false;

                if (btn1.Text == "O" && btn2.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btn5.Text == "O" && btn7.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btn6.Text == "O" && btn9.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }

            }
            else
            {
                count += 1;
                isXorO = false;
                btn3.Text = "X";
                btn3.Enabled = false;

                if (btn1.Text == "X" && btn2.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }
                if (btn5.Text == "X" && btn7.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }
                if (btn6.Text == "X" && btn9.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }

            }

            if (count == 9)
            {
                MessageBox.Show("Game is draw!!");
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                btn1.Text = "X";
btn1.Enabled = false;
                isXorO = false;
            }
            else if (!isXorO)
            {
                isXorO = true;
                count += 1;
                btn1.Text = "O";
                btn1.Enabled = false;

                if (btn2.Text == "O" && btn3.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btn4.Text == "O" && btn7.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btn5.Text == "O" && btn9.Text == "O")
                {
                            disAbler();
                            MessageBox.Show("Player O wins the game!");
                }

            }
            else
            {
                count += 1;
                isXorO = false;
                btn1.Text = "X";
                btn1.Enabled = false;

                if (btn2.Text == "x" && btn3.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }
                if (btn4.Text == "X" && btn7.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }
                if (btn5.Text == "X" && btn9.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }

            }

            if (count == 9)
            {
                    MessageBox.Show("Game is draw!!");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                btn2.Text = "X";
            btn2.Enabled = false;
                isXorO = false;
            }
            else if (!isXorO)
            {
                isXorO = true;
                count += 1;
                btn2.Text = "O";
                btn2.Enabled = false;

                if (btn1.Text == "O" && btn3.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btn5.Text == "O" && btn7.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }

            }
            else
            {
                count += 1;
                isXorO = false;
                btn2.Text = "X";
                btn2.Enabled = false;

                if (btn1.Text == "X" && btn3.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }
                if (btn5.Text == "X" && btn7.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }

            }

            if (count == 9)
            {
                MessageBox.Show("Game is draw!!");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                btn4.Text = "X";
btn4.Enabled = false;
                isXorO = false;
            }
            else if (!isXorO)
            {
                isXorO = true;
                count += 1;
                btn4.Text = "O";
                btn4.Enabled = false;

                if (btn1.Text == "O" && btn7.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btn5.Text == "O" && btn6.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }

            }
            else
            {
                count += 1;
                isXorO = false;
                btn4.Text = "X";
                btn4.Enabled = false;

                if (btn1.Text == "X" && btn7.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }
                if (btn5.Text == "X" && btn6.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }

            }

            if (count == 9)
            {
                MessageBox.Show("Game is draw!!");
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                btn5.Text = "X";
btn5.Enabled = false;
                isXorO = false;
            }
            else if (!isXorO)
            {
                isXorO = true;
                count += 1;
                btn5.Text = "O";
                btn5.Enabled = false;

                if (btn1.Text == "O" && btn9.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btn2.Text == "O" && btn8.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btn3.Text == "O" && btn7.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btn4.Text == "O" && btn6.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }

            }
            else
            {
                count += 1;
                isXorO = false;
                btn5.Text = "X";
                btn5.Enabled = false;

                if (btn1.Text == "X" && btn9.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }
                if (btn2.Text == "X" && btn8.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player x wins the game!");
                }
                if (btn3.Text == "X" && btn7.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }
                if (btn4.Text == "x" && btn6.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }

            }

            if (count == 9)
            {
                MessageBox.Show("Game is draw!!");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                btn6.Text = "X";
btn6.Enabled = false;
                isXorO = false;
            }
            else if (!isXorO)
            {
                isXorO = true;
                count += 1;
                btn6.Text = "O";
                btn6.Enabled = false;

                if (btn3.Text == "O" && btn9.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btn4.Text == "O" && btn5.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }

            }
            else
            {
                count += 1;
                isXorO = false;
                btn6.Text = "X";
                btn6.Enabled = false;

                if (btn3.Text == "X" && btn9.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }
                if (btn4.Text == "X" && btn5.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }

            }

            if (count == 9)
            {
                MessageBox.Show("Game is draw!!");
            }

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                btn7.Text = "X";
btn7.Enabled = false;
                isXorO = false;
            }
            else if (!isXorO)
            {
                isXorO = true;
                count += 1;
                btn7.Text = "O";
                btn7.Enabled = false;

                if (btn1.Text == "O" && btn4.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btn3.Text == "O" && btn5.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btn8.Text == "O" && btn9.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }

            }
            else
            {
                count += 1;
                isXorO = false;
                btn7.Text = "X";
                btn7.Enabled = false;

                if (btn1.Text == "X" && btn4.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }
                if (btn3.Text == "X" && btn5.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }
                if (btn8.Text == "X" && btn9.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }

            }

            if (count == 9)
            {
                MessageBox.Show("Game is draw!!");
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                btn8.Text = "X";
btn8.Enabled = false;
                isXorO = false;
            }
            else if (!isXorO)
            {
                isXorO = true;
                count += 1;
                btn8.Text = "O";
                btn8.Enabled = false;

                if (btn2.Text == "O" && btn5.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btn7.Text == "O" && btn9.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }

            }
            else
            {
                count += 1;
                isXorO = false;
                btn8.Text = "X";
                btn8.Enabled = false;

                if (btn2.Text == "X" && btn5.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }
                if (btn7.Text == "X" && btn9.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }

            }

            if (count == 9)
            {
                MessageBox.Show("Game is draw!!");
            }

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                btn9.Text = "X";
btn9.Enabled = false;
                isXorO = false;
            }
            else if (!isXorO)
            {
                isXorO = true;
                count += 1;
                btn9.Text = "O";
                btn9.Enabled = false;

                if (btn3.Text == "O" && btn6.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btn1.Text == "O" && btn5.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btn7.Text == "O" && btn8.Text == "O")
                {
                    disAbler();
                    MessageBox.Show("Player O wins the game!");
                }

            }
            else
            {
                count += 1;
                isXorO = false;
                btn9.Text = "X";
                btn9.Enabled = false;

                if (btn3.Text == "X" && btn6.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }
                if (btn1.Text == "X" && btn5.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }
                if (btn7.Text == "X" && btn8.Text == "X")
                {
                    disAbler();
                    MessageBox.Show("Player X wins the game!");
                }

            }

            if (count == 9)
            {
                MessageBox.Show("Game is draw!!");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btn1.Enabled = true;
            btn1.Text = "";
            btn2.Enabled = true;
            btn2.Text = "";
            btn3.Enabled = true;
            btn3.Text = "";
            btn4.Enabled = true;
            btn4.Text = "";
            btn5.Enabled = true;
            btn5.Text = "";
            btn6.Enabled = true;
            btn6.Text = "";
            btn7.Enabled = true;
            btn7.Text = "";
            btn8.Enabled = true;
            btn8.Text = "";
            btn9.Enabled = true;
            btn9.Text = "";

            count = 0;
        }
    }
}
