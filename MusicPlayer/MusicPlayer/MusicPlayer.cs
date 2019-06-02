using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }

        // This button allows the media to be played using the built in sound player
        private void Play(object sender, EventArgs e)
        {
            SoundPlayer songSelected = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            songSelected.Play();
        }
    }
}
