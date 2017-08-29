using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace RussianRoulette2
{
    public partial class Form2 : Form
    {   int BulletPosition;
        int ShotCount = -1;
        int Count = 0;
        double Score = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit application?", "", MessageBoxButtons.YesNo) ==
               DialogResult.Yes)
            {
                //exit button that closes application
                Application.Exit();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Form1 g = new Form1();
           this.Hide();
            //g.ShowDialog();
        }

        private void btnLoadGun_Click(object sender, EventArgs e)
        {
            //int check = 0;

            Random rand = new Random();
            int[] Bullet = {0,0,0,0,0,0};
            BulletPosition = rand.Next(0, 6);
            Bullet[BulletPosition] = 1;
            //listBox1.DataSource = Bullet;
            btnLoadGun.Enabled = false; //Load Gun button Disabled
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (rbtnGunatOpponent.Checked == true)
                Count = Count + 1;
           
               
                            ShotCount = ShotCount + 1;
            if (ShotCount == BulletPosition)
            {
            
                MessageBox.Show("Fire");
                if (rbtnGunonMe.Checked == true)
                    MessageBox.Show("You lose");
                if (rbtnGunatOpponent.Checked == true)
                    MessageBox.Show("You win");
              btnSave.Enabled = true;
            }
            else
            {
                if (rbtnGunonMe.Checked == true)
                    Score = Score + 25;
                if (rbtnGunatOpponent.Checked == true)
                    Score = Score - 25;
            }
            if (Count == 2)
            {
                 rbtnGunatOpponent.Enabled = false;
                rbtnGunonMe.Checked = true;
            }
            

            //ShotFiredMe = Convert.ToInt16(rbtnGunonMe.Text);
            // Score = Convert.ToInt16(rbtnGunonMe.Text);

            //if (ShotFiredMe == BulletPosition)
            //{
            //    ; //Score = Score + 25; //End Game
            //}
           
            //if (GunClickMe == BulletPosition == false) //|| rbtnGunonMe.Enabled == true || rbtnGunatOpponent.Enabled == false)
            //    {
                
            //    Score = Score + 25;
            //}
            //else if (GunClick == BulletPosition == false) //|| rbtnGunatOpponent.Enabled == true || rbtnGunonMe.Enabled == false)
            //{
            //    rbtnGunatOpponent.Enabled = true;
            //    Score = Score - 25;
            //}
            //if (ShotFired == BulletPosition)
            //{
            //    Score = Score + 40;
            //}


            //double ShotFiredMe = 0;
            //double ShotMissMe = 0;
            //double GunClickMe = 0;

            //double Score = 0;

            //double ShotFired = 0;
            //double ShotMiss = 0;
            //double GunClick = 0;


            //btnFireGun() this is the fire gun button
            lblScore.Text = Convert.ToString(Score);
        }

        private void btnAddBullet_Click(object sender, EventArgs e)
        {






            btnAddBullet.Enabled = false;
            //Add another bullet to your pile when the bullet is extinguished and your opponent is hit.
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string PlayerName;
            string Score;

            PlayerName = txtName.Text;
            Score = lblScore.Text;

            //code to write a file
            try
            {
                string path = @"C:\test\PlayerScore.txt";

                if (!File.Exists(path))
                {
                    // be careful when adding.. it adds but does not notify or show you it has added
                    // create a new file if it does not exist and add to it
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(PlayerName + "," + Score);
                        // sw.WriteLine(Course);
                        // sw.WriteLine(Result);
                    }
                }
                else
                {
                    // Append to the file
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(PlayerName + "," + Score);
                        //sw.WriteLine(Course);
                        //sw.WriteLine(Result);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("File seems to be missing. Please check the path.");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
                playaudio(); // calling the function
            }

            private void playaudio() // defining the function
            {
            SoundPlayer audio = new SoundPlayer(RussianRoulette2.Properties.Resources.Apache); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
                audio.Play();
            }
        }
    }

