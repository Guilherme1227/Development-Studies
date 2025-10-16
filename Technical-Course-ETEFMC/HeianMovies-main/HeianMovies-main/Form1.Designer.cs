
namespace HeianMovies
{
    partial class HeianFilms
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
            this.btLogin = new System.Windows.Forms.Button();
            this.btCadastro = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLogin.Font = new System.Drawing.Font("Noto Serif Cond", 14.25F);
            this.btLogin.Location = new System.Drawing.Point(55, 144);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(147, 38);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btCadastro
            // 
            this.btCadastro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCadastro.Font = new System.Drawing.Font("Noto Serif Cond", 14.25F);
            this.btCadastro.Location = new System.Drawing.Point(55, 199);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(147, 38);
            this.btCadastro.TabIndex = 3;
            this.btCadastro.Text = "Cadastro";
            this.btCadastro.UseVisualStyleBackColor = false;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSair.Font = new System.Drawing.Font("Noto Serif Cond", 12F);
            this.btSair.Location = new System.Drawing.Point(55, 273);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(147, 31);
            this.btSair.TabIndex = 4;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // HeianFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(253, 398);
            this.ControlBox = false;
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.btLogin);
            this.Font = new System.Drawing.Font("Noto Serif Cond", 8.249999F);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HeianFilms";
            this.Text = "Heian Films";
            this.Load += new System.EventHandler(this.HeianFilms_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Button btSair;
    }
}

