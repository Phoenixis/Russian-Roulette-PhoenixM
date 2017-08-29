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

namespace RussianRoulette2
{
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EndGame_Load(object sender, EventArgs e)
        {
            playaudio(); // calling the function
        }

        private void playaudio() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(RussianRoulette2.Properties.Resources.GunShot); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }
    
    }
}
