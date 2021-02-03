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

namespace ProjetoDesvendandoGramatica
{
    public partial class FrmDog3 : Form
    {
        public FrmDog3()
        {
            InitializeComponent();
        }
        SoundPlayer sp = new SoundPlayer();
        private void FrmDog3_Load(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\PerguntaCachorro.wav";
            sp.Play();
            cmdProximo.Enabled = false;
        }

        private void cmdGato_Click(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\Errou.wav";
            sp.Play();           
        }

        private void cmdDog_Click(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\ProximaBixoCresce.wav";
            sp.Play();
            pictureBox1.Width = 315;
            pictureBox1.Height = 341;
            cmdProximo.Enabled = true;
        }

        private void cmdProximo_Click(object sender, EventArgs e)
        {
            FrmFinalDog fd = new FrmFinalDog();
            fd.ShowDialog();
            this.Close();
        }
    }
}
