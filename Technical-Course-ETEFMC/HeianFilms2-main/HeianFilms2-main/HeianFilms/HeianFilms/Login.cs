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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HeianFilms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro Cdr = new Cadastro();
            Cdr.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\HeianFilms\Cadastros\" + txtUsername.Text + ".txt"))
            {
                StreamReader sr = new StreamReader(@"C:\HeianFilms\Cadastros\" + txtUsername.Text + ".txt");
                if (sr.ReadLine() == txtPassword.Text)
                {
                    Programa pr = new Programa();
                    this.Hide();
                    pr.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Senha incorreta.");
                }
            }
            else
            {
                MessageBox.Show("Usuario não encontrado.");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            txtPassword.PasswordChar = '●';
        
        }
    }
}
