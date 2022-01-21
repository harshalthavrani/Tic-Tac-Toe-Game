//HThavraniAssignment 1
//Tic-Tac-Toe Game
//Revison History: Harshal Thavrani, 25-09-2021, Created
//Revison History: Harshal Thavrani, 03-10-2021, Comment Added


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using HThavraniAssignment1.Properties;

namespace HThavraniAssignment1
{
    public partial class Form1 : Form
    {
        //Declaring Variables
        int[,] array = new int[3, 3];
        bool check; //Player A's Turn if true and Player B's Turn if false
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            controlimage(pictureBox1, lblplayerab, button1);
            winner();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            controlimage(pictureBox2, lblplayerab, button2);
            winner();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            controlimage(pictureBox3, lblplayerab, button3);
            winner();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            controlimage(pictureBox4, lblplayerab, button4);
            winner();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            controlimage(pictureBox5, lblplayerab, button5);
            winner();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            controlimage(pictureBox6, lblplayerab, button6);
            winner();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            controlimage(pictureBox7, lblplayerab, button7);
            winner();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            controlimage(pictureBox8, lblplayerab, button8);
            winner();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            controlimage(pictureBox9, lblplayerab, button9);
            winner();
        }

        private void controlimage(PictureBox pbox, Label turn, Button btn)
        {
            //If its true then its Player O's Turn
            if (check == true)
            {
                pbox.Image = HThavraniAssignment1.Properties.Resources.O; //Shows The O Image
                check = false; //Changes to Player X's turn
                btn.Text = "O";
                turn.Text = "X";               
            }
            //Else its Player X's Turn
            else
            {
                pbox.Image = HThavraniAssignment1.Properties.Resources.X; //Shows The X Image
                check = true; //Changes to Player O's turn
                btn.Text = "X";
                turn.Text = "O";
            }
            pbox.Enabled = false;
        }
        private void winner()
        {
            //Checking Diagonal 1 for O
            if(button1.Text=="O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Player O Wins", "O Wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
            //Checking Diagonal 2 for O
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Player O Wins", "O Wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
            //Checking Row 1 for O
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("Player O Wins", "O Wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
            //Checking Row 2 for O
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("Player O Wins", "O Wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
            //Checking Row 3 for O
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Player O Wins", "O Wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
            //Checking Column 1 for O
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Player O Wins", "O Wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
            //Checking Column 2 for O
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("Player O Wins", "O Wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
            //Checking Column 3 for O
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Player O Wins", "O Wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
            //Checking Diagonal 1 for X
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Player X Wins", "X Wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
            //Checking Diagonal 2 for X
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Player X Wins", "X Wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
            //Checking Row 1 for X
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("Player X Wins", "X Wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
            //Checking Row 2 for X
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("Player X Wins", "X Wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
            //Checking Row 3 for X
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Player X Wins", "X Wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
            //Checking Column 1 for X
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Player X Wins", "X Wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
            //Checking Column 2 for X
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("Player X Wins", "X Wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
            //Checking Column 3 for X
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Player X Wins", "X Wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
            //Check if tie
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("It's a Tie", "Please Exit", MessageBoxButtons.OK,MessageBoxIcon.Information);
                NewGame();
            }
        }


        //Method for New Game
        private void NewGame()
        {
            PictureBox[] AllPictureBox = {pictureBox1, pictureBox2,pictureBox3,
                                          pictureBox4, pictureBox5,pictureBox6,
                                          pictureBox7, pictureBox8,pictureBox9};

            //Clear all game board cells
            foreach (var p in AllPictureBox)
            {
                p.Image = null;
            }
            //Enabling Picturebox Again So that player can play again
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            //Clearing the current progress
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            //Fresh Start
            check = false;
            lblplayerab.Text = "X";
        }
    }
}

