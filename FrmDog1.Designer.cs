namespace ProjetoDesvendandoGramatica
{
    partial class FrmDog1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDog1));
            this.cmdProximo = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.cmdZangao = new System.Windows.Forms.Button();
            this.cmdZebra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdProximo
            // 
            this.cmdProximo.BackColor = System.Drawing.Color.Transparent;
            this.cmdProximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdProximo.FlatAppearance.BorderSize = 0;
            this.cmdProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProximo.Location = new System.Drawing.Point(1685, 623);
            this.cmdProximo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdProximo.Name = "cmdProximo";
            this.cmdProximo.Size = new System.Drawing.Size(347, 148);
            this.cmdProximo.TabIndex = 17;
            this.cmdProximo.Text = "PRÓXIMA FASE";
            this.cmdProximo.UseVisualStyleBackColor = false;
            this.cmdProximo.Click += new System.EventHandler(this.cmdProximo_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(12, 716);
            this.player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(75, 23);
            this.player.TabIndex = 16;
            this.player.Visible = false;
            // 
            // cmdZangao
            // 
            this.cmdZangao.BackColor = System.Drawing.Color.Transparent;
            this.cmdZangao.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.CAVALO;
            this.cmdZangao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdZangao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdZangao.FlatAppearance.BorderSize = 0;
            this.cmdZangao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdZangao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdZangao.Location = new System.Drawing.Point(1293, 315);
            this.cmdZangao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdZangao.Name = "cmdZangao";
            this.cmdZangao.Size = new System.Drawing.Size(277, 251);
            this.cmdZangao.TabIndex = 15;
            this.cmdZangao.Text = "B)CAVALO";
            this.cmdZangao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdZangao.UseVisualStyleBackColor = false;
            this.cmdZangao.Click += new System.EventHandler(this.cmdZangao_Click);
            // 
            // cmdZebra
            // 
            this.cmdZebra.BackColor = System.Drawing.Color.Transparent;
            this.cmdZebra.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.PASSARO;
            this.cmdZebra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdZebra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdZebra.FlatAppearance.BorderSize = 0;
            this.cmdZebra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdZebra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdZebra.Location = new System.Drawing.Point(431, 315);
            this.cmdZebra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdZebra.Name = "cmdZebra";
            this.cmdZebra.Size = new System.Drawing.Size(304, 251);
            this.cmdZebra.TabIndex = 14;
            this.cmdZebra.Text = "A)PÁSSARO";
            this.cmdZebra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdZebra.UseVisualStyleBackColor = false;
            this.cmdZebra.Click += new System.EventHandler(this.cmdZebra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetoDesvendandoGramatica.Properties.Resources.dog;
            this.pictureBox1.Location = new System.Drawing.Point(900, 729);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDog1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.inicial1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1012);
            this.Controls.Add(this.cmdProximo);
            this.Controls.Add(this.player);
            this.Controls.Add(this.cmdZangao);
            this.Controls.Add(this.cmdZebra);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDog1";
            this.Text = "Pergunta Cachorrinho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDog1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdProximo;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button cmdZangao;
        private System.Windows.Forms.Button cmdZebra;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}