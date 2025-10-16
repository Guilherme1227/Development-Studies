
namespace HeianMovies
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
            this.btSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSair.Location = new System.Drawing.Point(417, 295);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(135, 40);
            this.btSair.TabIndex = 0;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Serif Cond", 12F);
            this.label1.Location = new System.Drawing.Point(221, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Senha:";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtUser.Font = new System.Drawing.Font("Noto Serif Cond", 12F);
            this.txtUser.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtUser.Location = new System.Drawing.Point(225, 109);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(327, 29);
            this.txtUser.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Serif Cond", 12F);
            this.label4.Location = new System.Drawing.Point(221, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome de usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Serif Cond", 12F);
            this.label5.Location = new System.Drawing.Point(221, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Confirmar Senha:";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtConfirmar.Font = new System.Drawing.Font("Noto Serif Cond", 12F);
            this.txtConfirmar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtConfirmar.Location = new System.Drawing.Point(225, 235);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(327, 29);
            this.txtConfirmar.TabIndex = 9;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtSenha.Font = new System.Drawing.Font("Noto Serif Cond", 12F);
            this.txtSenha.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtSenha.Location = new System.Drawing.Point(225, 170);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(327, 29);
            this.txtSenha.TabIndex = 10;
            // 
            // btConfirm
            // 
            this.btConfirm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btConfirm.Location = new System.Drawing.Point(225, 295);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(135, 40);
            this.btConfirm.TabIndex = 11;
            this.btConfirm.Text = "Confirmar";
            this.btConfirm.UseVisualStyleBackColor = false;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // Cadastro
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(611, 391);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSair);
            this.Font = new System.Drawing.Font("Noto Serif Cond", 14.25F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btConfirm;
    }
}