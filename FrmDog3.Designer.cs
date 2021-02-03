namespace ProjetoDesvendandoGramatica
{
    partial class FrmDog3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDog3));
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.cmdDog = new System.Windows.Forms.Button();
            this.cmdGato = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdProximo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(74, 774);
            this.player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(75, 23);
            this.player.TabIndex = 12;
            this.player.Visible = false;
            // 
            // cmdDog
            // 
            this.cmdDog.BackColor = System.Drawing.Color.Transparent;
            this.cmdDog.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.DOGUINHO_removebg_preview;
            this.cmdDog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdDog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDog.FlatAppearance.BorderSize = 0;
            this.cmdDog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDog.Location = new System.Drawing.Point(1224, 281);
            this.cmdDog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdDog.Name = "cmdDog";
            this.cmdDog.Size = new System.Drawing.Size(352, 251);
            this.cmdDog.TabIndex = 11;
            this.cmdDog.Text = "B)CACHORRO";
            this.cmdDog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdDog.UseVisualStyleBackColor = false;
            this.cmdDog.Click += new System.EventHandler(this.cmdDog_Click);
            // 
            // cmdGato
            // 
            this.cmdGato.BackColor = System.Drawing.Color.Transparent;
            this.cmdGato.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.GATO_removebg_preview;
            this.cmdGato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdGato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdGato.FlatAppearance.BorderSize = 0;
            this.cmdGato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGato.Location = new System.Drawing.Point(369, 281);
            this.cmdGato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdGato.Name = "cmdGato";
            this.cmdGato.Size = new System.Drawing.Size(304, 251);
            this.cmdGato.TabIndex = 10;
            this.cmdGato.Text = "A)GATO";
            this.cmdGato.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdGato.UseVisualStyleBackColor = false;
            this.cmdGato.Click += new System.EventHandler(this.cmdGato_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetoDesvendandoGramatica.Properties.Resources.dog;
            this.pictureBox1.Location = new System.Drawing.Point(787, 579);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // cmdProximo
            // 
            this.cmdProximo.BackColor = System.Drawing.Color.Transparent;
            this.cmdProximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdProximo.FlatAppearance.BorderSize = 0;
            this.cmdProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProximo.Location = new System.Drawing.Point(1669, 604);
            this.cmdProximo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdProximo.Name = "cmdProximo";
            this.cmdProximo.Size = new System.Drawing.Size(347, 148);
            this.cmdProximo.TabIndex = 14;
            this.cmdProximo.Text = "PRÓXIMA FASE";
            this.cmdProximo.UseVisualStyleBackColor = false;
            this.cmdProximo.Click += new System.EventHandler(this.cmdProximo_Click);
            // 
            // FrmDog3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.inicial1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 922);
            this.Controls.Add(this.cmdProximo);
            this.Controls.Add(this.player);
            this.Controls.Add(this.cmdDog);
            this.Controls.Add(this.cmdGato);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDog3";
            this.Text = "Pergunta Cachorrinho ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDog3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button cmdDog;
        private System.Windows.Forms.Button cmdGato;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdProximo;
    }
}