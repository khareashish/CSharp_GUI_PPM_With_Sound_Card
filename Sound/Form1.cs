using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using SlimDX;
using SlimDX.DirectInput;

namespace Sound
{
    public partial class Form1 : Form
    {

        
        private AudioPPM.SoundPlay sndplay;
        private bool playing = false; 

        public Form1()
        {
            InitializeComponent();
            sndplay = new AudioPPM.SoundPlay();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnableDisable();

        }

        private void EnableDisable()
        {
            if (!playing)
            {
                
                BEnablePPM.Text = "Disable PPM";
                sndplay.PlayPPM(this.Handle);
                playing = true;

            }

            else
            {
                BEnablePPM.Text = "Enable PPM";
               
                
                    sndplay.StopPPM();
                
           
                
                playing = false;
            }

        }

        private void DetectB_Click(object sender, EventArgs e)
        {
            Sound.SoundCapture sndcap = new Sound.SoundCapture();
            EAmplitude.Text = sndcap.GetAmplitude().ToString();
        }

        private void EAmplitude_TextChanged(object sender, EventArgs e)
        {
            short val = 32760; //Default amplitude
            if (Int16.TryParse(EAmplitude.Text, out val))
            sndplay.Amplitude = val;
        }


    }
}
