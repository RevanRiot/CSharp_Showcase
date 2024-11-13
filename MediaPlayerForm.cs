// File: MediaPlayerForm.cs

using System;
using System.Windows.Forms;

namespace MediaPlayerApp
{
    public partial class MediaPlayerForm : Form
    {
        public MediaPlayerForm()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            mediaControl.URL = fileTextBox.Text;
            mediaControl.Ctlcontrols.play();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            mediaControl.Ctlcontrols.pause();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            mediaControl.Ctlcontrols.stop();
        }
    }
}
