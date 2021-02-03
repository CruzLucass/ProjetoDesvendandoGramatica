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
    public partial class FrmCat : Form
    {
        public FrmCat()
        {
            InitializeComponent();
        }
        SoundPlayer sp = new SoundPlayer();
        private void FrmCat_Load(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\PerguntaPalavraArara.wav";
            sp.Play();
            cmdProximo.Enabled = false;
        }

        private void cmdA_Click(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\Errou.wav";
            sp.Play();
        }

        private void cmdB_Click(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\ProximaBixoCresce.wav";
            sp.Play();
            pictureBox1.Width = 210;
            pictureBox1.Height = 180;
            cmdProximo.Enabled = true;
        }

        private void cmdProximo_Click(object sender, EventArgs e)
        {
            FrmCat1 cat1 = new FrmCat1();
            cat1.ShowDialog();
            this.Close();
        }
    }
}
