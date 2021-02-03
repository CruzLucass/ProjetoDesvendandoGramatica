namespace ProjetoDesvendandoGramatica
{
    partial class FrmDog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDog));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdZebra = new System.Windows.Forms.Button();
            this.cmdZangao = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.cmdProximo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetoDesvendandoGramatica.Properties.Resources.dog;
            this.pictureBox1.Location = new System.Drawing.Point(923, 699);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmdZebra
            // 
            this.cmdZebra.BackColor = System.Drawing.Color.Transparent;
            this.cmdZebra.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.ZEBRA;
            this.cmdZebra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdZebra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdZebra.FlatAppearance.BorderSize = 0;
            this.cmdZebra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdZebra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdZebra.Location = new System.Drawing.Point(436, 287);
            this.cmdZebra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdZebra.Name = "cmdZebra";
            this.cmdZebra.Size = new System.Drawing.Size(283, 212);
            this.cmdZebra.TabIndex = 1;
            this.cmdZebra.Text = "A)ZEBRA";
            this.cmdZebra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdZebra.UseVisualStyleBackColor = false;
            this.cmdZebra.Click += new System.EventHandler(this.cmdZebra_Click);
            // 
            // cmdZangao
            // 
            this.cmdZangao.BackColor = System.Drawing.Color.Transparent;
            this.cmdZangao.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.ZANGAO_removebg_preview;
            this.cmdZangao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdZangao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdZangao.FlatAppearance.BorderSize = 0;
            this.cmdZangao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdZangao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdZangao.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmdZangao.Location = new System.Drawing.Point(1276, 287);
            this.cmdZangao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdZangao.Name = "cmdZangao";
            this.cmdZangao.Size = new System.Drawing.Size(269, 212);
            this.cmdZangao.TabIndex = 2;
            this.cmdZangao.Text = "B)ZANGÃO";
            this.cmdZangao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdZangao.UseVisualStyleBackColor = false;
            this.cmdZangao.Click += new System.EventHandler(this.cmdZangao_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(30, 723);
            this.player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(75, 23);
            this.player.TabIndex = 4;
            this.player.Visible = false;
            // 
            // cmdProximo
            // 
            this.cmdProximo.BackColor = System.Drawing.Color.Transparent;
            this.cmdProximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdProximo.FlatAppearance.BorderSize = 0;
            this.cmdProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProximo.Location = new System.Drawing.Point(1701, 586);
            this.cmdProximo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdProximo.Name = "cmdProximo";
            this.cmdProximo.Size = new System.Drawing.Size(347, 148);
            this.cmdProximo.TabIndex = 12;
            this.cmdProximo.Text = "PRÓXIMA FASE";
            this.cmdProximo.UseVisualStyleBackColor = false;
            this.cmdProximo.Click += new System.EventHandler(this.cmdProximo_Click);
            // 
            // FrmDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.inicial1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 894);
            this.Controls.Add(this.cmdProximo);
            this.Controls.Add(this.player);
            this.Controls.Add(this.cmdZangao);
            this.Controls.Add(this.cmdZebra);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDog";
            this.Text = "Pergunta Cachorro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdZebra;
        private System.Windows.Forms.Button cmdZangao;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button cmdProximo;
    }
}