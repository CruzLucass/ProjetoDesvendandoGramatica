namespace ProjetoDesvendandoGramatica
{
    partial class FrmCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCat));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdProximo = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.cmdB = new System.Windows.Forms.Button();
            this.cmdA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetoDesvendandoGramatica.Properties.Resources.cat;
            this.pictureBox1.Location = new System.Drawing.Point(927, 702);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cmdProximo
            // 
            this.cmdProximo.BackColor = System.Drawing.Color.Transparent;
            this.cmdProximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdProximo.FlatAppearance.BorderSize = 0;
            this.cmdProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProximo.Location = new System.Drawing.Point(1680, 580);
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
            this.player.Location = new System.Drawing.Point(30, 725);
            this.player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(75, 23);
            this.player.TabIndex = 16;
            this.player.Visible = false;
            // 
            // cmdB
            // 
            this.cmdB.BackColor = System.Drawing.Color.Transparent;
            this.cmdB.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.ARARA_removebg_preview;
            this.cmdB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdB.FlatAppearance.BorderSize = 0;
            this.cmdB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdB.Location = new System.Drawing.Point(1273, 263);
            this.cmdB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdB.Name = "cmdB";
            this.cmdB.Size = new System.Drawing.Size(283, 266);
            this.cmdB.TabIndex = 15;
            this.cmdB.Text = "B)ARARA";
            this.cmdB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdB.UseVisualStyleBackColor = false;
            this.cmdB.Click += new System.EventHandler(this.cmdB_Click);
            // 
            // cmdA
            // 
            this.cmdA.BackColor = System.Drawing.Color.Transparent;
            this.cmdA.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.GIRAFA_removebg_preview;
            this.cmdA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdA.FlatAppearance.BorderSize = 0;
            this.cmdA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdA.Location = new System.Drawing.Point(407, 263);
            this.cmdA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdA.Name = "cmdA";
            this.cmdA.Size = new System.Drawing.Size(277, 266);
            this.cmdA.TabIndex = 14;
            this.cmdA.Text = "A)GIRAFA";
            this.cmdA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdA.UseVisualStyleBackColor = false;
            this.cmdA.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // FrmCat
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
            this.Name = "FrmCat";
            this.Text = "Pergunta Gatinho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdProximo;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button cmdB;
        private System.Windows.Forms.Button cmdA;
    }
}