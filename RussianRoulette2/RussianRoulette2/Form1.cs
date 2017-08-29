using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulette2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartPlay_Click(object sender, EventArgs e)
        {
            Form2 g = new Form2();

            g.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            /* Determines whether the user wants to exit the application.
             * If not, adds another number to the list box. */
            if (MessageBox.Show("Exit application?", "", MessageBoxButtons.YesNo) ==
               DialogResult.Yes)
            {

Application.Exit();
            }
            //{
            //    // Increments the counter ands add the number to the list box.
            //    i++;
            //    listBox1.Items.Add(i);
            //}

            // The user wants to exit the application. Close everything down.
            
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            Instructions g = new Instructions();

            g.Show();
        }

        private void btnHighscore_Click(object sender, EventArgs e)
        {
            HighScores b = new HighScores();
            b.Show();
        }
    }
}
