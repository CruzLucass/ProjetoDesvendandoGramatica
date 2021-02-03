namespace ProjetoDesvendandoGramatica
{
    partial class FrmCat2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCat2));
            this.cmdProximo = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.cmdB = new System.Windows.Forms.Button();
            this.cmdA = new System.Windows.Forms.Button();
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
            this.cmdProximo.Location = new System.Drawing.Point(1679, 571);
            this.cmdProximo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdProximo.Name = "cmdProximo";
            this.cmdProximo.Size = new System.Drawing.Size(347, 148);
            this.cmdProximo.TabIndex = 22;
            this.cmdProximo.Text = "PRÓXIMA FASE";
            this.cmdProximo.UseVisualStyleBackColor = false;
            this.cmdProximo.Click += new System.EventHandler(this.cmdProximo_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(48, 743);
            this.player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(75, 23);
            this.player.TabIndex = 21;
            this.player.Visible = false;
            // 
            // cmdB
            // 
            this.cmdB.BackColor = System.Drawing.Color.Transparent;
            this.cmdB.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.BRINQUEDO_removebg_preview;
            this.cmdB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdB.FlatAppearance.BorderSize = 0;
            this.cmdB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdB.Location = new System.Drawing.Point(1239, 270);
            this.cmdB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdB.Name = "cmdB";
            this.cmdB.Size = new System.Drawing.Size(353, 218);
            this.cmdB.TabIndex = 20;
            this.cmdB.Text = "B)BRINQUEDO";
            this.cmdB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdB.UseVisualStyleBackColor = false;
            this.cmdB.Click += new System.EventHandler(this.cmdB_Click);
            // 
            // cmdA
            // 
            this.cmdA.BackColor = System.Drawing.Color.Transparent;
            this.cmdA.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.BOLA;
            this.cmdA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdA.FlatAppearance.BorderSize = 0;
            this.cmdA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdA.Location = new System.Drawing.Point(409, 270);
            this.cmdA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdA.Name = "cmdA";
            this.cmdA.Size = new System.Drawing.Size(316, 218);
            this.cmdA.TabIndex = 19;
            this.cmdA.Text = "A)BOLA";
            this.cmdA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdA.UseVisualStyleBackColor = false;
            this.cmdA.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetoDesvendandoGramatica.Properties.Resources.cat;
            this.pictureBox1.Location = new System.Drawing.Point(867, 642);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCat2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.inicial1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 922);
            this.Controls.Add(this.cmdProximo);
            this.Controls.Add(this.player);
            this.Controls.Add(this.cmdB);
            this.Controls.Add(this.cmdA);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCat2";
            this.Text = "Pergunta Gatinho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCat2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdProximo;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button cmdB;
        private System.Windows.Forms.Button cmdA;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}