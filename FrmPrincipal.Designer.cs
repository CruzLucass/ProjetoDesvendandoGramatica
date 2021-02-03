namespace ProjetoDesvendandoGramatica
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.cmdDog = new System.Windows.Forms.Button();
            this.cmdCat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdCredito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdDog
            // 
            this.cmdDog.BackColor = System.Drawing.Color.Transparent;
            this.cmdDog.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.dog;
            this.cmdDog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdDog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDog.FlatAppearance.BorderSize = 0;
            this.cmdDog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDog.Location = new System.Drawing.Point(183, 585);
            this.cmdDog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdDog.Name = "cmdDog";
            this.cmdDog.Size = new System.Drawing.Size(160, 151);
            this.cmdDog.TabIndex = 0;
            this.cmdDog.UseVisualStyleBackColor = false;
            this.cmdDog.Click += new System.EventHandler(this.cmdDog_Click);
            // 
            // cmdCat
            // 
            this.cmdCat.BackColor = System.Drawing.Color.Transparent;
            this.cmdCat.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.cat;
            this.cmdCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCat.FlatAppearance.BorderSize = 0;
            this.cmdCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCat.Location = new System.Drawing.Point(1693, 574);
            this.cmdCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdCat.Name = "cmdCat";
            this.cmdCat.Size = new System.Drawing.Size(160, 162);
            this.cmdCat.TabIndex = 1;
            this.cmdCat.UseVisualStyleBackColor = false;
            this.cmdCat.Click += new System.EventHandler(this.cmdCat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(944, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "DESVENDANDO A GRAMÁTICA";
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(77, 694);
            this.player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(75, 23);
            this.player.TabIndex = 3;
            this.player.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.iconfinder_Audio_2190991;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(945, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 117);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdCredito
            // 
            this.cmdCredito.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdCredito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCredito.FlatAppearance.BorderSize = 0;
            this.cmdCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCredito.Location = new System.Drawing.Point(12, 3);
            this.cmdCredito.Name = "cmdCredito";
            this.cmdCredito.Size = new System.Drawing.Size(191, 42);
            this.cmdCredito.TabIndex = 5;
            this.cmdCredito.Text = "CRÉDITOS";
            this.cmdCredito.UseVisualStyleBackColor = false;
            this.cmdCredito.Click += new System.EventHandler(this.cmdCredito_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDesvendandoGramatica.Properties.Resources.inicial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1040);
            this.Controls.Add(this.cmdCredito);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdCat);
            this.Controls.Add(this.cmdDog);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrincipal";
            this.Text = "Desvendando a Gramatica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDog;
        private System.Windows.Forms.Button cmdCat;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdCredito;
    }
}

