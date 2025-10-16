using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HeianFilms
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Cadastro_Load(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Castrosoft_Sistemas\Banco_de_Dados\Usuarios");
            if (d.Exists)
            {
                return;
            }
            else
            {
                d.Create();
            }
        }

        private void txtCNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '●';
        }
        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {
            txtConfirmar.PasswordChar = '●';
            if (txtConfirmar.Text == txtSenha.Text)
            {
                lblConta.Text = "Tudo certo!";
            }
            else 
            {
                lblConta.Text = "Senhas diferentes!";
            }
        }

        public void btCriar_Click(object sender, EventArgs e)
        {
                string path = (@"C:\HeianFilms\Cadastros\" + txtUser.Text + ".txt");
                if (txtSenha.Text == txtConfirmar.Text)
                {
                    try
                    {
                        if (File.Exists(path))
                        {
                            return;

                        }
                        else
                        {
                            using (var sw = File.CreateText(path))
                            {
                                sw.WriteLine(txtSenha.Text);
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("erro");
                    }

                    try
                    {
                        StreamWriter sw = new StreamWriter(path);

                        sw.WriteLine(txtSenha.Text);
                        MessageBox.Show("testetop");
                        sw.Close();

                         Login lg = new Login();
                         this.Hide();
                         lg.ShowDialog();
                         this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("erro");
                    }
                }
                else
                    MessageBox.Show("Suas senhas não batem.");
            
        }

      
    }
}
