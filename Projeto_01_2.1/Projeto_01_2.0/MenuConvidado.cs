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
    public partial class MenuConvidado : Form
    {
        public MenuConvidado()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Desafio_01_Fácil_1 desafioI = new Desafio_01_Fácil_1();
            desafioI.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                lbusername.Text = Classes.Verificar.NomeUsuario;
                lbtypeuser.Text = Classes.Verificar.tipo;
            
        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Entrada voltarI = new Entrada();
            voltarI.Show();
        }
    }
}
