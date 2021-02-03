using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
using System.Windows.Forms;

namespace ProjetoDesvendandoGramatica
{
    public partial class FrmDog : Form
    {
        public FrmDog()
        {
            InitializeComponent();
        }
        SoundPlayer sp = new SoundPlayer();
        private void FrmDog_Load(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\Perguntazebra.wav";
            sp.Play();
            cmdProximo.Enabled = false;
        }

        private void cmdZangao_Click(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\Errou.wav";
            sp.Play();
        }

        private void cmdZebra_Click(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\ProximaBixoCresce.wav";
            sp.Play();
            pictureBox1.Width = 210;
            pictureBox1.Height = 172;
            cmdProximo.Enabled = true;
        }

        private void cmdProximo_Click(object sender, EventArgs e)
        {
            FrmDog1 frmDog1 = new FrmDog1();
            frmDog1.ShowDialog();
            this.Close();
        }
    }
}
