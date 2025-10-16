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

namespace HeianMovies
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


        private void btConfirm_Click(object sender, EventArgs e)
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


