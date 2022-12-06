using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        private char playerchar = 'O';
        private char guestchar = '\0';
        private char hostchar = '\0';
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game newGame = new Game(hostchar, playerchar, false, textBox1.Text);
            Visible = false;
            if (!newGame.IsDisposed)
                newGame.ShowDialog();
            Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game newGame = new Game(playerchar, guestchar, true);
            Visible = false;
            if (!newGame.IsDisposed)
                newGame.ShowDialog();
            Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            playerchar = 'O';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playerchar = 'X';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            playerchar = 'I';
        }
    }
}
