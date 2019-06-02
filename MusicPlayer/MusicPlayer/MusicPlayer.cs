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

        private void SelectSong(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\Windows\media",
                Title = "Browse Audio Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "wav",
                Filter = "wav | *",
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }
        // This button allows the media to be played using the built in sound player
        private void Play(object sender, EventArgs e)
        {
            SoundPlayer songSelected = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            songSelected.Play();
        }
    }
}
