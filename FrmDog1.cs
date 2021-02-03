using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace ProjetoDesvendandoGramatica
{
    public partial class FrmDog1 : Form
    {
        public FrmDog1()
        {
            InitializeComponent();
        }
        SoundPlayer sp = new SoundPlayer();
        private void FrmDog1_Load(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\PerguntaPalavraCavalo.wav";
            sp.Play();
            cmdProximo.Enabled = false;
        }

        private void cmdZebra_Click(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\Errou.wav";
            sp.Play();
        }

        private void cmdZangao_Click(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\ProximabixoCresce.wav";
            sp.Play();
            pictureBox1.Width = 250;
            pictureBox1.Height = 225;
            cmdProximo.Enabled = true;
        }

        private void cmdProximo_Click(object sender, EventArgs e)
        {
            FrmDog2 fd = new FrmDog2();
            fd.ShowDialog();
            this.Close();
        }
    }
}
