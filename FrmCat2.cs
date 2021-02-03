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
    public partial class FrmCat2 : Form
    {
        public FrmCat2()
        {
            InitializeComponent();
        }
        SoundPlayer sp = new SoundPlayer();
        private void FrmCat2_Load(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\PerguntaPalavraBrinquedo.wav";
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
            pictureBox1.Width = 280;
            pictureBox1.Height = 265;
            cmdProximo.Enabled = true;
        }

        private void cmdProximo_Click(object sender, EventArgs e)
        {
            FrmCat3 cat3 = new FrmCat3();
            cat3.ShowDialog();
            this.Close();
        }
    }
}
