using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_despesas_domesticas
{
    public partial class Cadastro : Form
    {
        private List<Usuario>usuarios= new List<Usuario>();
        public Cadastro()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string nome = guna2TextBox1.Text;
            string senha = guna2TextBox2.Text;


            foreach(var usuario in Repositorio_Usuarios.Usuarioscadastrados)
            {
                if(usuario.nome == nome)
                {

                    MessageBox.Show("Usuario ja cadastrado.");
                    return;
                }
            }


            Repositorio_Usuarios.Usuarioscadastrados.Add(new Usuario(nome, senha));

            MessageBox.Show("Usuario cadastrado com sucesso");

            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
