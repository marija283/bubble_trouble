using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubble_Trouble
{
    public partial class Main : Form
    {
        System.Media.SoundPlayer BackgroundMusic = new System.Media.SoundPlayer(Bubble_Trouble.Properties.Resources.back);
        public Main()
        {
                        InitializeComponent();
                        this.FormBorderStyle = FormBorderStyle.FixedSingle;
                        StartPosition = FormStartPosition.CenterScreen;
                        BackgroundMusic.PlayLooping();

        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            HowToPlay htp = new HowToPlay();
            this.Hide();
            htp.ShowDialog();
            this.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Quit quit = new Quit();
            {
                if (quit.ShowDialog() == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Form1 play = new Form1();
            this.Hide();
            BackgroundMusic.Stop();
            play.ShowDialog();
            this.Show();
            BackgroundMusic.PlayLooping();

            
        }
    }
}
