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
    public partial class FrmDog2 : Form
    {
        public FrmDog2()
        {
            InitializeComponent();
        }
        SoundPlayer sp = new SoundPlayer();
        private void FrmDog2_Load(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\PerguntaAondeEstaLeao.wav";
            sp.Play();
            cmdProximo.Enabled = false;
        }

        private void cmdRaposa_Click(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\Errou.wav";
            sp.Play();
        }

        private void cmdLeao_Click(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\ProximaBixoCresce.wav";
            sp.Play();
            pictureBox1.Width = 280;
            pictureBox1.Height = 265;
            cmdProximo.Enabled = true;
        }

        private void cmdProximo_Click(object sender, EventArgs e)
        {
            FrmDog3 dog3 = new FrmDog3();
            dog3.ShowDialog();
            this.Close();
        }
    }
}
