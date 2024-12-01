using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_despesas_domesticas
{
    public partial class Dashboard : Form
    {
        private string nomeUsuario;
        private List<Despesas> despesas;
        public Dashboard(string nomeUsuario)
        {
            InitializeComponent();
            this.nomeUsuario = nomeUsuario;
            this.Text = $"Bem-vindo, {nomeUsuario}!";
            this.despesas = new List<Despesas>();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string descricao = guna2TextBox1.Text;
            string valor = guna2TextBox2.Text;
            string categoria = guna2ComboBox1.SelectedItem?.ToString();
            DateTime date = DateTime.Now;

            Add_Despesa(descricao, valor, categoria, date);


            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
            guna2ComboBox1.SelectedIndex = -1;

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            var despesa = new Despesas();
            despesa.descricao = guna2TextBox1.Text;
            despesa.valor = guna2TextBox2.Text;
            despesa.categoria = guna2ComboBox1.SelectedItem?.ToString();
            despesa.date = guna2DateTimePicker1.Value;

            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\hp\Desktop\Arquivos jon\despesas.json"))
                {
                    sw.WriteLine(despesa.Serializer(despesa));
                }

                MessageBox.Show("Arquivo salvo");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha " + ex.Message);

            }
        }


        private void Add_Despesa(string descrição, string valor, string categoria, DateTime date)
        {

            guna2DataGridView1.Rows.Add(descrição, valor, categoria, date);
        }





        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

     
        }

       


        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}


