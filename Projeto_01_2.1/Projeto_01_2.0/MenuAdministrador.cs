using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_01_2._0
{
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {
            lbusername.Text = Classes.Verificar.NomeUsuario;
            lbtypeuser.Text = Classes.Verificar.tipo;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Desafio_01_Fácil_1 des01 = new Desafio_01_Fácil_1();
            des01.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        { 
                this.Close();
                CadastroAdministrador voltar2 = new CadastroAdministrador();
                voltar2.Show();
        }

        private void novosUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroAdministrador voltarcad = new CadastroAdministrador();
            voltarcad.Show();
        }

        private void trocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
          this.Close();
          Entrada voltaradm = new Entrada();
          voltaradm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
