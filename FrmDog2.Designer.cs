namespace ProjetoDesvendandoGramatica
{
    partial class FrmDog2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDog2));
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.cmdRaposa = new System.Windows.Forms.Button();
            this.cmdLeao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdProximo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(65, 729);
            this.player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(75, 23);
            this.player.TabIndex = 8;
            this.player.Visible = false;
            // 
            // cmdRaposa
            // 
            this.cmdRaposa.BackColor = System.Drawing.Color.Transparent;
            this.cmdRaposa.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.RAPOSA_removebg_preview;
            this.cmdRaposa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRaposa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRaposa.FlatAppearance.BorderSize = 0;
            this.cmdRaposa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRaposa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRaposa.Location = new System.Drawing.Point(1337, 363);
            this.cmdRaposa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdRaposa.Name = "cmdRaposa";
            this.cmdRaposa.Size = new System.Drawing.Size(277, 229);
            this.cmdRaposa.TabIndex = 7;
            this.cmdRaposa.Text = "B)RAPOSA";
            this.cmdRaposa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdRaposa.UseVisualStyleBackColor = false;
            this.cmdRaposa.Click += new System.EventHandler(this.cmdRaposa_Click);
            // 
            // cmdLeao
            // 
            this.cmdLeao.BackColor = System.Drawing.Color.Transparent;
            this.cmdLeao.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.LEAO_removebg_preview;
            this.cmdLeao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdLeao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLeao.FlatAppearance.BorderSize = 0;
            this.cmdLeao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLeao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLeao.Location = new System.Drawing.Point(443, 363);
            this.cmdLeao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdLeao.Name = "cmdLeao";
            this.cmdLeao.Size = new System.Drawing.Size(277, 229);
            this.cmdLeao.TabIndex = 6;
            this.cmdLeao.Text = "A)LEÃO";
            this.cmdLeao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdLeao.UseVisualStyleBackColor = false;
            this.cmdLeao.Click += new System.EventHandler(this.cmdLeao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetoDesvendandoGramatica.Properties.Resources.dog;
            this.pictureBox1.Location = new System.Drawing.Point(865, 662);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cmdProximo
            // 
            this.cmdProximo.BackColor = System.Drawing.Color.Transparent;
            this.cmdProximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdProximo.FlatAppearance.BorderSize = 0;
            this.cmdProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProximo.Location = new System.Drawing.Point(1684, 604);
            this.cmdProximo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdProximo.Name = "cmdProximo";
            this.cmdProximo.Size = new System.Drawing.Size(347, 148);
            this.cmdProximo.TabIndex = 13;
            this.cmdProximo.Text = "PRÓXIMA FASE";
            this.cmdProximo.UseVisualStyleBackColor = false;
            this.cmdProximo.Click += new System.EventHandler(this.cmdProximo_Click);
            // 
            // FrmDog2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.inicial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 922);
            this.Controls.Add(this.cmdProximo);
            this.Controls.Add(this.player);
            this.Controls.Add(this.cmdRaposa);
            this.Controls.Add(this.cmdLeao);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDog2";
            this.Text = "Pergunta Cachorrinho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDog2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button cmdRaposa;
        private System.Windows.Forms.Button cmdLeao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdProximo;
    }
}