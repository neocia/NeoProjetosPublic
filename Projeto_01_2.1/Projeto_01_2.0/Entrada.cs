using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_01_2._0
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            txtlogin.Text = "";
            txtsenha.Text = "";
            cbtipo.SelectedIndex = -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Verificar.NomeUsuario = txtlogin.Text;
            Classes.Verificar.tipo = cbtipo.Text;


            if (txtlogin.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha todos os campos!");
                Limpar();

            }
            else if (txtsenha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha todos os campos!");
                Limpar();

            }
            else if (cbtipo.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos!");
                Limpar();

            }
            else
            {
                string tipo = "";

                if (cbtipo.SelectedItem.ToString() == "Administrador")
                {
                    tipo = "Administrador";


                }
                else if (cbtipo.SelectedItem.ToString() == "Convidado")
                {
                    tipo = "Convidado";
                }
                Classes.Conexão.Conectar();
                string sql = @" select * from usuario where login_usuario=@login_usuario and senha_usuario=@senha_usuario and tipo_usuario=@tipo_usuario";
                SqlCommand cmd = new SqlCommand(sql, Classes.Conexão.conect);
                cmd.Parameters.AddWithValue("login_usuario", txtlogin.Text);
                cmd.Parameters.AddWithValue("senha_usuario", txtsenha.Text);
                cmd.Parameters.AddWithValue("tipo_usuario", tipo);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    if (tipo == "Administrador")
                    {
                        this.Hide();
                        MenuAdministrador tela = new MenuAdministrador();
                        Classes.Verificar.tipo = "Administrador";
                        tela.Show();

                    }
                    else if (tipo == "Convidado")
                    {
                        this.Hide();
                        MenuConvidado tela = new MenuConvidado();
                        Classes.Verificar.tipo = "Convidado";
                        tela.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Inválidos!");
                }
                dr.Close();
            }

        }

        private void btcadastro_Click(object sender, EventArgs e)
        {
                this.Hide();
                CadastroConvidado cad = new CadastroConvidado();
                cad.Show();
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
