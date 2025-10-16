namespace HeianFilms
{
    partial class Cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.btCriar = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.chkBot = new System.Windows.Forms.CheckBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Serif Cond", 13.8F);
            this.label1.Location = new System.Drawing.Point(260, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome de usuario:";
            // 
            // btCriar
            // 
            this.btCriar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCriar.Location = new System.Drawing.Point(267, 356);
            this.btCriar.Name = "btCriar";
            this.btCriar.Size = new System.Drawing.Size(145, 36);
            this.btCriar.TabIndex = 1;
            this.btCriar.Text = "Cadastrar";
            this.btCriar.UseVisualStyleBackColor = false;
            this.btCriar.Click += new System.EventHandler(this.btCriar_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtUser.Location = new System.Drawing.Point(266, 106);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(316, 34);
            this.txtUser.TabIndex = 3;
            this.txtUser.TextChanged += new System.EventHandler(this.txtCNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Serif Cond", 13.8F);
            this.label2.Location = new System.Drawing.Point(262, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Serif Cond", 13.8F);
            this.label3.Location = new System.Drawing.Point(262, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmar senha:";
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSair.Location = new System.Drawing.Point(438, 356);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(145, 36);
            this.btSair.TabIndex = 8;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // chkBot
            // 
            this.chkBot.AutoSize = true;
            this.chkBot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkBot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkBot.Location = new System.Drawing.Point(267, 313);
            this.chkBot.Name = "chkBot";
            this.chkBot.Size = new System.Drawing.Size(132, 20);
            this.chkBot.TabIndex = 2;
            this.chkBot.Text = "Não sou um robo";
            this.chkBot.UseVisualStyleBackColor = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSenha.Location = new System.Drawing.Point(268, 182);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(316, 34);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtCSenha_TextChanged);
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtConfirmar.Location = new System.Drawing.Point(267, 263);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(316, 34);
            this.txtConfirmar.TabIndex = 10;
            this.txtConfirmar.TextChanged += new System.EventHandler(this.txtConfirmar_TextChanged);
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(268, 408);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(10, 16);
            this.lblConta.TabIndex = 11;
            this.lblConta.Text = ".";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.chkBot);
            this.Controls.Add(this.btCriar);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCriar;
        private System.Windows.Forms.CheckBox chkBot;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label lblConta;
    }
}