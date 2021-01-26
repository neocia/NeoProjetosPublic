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
    public partial class CadastroConvidado : Form
    {
        public CadastroConvidado()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            txtnome.Text = "";
            txtusuario.Text = "";
            txtpass.Text = "";
            cbtype.Text = "";
        }
        private void btacessar_Click(object sender, EventArgs e)
        {

            if (txtnome.Text.Trim().Length==0 && txtusuario.Text.Trim().Length==0 && txtpass.Text.Trim().Length==0 &&  cbtype.Text.Trim().Length==-1)
            {
                MessageBox.Show("Preencha todos os campos!!");
            }
            else if (txtnome.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o Nome Completo!");
            }
            else if (txtusuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o Nome de Usuário!");

            }
            else if (cbtype.Text.Trim().Length == -1)
            {
                MessageBox.Show("Preencha o Tipo de Usuário!");

            }
            else
            {
                Classes.Conexão.Conectar();
                string sql = @"select * from usuario where login_usuario = @login_usuario ";
                SqlCommand cmd = new SqlCommand(sql, Classes.Conexão.conect);
                cmd.Parameters.AddWithValue("login_usuario", txtusuario.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("Nome de Usuário indisponível! ");

                }else
                    {
                        try
                        {
                            Classes.Conexão.Conectar();
                            Classes.Cadastros.inserir(txtnome.Text,txtusuario.Text,txtpass.Text,cbtype.Text);
                            MessageBox.Show("Usuário Cadastrado!");
                            this.Hide();
                            Entrada back = new Entrada();
                            back.Show();
                            Limpar();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro :" + ex.Message);
                        }
                        finally
                        {
                            Classes.Conexão.Desconectar();
                        }
                    }
                dr.Close();
            }
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Text = "";
            txtusuario.Text = "";
            txtpass.Text = "";
            cbtype.Text = "";
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            string tipo = "";
            if(Classes.Verificar.tipo == "Convidado")
            {
                this.Hide();
                Entrada voltar = new Entrada();
                voltar.Show();

            }else if(Classes.Verificar.tipo == "Administrador")
            {
                this.Close();
                MenuAdministrador voltarII = new MenuAdministrador();
                voltarII.Show();
                Classes.Verificar.tipo = tipo;
                
            }
            else
            {
                this.Close();
                Entrada login = new Entrada();
                login.Show();
            }
            
        }

        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbtipoadm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            
        }
    }
}
