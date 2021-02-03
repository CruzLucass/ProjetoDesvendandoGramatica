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
    public partial class FrmCat1 : Form
    {
        public FrmCat1()
        {
            InitializeComponent();
        }
        SoundPlayer sp = new SoundPlayer();
        private void FrmCat1_Load(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\PerguntaSaponaoLava.wav";
            sp.Play();
            cmdProximo.Enabled = false;
        }

        private void cmdB_Click(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\Errou.wav";
            sp.Play();            
        }

        private void cmdA_Click(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\ProximaBixoCresce.wav";
            sp.Play();            
            pictureBox1.Width = 250;
            pictureBox1.Height = 225;
            cmdProximo.Enabled = true;
        }

        private void cmdProximo_Click(object sender, EventArgs e)
        {
            FrmCat2 cat2 = new FrmCat2();
            cat2.ShowDialog();
            this.Close();
        }
    }
}
