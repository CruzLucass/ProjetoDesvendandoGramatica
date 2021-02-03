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
    public partial class FrmFimCat : Form
    {
        public FrmFimCat()
        {
            InitializeComponent();
        }
        SoundPlayer sp = new SoundPlayer();
        private void cmdSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmFimCat_Load(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\VoceVenceu.wav";
            sp.Play();
        }

        private void cmdRestart_Click(object sender, EventArgs e)
        {
            FrmPrincipal prin = new FrmPrincipal();
            prin.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCat cat = new FrmCat();
            cat.ShowDialog();
        }
    }
}
