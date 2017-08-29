using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RussianRoulette2
{
    public partial class HighScores : Form
    {
        public HighScores()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit application?", "", MessageBoxButtons.YesNo) ==
               DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void DGStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string path = @"C:\test\PlayerScore.txt";
            DGStudent.Rows.Clear();
            DGStudent.Refresh();
            if (File.Exists(path))
            {
                //then read it
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null) 
                    {
                        DGStudent.Text = DGStudent.Text + "\r\n" + line;
                        // to seperate out the commmas
                        string[] split = line.Split(',');
                        DGStudent.Rows.Add(split[0], split[1]);

                    }
                }
            }
    }

        private void HighScores_Load(object sender, EventArgs e)
        {
            
        }
    }
    }
