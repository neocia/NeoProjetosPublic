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
    public partial class Desafio_01_Fácil : Form
    {
        int i = 0;
        int correct = 0;

        public Desafio_01_Fácil()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if( bt1.Text == "n" && bt2.Text == "s" && bt3.Text == "n" &&
                bt4.Text == "n" && bt5.Text == "n" && bt6.Text == "s" &&
                bt7.Text == "s" && bt8.Text == "n" && bt9.Text == "n"&&

                bt10.Text == "n" && bt11.Text == "s" && bt12.Text == "n" &&
                bt13.Text == "s" && bt14.Text == "n" && bt15.Text == "n" &&
                bt16.Text == "n" && bt17.Text == "n" && bt18.Text == "s" &&

                bt19.Text == "n" && bt20.Text == "n" && bt21.Text == "s" &&
                bt22.Text == "n" && bt23.Text == "s" && bt24.Text == "n" &&
                bt25.Text == "s" && bt26.Text == "n" && bt27.Text == "n")
            {
               DialogResult op = MessageBox.Show("Vitória!!! Deseja jogar novamente?","WINNER ",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if (op == DialogResult.Yes)
                {
                    Limpar();
                }
                else
                {
                    this.Hide();
                    Form1 menu1 = new Form1();
                    menu1.Show();
                }

            }else if ( bt1.Text != "" && bt2.Text != "" && bt3.Text != "" &&
                       bt4.Text != "" && bt5.Text != "" && bt6.Text != "" &&
                       bt7.Text != "" && bt8.Text != "" && bt9.Text != "" &&

                       bt10.Text != "" && bt11.Text != "" && bt12.Text != "" &&
                       bt13.Text != "" && bt14.Text != "" && bt15.Text != "" &&
                       bt16.Text != "" && bt17.Text != "" && bt18.Text != "" &&

                       bt19.Text != "" && bt20.Text != "" && bt21.Text != "" &&
                       bt22.Text != "" && bt23.Text != "" && bt24.Text != "" &&
                       bt25.Text != "" && bt26.Text != "" && bt27.Text == "n"
                       )
                  {
                   DialogResult op = MessageBox.Show("Perdeu!! Deseja jogar novamente?", "LOSER ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (op == DialogResult.Yes)
                    {
                       Limpar();
                     }else
                      {
                         this.Hide();
                         Form1 menu1 = new Form1();
                         menu1.Show();
                      }
                  }
        }

        private void bt1_Click(object sender, EventArgs e)
        {   correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt1.BackColor = Color.White;
                    bt1.Text = "n";
                }
                else if (correct == 3)
                {
                    bt1.BackColor = Color.White;
                    bt1.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt2.BackColor = Color.White;
                    bt2.Text = "n";
                }
                else if (correct == 3)
                {
                    bt2.BackColor = Color.White;
                    bt2.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt3.BackColor = Color.White;
                    bt3.Text = "n";
                }
                else if (correct == 3)
                {
                    bt3.BackColor = Color.White;
                    bt3.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt4.BackColor = Color.White;
                    bt4.Text = "n";
                }
                else if (correct == 3)
                {
                    bt4.BackColor = Color.White;
                    bt4.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt5.BackColor = Color.White;
                    bt5.Text = "n";
                }
                else if (correct == 3)
                {
                    bt5.BackColor = Color.White;
                    bt5.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt6.BackColor = Color.White;
                    bt6.Text = "n";
                }
                else if (correct == 3)
                {
                    bt6.BackColor = Color.White;
                    bt6.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt7.BackColor = Color.White;
                    bt7.Text = "n";
                }
                else if (correct == 3)
                {
                    bt7.BackColor = Color.White;
                    bt7.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt8.BackColor = Color.White;
                    bt8.Text = "n";
                }
                else if (correct == 3)
                {
                    bt8.BackColor = Color.White;
                    bt8.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt9.BackColor = Color.White;
                    bt9.Text = "n";
                }
                else if (correct == 3)
                {
                    bt9.BackColor = Color.White;
                    bt9.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt10_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt10.BackColor = Color.White;
                    bt10.Text = "n";
                }
                else if (correct == 3)
                {
                    bt10.BackColor = Color.White;
                    bt10.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt11_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt11.BackColor = Color.White;
                    bt11.Text = "n";
                }
                else if (correct == 3)
                {
                    bt11.BackColor = Color.White;
                    bt11.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt12_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt12.BackColor = Color.White;
                    bt12.Text = "n";
                }
                else if (correct == 3)
                {
                    bt12.BackColor = Color.White;
                    bt12.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt13_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt13.BackColor = Color.White;
                    bt13.Text = "n";
                }
                else if (correct == 3)
                {
                    bt13.BackColor = Color.White;
                    bt13.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt14_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt14.BackColor = Color.White;
                    bt14.Text = "n";
                }
                else if (correct == 3)
                {
                    bt14.BackColor = Color.White;
                    bt14.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt15_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt15.BackColor = Color.White;
                    bt15.Text = "n";
                }
                else if (correct == 3)
                {
                    bt15.BackColor = Color.White;
                    bt15.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt16.BackColor = Color.White;
                    bt16.Text = "n";
                }
                else if (correct == 3)
                {
                    bt16.BackColor = Color.White;
                    bt16.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt17_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt17.BackColor = Color.White;
                    bt17.Text = "n";
                }
                else if (correct == 3)
                {
                    bt17.BackColor = Color.White;
                    bt17.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt18_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt18.BackColor = Color.White;
                    bt18.Text = "n";
                }
                else if (correct == 3)
                {
                    bt18.BackColor = Color.White;
                    bt18.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt19_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt19.BackColor = Color.White;
                    bt19.Text = "n";
                }
                else if (correct == 3)
                {
                    bt19.BackColor = Color.White;
                    bt19.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt20_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt20.BackColor = Color.White;
                    bt20.Text = "n";
                }
                else if (correct == 3)
                {
                    bt20.BackColor = Color.White;
                    bt20.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt21_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt21.BackColor = Color.White;
                    bt21.Text = "n";
                }
                else if (correct == 3)
                {
                    bt21.BackColor = Color.White;
                    bt21.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt22_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt22.BackColor = Color.White;
                    bt22.Text = "n";
                }
                else if (correct == 3)
                {
                    bt22.BackColor = Color.White;
                    bt22.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt23_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt23.BackColor = Color.White;
                    bt23.Text = "n";
                }
                else if (correct == 3)
                {
                    bt23.BackColor = Color.White;
                    bt23.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt24_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt24.BackColor = Color.White;
                    bt24.Text = "n";
                }
                else if (correct == 3)
                {
                    bt24.BackColor = Color.White;
                    bt24.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt25_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt25.BackColor = Color.White;
                    bt25.Text = "n";
                }
                else if (correct == 3)
                {
                    bt25.BackColor = Color.White;
                    bt25.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt26_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt26.BackColor = Color.White;
                    bt26.Text = "n";
                }
                else if (correct == 3)
                {
                    bt26.BackColor = Color.White;
                    bt26.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        private void bt27_Click(object sender, EventArgs e)
        {
            correct = correct + 1;
            while (i < correct)
            {
                if (correct == 2)
                {
                    bt27.BackColor = Color.White;
                    bt27.Text = "n";
                }
                else if (correct == 3)
                {
                    bt27.BackColor = Color.White;
                    bt27.Text = "s";
                    i = 0;
                    correct = 0;
                }
                i++;
            }
        }

        public void Limpar()
        {
            bt1.Text = "";
            bt2.Text = "";
            bt3.Text = "";
            bt4.Text = "";
            bt5.Text = "";
            bt6.Text = "";
            bt7.Text = "";
            bt8.Text = "";
            bt9.Text = "";
            bt10.Text = "";
            bt11.Text = "";
            bt12.Text = "";
            bt13.Text = "";
            bt14.Text = "";
            bt15.Text = "";
            bt16.Text = "";
            bt17.Text = "";
            bt18.Text = "";
            bt19.Text = "";
            bt20.Text = "";
            bt21.Text = "";
            bt22.Text = "";
            bt23.Text = "";
            bt24.Text = "";
            bt25.Text = "";
            bt26.Text = "";
            bt27.Text = "";

        }
    }

}
