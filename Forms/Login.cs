using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_despesas_domesticas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string nome = guna2TextBox1.Text;
            string senha = guna2TextBox2.Text;

            bool usuario_encontrado = false;

            
            foreach (var usuario in Repositorio_Usuarios.Usuarioscadastrados)
            {
                if (usuario.nome == nome && usuario.senha == senha)
                {
                    usuario_encontrado = true;
                    break;
                }
            }

            if (usuario_encontrado)
            {
                Dashboard dashboard = new Dashboard(nome);
                dashboard.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos");
            }
        }
    }
}
