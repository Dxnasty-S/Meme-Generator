namespace Meme_Generator
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.caixaDeTextoCima = new System.Windows.Forms.TextBox();
            this.caixaDeTextoBaixo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imagem = new System.Windows.Forms.PictureBox();
            this.txtDeCima = new System.Windows.Forms.Label();
            this.txtDeBaixo = new System.Windows.Forms.Label();
            this.btAbrir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.caixaDeTextoBaixo);
            this.groupBox1.Controls.Add(this.caixaDeTextoCima);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 466);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar";
            // 
            // caixaDeTextoCima
            // 
            this.caixaDeTextoCima.Location = new System.Drawing.Point(6, 71);
            this.caixaDeTextoCima.Multiline = true;
            this.caixaDeTextoCima.Name = "caixaDeTextoCima";
            this.caixaDeTextoCima.Size = new System.Drawing.Size(273, 100);
            this.caixaDeTextoCima.TabIndex = 0;
            this.caixaDeTextoCima.TextChanged += new System.EventHandler(this.caixaDeTextoCima_TextChanged);
            // 
            // caixaDeTextoBaixo
            // 
            this.caixaDeTextoBaixo.Location = new System.Drawing.Point(6, 262);
            this.caixaDeTextoBaixo.Multiline = true;
            this.caixaDeTextoBaixo.Name = "caixaDeTextoBaixo";
            this.caixaDeTextoBaixo.Size = new System.Drawing.Size(273, 100);
            this.caixaDeTextoBaixo.TabIndex = 1;
            this.caixaDeTextoBaixo.TextChanged += new System.EventHandler(this.caixaDeTextoBaixo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto de cima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto de baixo";
            // 
            // imagem
            // 
            this.imagem.Location = new System.Drawing.Point(303, 12);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(515, 466);
            this.imagem.TabIndex = 1;
            this.imagem.TabStop = false;
            // 
            // txtDeCima
            // 
            this.txtDeCima.AutoSize = true;
            this.txtDeCima.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeCima.ForeColor = System.Drawing.Color.White;
            this.txtDeCima.Location = new System.Drawing.Point(461, 37);
            this.txtDeCima.Name = "txtDeCima";
            this.txtDeCima.Size = new System.Drawing.Size(219, 43);
            this.txtDeCima.TabIndex = 2;
            this.txtDeCima.Text = "TEXTO DE CIMA";
            this.txtDeCima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDeBaixo
            // 
            this.txtDeBaixo.AutoSize = true;
            this.txtDeBaixo.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeBaixo.ForeColor = System.Drawing.Color.White;
            this.txtDeBaixo.Location = new System.Drawing.Point(436, 331);
            this.txtDeBaixo.Name = "txtDeBaixo";
            this.txtDeBaixo.Size = new System.Drawing.Size(230, 43);
            this.txtDeBaixo.TabIndex = 3;
            this.txtDeBaixo.Text = "TEXTO DE BAIXO";
            this.txtDeBaixo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAbrir
            // 
            this.btAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrir.Location = new System.Drawing.Point(223, 516);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(192, 133);
            this.btAbrir.TabIndex = 4;
            this.btAbrir.Text = "Abrir";
            this.btAbrir.UseVisualStyleBackColor = true;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(421, 516);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(192, 133);
            this.btSalvar.TabIndex = 5;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 685);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.txtDeBaixo);
            this.Controls.Add(this.txtDeCima);
            this.Controls.Add(this.imagem);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(860, 724);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(860, 724);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Meme Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox caixaDeTextoBaixo;
        private System.Windows.Forms.TextBox caixaDeTextoCima;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imagem;
        private System.Windows.Forms.Label txtDeCima;
        private System.Windows.Forms.Label txtDeBaixo;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.Button btSalvar;
    }
}

