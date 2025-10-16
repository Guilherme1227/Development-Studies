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
    public partial class HeianFilms : Form
    {
        public HeianFilms()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HeianFilms_Load(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\HeianFilms\Cadastros\");

            if (!Directory.Exists(@"C:\HeianFilms\Cadastros\"))
            {
                d.Create();
            }
            else
            {
                return;
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {

        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            Cadastro ctd = new Cadastro();
            this.Hide();
            ctd.ShowDialog();
            this.Close();
        }
    }
}
