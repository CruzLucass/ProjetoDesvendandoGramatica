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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        SoundPlayer sp;
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            sp = new SoundPlayer();
            sp.SoundLocation = @"audios\inicial.wav";
            sp.Play();          
        }

        private void cmdDog_Click(object sender, EventArgs e)
        {
            FrmDog fd = new FrmDog();
            fd.ShowDialog();
        }

        private void cmdCat_Click(object sender, EventArgs e)
        {
            FrmCat cat = new FrmCat();
            cat.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp.SoundLocation = @"audios\inicial.wav";
            sp.Play();
        }

        private void cmdCredito_Click(object sender, EventArgs e)
        {
            FrmCreditos fc = new FrmCreditos();
            fc.ShowDialog();
        }
    }
}
