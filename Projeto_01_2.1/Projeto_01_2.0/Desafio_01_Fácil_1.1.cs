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
    public partial class Desafio_01_Fácil_1 : Form
    {
        private void painelexec_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            Classes.Botões.correct9 = Classes.Botões.correct9 + 1;
            while (Classes.Botões.i9 < Classes.Botões.correct9)
            {
                if (Classes.Botões.correct9 == 2)
                {
                    bt9.BackColor = Color.White;
                    bt9.Text = "n";
                }
                else if (Classes.Botões.correct9 == 3)
                {
                    bt9.BackColor = Color.White;
                    bt9.Text = "s";
                    Classes.Botões.i9 = 0;
                    Classes.Botões.correct9 = 1;
                }
                Classes.Botões.i9++;
            }
        }
        private void bt8_Click(object sender, EventArgs e)
        {
            Classes.Botões.correct8 = Classes.Botões.correct8 + 1;
            while (Classes.Botões.i8 < Classes.Botões.correct8)
            {
                if (Classes.Botões.correct8 == 2)
                {
                    bt8.BackColor = Color.White;
                    bt8.Text = "n";
                }
                else if (Classes.Botões.correct8 == 3)
                {
                    bt8.BackColor = Color.White;
                    bt8.Text = "s";
                    Classes.Botões.i8 = 0;
                    Classes.Botões.correct8 = 1;
                }
                Classes.Botões.i8++;
            }
        }
        private void bt7_Click(object sender, EventArgs e)
        {
            Classes.Botões.correct7 = Classes.Botões.correct7 + 1;
            while (Classes.Botões.i7 < Classes.Botões.correct7)
            {
                if (Classes.Botões.correct7 == 2)
                {
                    bt7.BackColor = Color.White;
                    bt7.Text = "n";
                }
                else if (Classes.Botões.correct7 == 3)
                {
                    bt7.BackColor = Color.White;
                    bt7.Text = "s";
                    Classes.Botões.i7 = 0;
                    Classes.Botões.correct7 = 1;
                }
                Classes.Botões.i7++;
            }
        }
        private void bt6_Click(object sender, EventArgs e)
        {
            Classes.Botões.correct6 = Classes.Botões.correct6 + 1;
            while (Classes.Botões.i6 < Classes.Botões.correct6)
            {
                if (Classes.Botões.correct6 == 2)
                {
                    bt6.BackColor = Color.White;
                    bt6.Text = "n";
                }
                else if (Classes.Botões.correct6 == 3)
                {
                    bt6.BackColor = Color.White;
                    bt6.Text = "s";
                    Classes.Botões.i6 = 0;
                    Classes.Botões.correct6 = 1;

                }
                Classes.Botões.i6++;
            }
        }
        private void bt5_Click(object sender, EventArgs e)
        {
            Classes.Botões.correct5 = Classes.Botões.correct5 + 1;
            while (Classes.Botões.i5 < Classes.Botões.correct5)
            {
                if (Classes.Botões.correct5 == 2)
                {
                    bt5.BackColor = Color.White;
                    bt5.Text = "n";
                }
                else if (Classes.Botões.correct5 == 3)
                {
                    bt5.BackColor = Color.White;
                    bt5.Text = "s";
                    Classes.Botões.i5 = 0;
                    Classes.Botões.correct5 = 1;
                }
                Classes.Botões.i5++;
            }
        }
        private void bt4_Click(object sender, EventArgs e)
        {
            Classes.Botões.correct4 = Classes.Botões.correct4 + 1;
            while (Classes.Botões.i4 < Classes.Botões.correct4)
            {
                if (Classes.Botões.correct4 == 2)
                {
                    bt4.BackColor = Color.White;
                    bt4.Text = "n";
                }
                else if (Classes.Botões.correct4 == 3)
                {
                    bt4.BackColor = Color.White;
                    bt4.Text = "s";
                    Classes.Botões.i4 = 0;
                    Classes.Botões.correct4 = 1;
                }
                Classes.Botões.i4++;
            }
        }
        private void bt3_Click(object sender, EventArgs e)
        {
            Classes.Botões.correct3 = Classes.Botões.correct3 + 1;
            while (Classes.Botões.i3 < Classes.Botões.correct3)
            {
                if (Classes.Botões.correct3 == 2)
                {
                    bt3.BackColor = Color.White;
                    bt3.Text = "n";
                }
                else if (Classes.Botões.correct3 == 3)
                {
                    bt3.BackColor = Color.White;
                    bt3.Text = "s";
                    Classes.Botões.i3 = 0;
                    Classes.Botões.correct3 = 1;
                }
                Classes.Botões.i3++;
            }
        }
        private void bt2_Click(object sender, EventArgs e)
        {
            Classes.Botões.correct2 = Classes.Botões.correct2 + 1;
            while (Classes.Botões.i2 < Classes.Botões.correct2)
            {
                if (Classes.Botões.correct2 == 2)
                {
                    bt2.BackColor = Color.White;
                    bt2.Text = "n";
                }
                else if (Classes.Botões.correct2 == 3)
                {
                    bt2.BackColor = Color.White;
                    bt2.Text = "s";
                    Classes.Botões.i2 = 0;
                    Classes.Botões.correct2 = 1;
                }
                Classes.Botões.i2++;
            }
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            Classes.Botões.correct1 = Classes.Botões.correct1 + 1;
            while (Classes.Botões.i1 < Classes.Botões.correct1)
            {
                if (Classes.Botões.correct1 == 2)
                {
                    bt1.BackColor = Color.White;
                    bt1.Text = "n";
                }
                else if (Classes.Botões.correct1 == 3)
                {
                    bt1.BackColor = Color.White;
                    bt1.Text = "s";
                    Classes.Botões.i1 = 0;
                    Classes.Botões.correct1 = 1;
                }
                Classes.Botões.i1++;
            }
        }
        public Desafio_01_Fácil_1()
        {
            InitializeComponent();
        }
        private void Desafio_01_Fácil_1_Load(object sender, EventArgs e)
        {

        }
        private void bt27_Click(object sender, EventArgs e)
        {
            Classes.Botão_19_27_.correct27 = Classes.Botão_19_27_.correct27 + 1;
            while (Classes.Botão_19_27_.i27 < Classes.Botão_19_27_.correct27)
            {
                if (Classes.Botão_19_27_.correct27 == 2)
                {
                    bt27.BackColor = Color.White;
                    bt27.Text = "n";
                }
                else if (Classes.Botão_19_27_.correct27 == 3)
                {
                    bt27.BackColor = Color.White;
                    bt27.Text = "s";
                    Classes.Botão_19_27_.i27 = 0;
                    Classes.Botão_19_27_.correct27 = 1;
                }
                Classes.Botão_19_27_.i27++;
            }
        }
        private void bt26_Click(object sender, EventArgs e)
        {
            Classes.Botão_19_27_.correct26 = Classes.Botão_19_27_.correct26 + 1;
            while (Classes.Botão_19_27_.i26 < Classes.Botão_19_27_.correct26)
            {
                if (Classes.Botão_19_27_.correct26 == 2)
                {
                    bt26.BackColor = Color.White;
                    bt26.Text = "n";
                }
                else if (Classes.Botão_19_27_.correct26 == 3)
                {
                    bt26.BackColor = Color.White;
                    bt26.Text = "s";
                    Classes.Botão_19_27_.i26 = 0;
                    Classes.Botão_19_27_.correct26 = 1;
                }
                Classes.Botão_19_27_.i26++;
            }
        }
        private void bt25_Click(object sender, EventArgs e)
        {
            Classes.Botão_19_27_.correct25 = Classes.Botão_19_27_.correct25 + 1;
            while (Classes.Botão_19_27_.i25 < Classes.Botão_19_27_.correct25)
            {
                if (Classes.Botão_19_27_.correct25 == 2)
                {
                    bt25.BackColor = Color.White;
                    bt25.Text = "n";
                }
                else if (Classes.Botão_19_27_.correct25 == 3)
                {
                    bt25.BackColor = Color.White;
                    bt25.Text = "s";
                    Classes.Botão_19_27_.i25 = 0;
                    Classes.Botão_19_27_.correct25 = 1;
                }
                Classes.Botão_19_27_.i25++;
            }
        }
        private void bt24_Click(object sender, EventArgs e)
        {
            Classes.Botão_19_27_.correct24 = Classes.Botão_19_27_.correct24 + 1;
            while (Classes.Botão_19_27_.i24 < Classes.Botão_19_27_.correct24)
            {
                if (Classes.Botão_19_27_.correct24 == 2)
                {
                    bt24.BackColor = Color.White;
                    bt24.Text = "n";
                }
                else if (Classes.Botão_19_27_.correct24 == 3)
                {
                    bt24.BackColor = Color.White;
                    bt24.Text = "s";
                    Classes.Botão_19_27_.i24 = 0;
                    Classes.Botão_19_27_.correct24 = 1;
                }
                Classes.Botão_19_27_.i24++;
            }
        }
        private void bt23_Click(object sender, EventArgs e)
        {
            Classes.Botão_19_27_.correct23 = Classes.Botão_19_27_.correct23 + 1;
            while (Classes.Botão_19_27_.i23 < Classes.Botão_19_27_.correct23)
            {
                if (Classes.Botão_19_27_.correct23 == 2)
                {
                    bt23.BackColor = Color.White;
                    bt23.Text = "n";
                }
                else if (Classes.Botão_19_27_.correct23 == 3)
                {
                    bt23.BackColor = Color.White;
                    bt23.Text = "s";
                    Classes.Botão_19_27_.i23 = 0;
                    Classes.Botão_19_27_.correct23 = 1;
                }
                Classes.Botão_19_27_.i23++;
            }
        }
        private void bt22_Click(object sender, EventArgs e)
        {
            Classes.Botão_19_27_.correct22 = Classes.Botão_19_27_.correct22 + 1;
            while (Classes.Botão_19_27_.i22 < Classes.Botão_19_27_.correct22)
            {
                if (Classes.Botão_19_27_.correct22 == 2)
                {
                    bt22.BackColor = Color.White;
                    bt22.Text = "n";
                }
                else if (Classes.Botão_19_27_.correct22 == 3)
                {
                    bt22.BackColor = Color.White;
                    bt22.Text = "s";
                    Classes.Botão_19_27_.i22 = 0;
                    Classes.Botão_19_27_.correct22 = 1;
                }
                Classes.Botão_19_27_.i22++;
            }
        }
        private void bt21_Click(object sender, EventArgs e)
        {
            Classes.Botão_19_27_.correct21 = Classes.Botão_19_27_.correct21 + 1;
            while (Classes.Botão_19_27_.i21 < Classes.Botão_19_27_.correct21)
            {
                if (Classes.Botão_19_27_.correct21 == 2)
                {
                    bt21.BackColor = Color.White;
                    bt21.Text = "n";
                }
                else if (Classes.Botão_19_27_.correct21 == 3)
                {
                    bt21.BackColor = Color.White;
                    bt21.Text = "s";
                    Classes.Botão_19_27_.i21 = 0;
                    Classes.Botão_19_27_.correct21 = 1;
                }
                Classes.Botão_19_27_.i21++;
            }
        }
        private void bt20_Click(object sender, EventArgs e)
        {
            Classes.Botão_19_27_.correct20 = Classes.Botão_19_27_.correct20 + 1;
            while (Classes.Botão_19_27_.i20 < Classes.Botão_19_27_.correct20)
            {
                if (Classes.Botão_19_27_.correct20 == 2)
                {
                    bt20.BackColor = Color.White;
                    bt20.Text = "n";
                }
                else if (Classes.Botão_19_27_.correct20 == 3)
                {
                    bt20.BackColor = Color.White;
                    bt20.Text = "s";
                    Classes.Botão_19_27_.i20 = 0;
                    Classes.Botão_19_27_.correct20 = 1;
                }
                Classes.Botão_19_27_.i20++;
            }
        }
        private void bt19_Click(object sender, EventArgs e)
        {
            Classes.Botão_19_27_.correct19 = Classes.Botão_19_27_.correct19 + 1;
            while (Classes.Botão_19_27_.i19 < Classes.Botão_19_27_.correct19)
            {
                if (Classes.Botão_19_27_.correct19 == 2)
                {
                    bt19.BackColor = Color.White;
                    bt19.Text = "n";
                }
                else if (Classes.Botão_19_27_.correct19 == 3)
                {
                    bt19.BackColor = Color.White;
                    bt19.Text = "s";
                    Classes.Botão_19_27_.i19 = 0;
                    Classes.Botão_19_27_.correct19 = 1;
                }
                Classes.Botão_19_27_.i19++;
            }
        }
        private void bt18_Click(object sender, EventArgs e)
        {
            Classes.Botões_10_18_.correct18 = Classes.Botões_10_18_.correct18 + 1;
            while (Classes.Botões_10_18_.i18 < Classes.Botões_10_18_.correct18)
            {
                if (Classes.Botões_10_18_.correct18 == 2)
                {
                    bt18.BackColor = Color.White;
                    bt18.Text = "n";
                }
                else if (Classes.Botões_10_18_.correct18 == 3)
                {
                    bt18.BackColor = Color.White;
                    bt18.Text = "s";
                    Classes.Botões_10_18_.i18 = 0;
                    Classes.Botões_10_18_.correct18 = 1;
                }
                Classes.Botões_10_18_.i18++;
            }
        }
        private void bt17_Click(object sender, EventArgs e)
        {
            Classes.Botões_10_18_.correct17 = Classes.Botões_10_18_.correct17 + 1;
            while (Classes.Botões_10_18_.i17 < Classes.Botões_10_18_.correct17)
            {
                if (Classes.Botões_10_18_.correct17 == 2)
                {
                    bt17.BackColor = Color.White;
                    bt17.Text = "n";
                }
                else if (Classes.Botões_10_18_.correct17 == 3)
                {
                    bt17.BackColor = Color.White;
                    bt17.Text = "s";
                    Classes.Botões_10_18_.i17 = 0;
                    Classes.Botões_10_18_.correct17 = 1;
                }
                Classes.Botões_10_18_.i17++;
            }
        }
        private void bt16_Click(object sender, EventArgs e)
        {
            Classes.Botões_10_18_.correct16 = Classes.Botões_10_18_.correct16 + 1;
            while (Classes.Botões_10_18_.i16 < Classes.Botões_10_18_.correct16)
            {
                if (Classes.Botões_10_18_.correct16 == 2)
                {
                    bt16.BackColor = Color.White;
                    bt16.Text = "n";
                }
                else if (Classes.Botões_10_18_.correct16 == 3)
                {
                    bt16.BackColor = Color.White;
                    bt16.Text = "s";
                    Classes.Botões_10_18_.i16 = 0;
                    Classes.Botões_10_18_.correct16 = 1;
                }
                Classes.Botões_10_18_.i16++;
            }
        }
        private void bt15_Click(object sender, EventArgs e)
        {
            Classes.Botões_10_18_.correct15 = Classes.Botões_10_18_.correct15 + 1;
            while (Classes.Botões_10_18_.i15 < Classes.Botões_10_18_.correct15)
            {
                if (Classes.Botões_10_18_.correct15 == 2)
                {
                    bt15.BackColor = Color.White;
                    bt15.Text = "n";
                }
                else if (Classes.Botões_10_18_.correct15 == 3)
                {
                    bt15.BackColor = Color.White;
                    bt15.Text = "s";
                    Classes.Botões_10_18_.i15 = 0;
                    Classes.Botões_10_18_.correct15 = 1;
                }
                Classes.Botões_10_18_.i15++;
            }
        }
        private void bt14_Click(object sender, EventArgs e)
        {
            Classes.Botões_10_18_.correct14 = Classes.Botões_10_18_.correct14 + 1;
            while (Classes.Botões_10_18_.i14 < Classes.Botões_10_18_.correct14)
            {
                if (Classes.Botões_10_18_.correct14 == 2)
                {
                    bt14.BackColor = Color.White;
                    bt14.Text = "n";
                }
                else if (Classes.Botões_10_18_.correct14 == 3)
                {
                    bt14.BackColor = Color.White;
                    bt14.Text = "s";
                    Classes.Botões_10_18_.i14 = 0;
                    Classes.Botões_10_18_.correct14 = 1;
                }
                Classes.Botões_10_18_.i14++;
            }
        }
        private void bt13_Click(object sender, EventArgs e)
        {
            Classes.Botões_10_18_.correct13 = Classes.Botões_10_18_.correct13 + 1;
            while (Classes.Botões_10_18_.i13 < Classes.Botões_10_18_.correct13)
            {
                if (Classes.Botões_10_18_.correct13 == 2)
                {
                    bt13.BackColor = Color.White;
                    bt13.Text = "n";
                }
                else if (Classes.Botões_10_18_.correct13 == 3)
                {
                    bt13.BackColor = Color.White;
                    bt13.Text = "s";
                    Classes.Botões_10_18_.i13 = 0;
                    Classes.Botões_10_18_.correct13 = 1;
                }
                Classes.Botões_10_18_.i13++;
            }
        }
        private void bt12_Click(object sender, EventArgs e)
        {
            Classes.Botões_10_18_.correct12 = Classes.Botões_10_18_.correct12 + 1;
            while (Classes.Botões_10_18_.i12 < Classes.Botões_10_18_.correct12)
            {
                if (Classes.Botões_10_18_.correct12 == 2)
                {
                    bt12.BackColor = Color.White;
                    bt12.Text = "n";
                }
                else if (Classes.Botões_10_18_.correct12 == 3)
                {
                    bt12.BackColor = Color.White;
                    bt12.Text = "s";
                    Classes.Botões_10_18_.i12 = 0;
                    Classes.Botões_10_18_.correct12 = 1;
                }
                Classes.Botões_10_18_.i12++;
            }
        }
        private void bt11_Click(object sender, EventArgs e)
        {
            Classes.Botões_10_18_.correct11 = Classes.Botões_10_18_.correct11 + 1;
            while (Classes.Botões_10_18_.i11 < Classes.Botões_10_18_.correct11)
            {
                if (Classes.Botões_10_18_.correct11 == 2)
                {
                    bt11.BackColor = Color.White;
                    bt11.Text = "n";
                }
                else if (Classes.Botões_10_18_.correct11 == 3)
                {
                    bt11.BackColor = Color.White;
                    bt11.Text = "s";
                    Classes.Botões_10_18_.i11 = 0;
                    Classes.Botões_10_18_.correct11 = 1;
                }
                Classes.Botões_10_18_.i11++;
            }
        }
        private void bt10_Click(object sender, EventArgs e)
        {
            Classes.Botões_10_18_.correct10 = Classes.Botões_10_18_.correct10 + 1;
            while (Classes.Botões_10_18_.i10 < Classes.Botões_10_18_.correct10)
            {
                if (Classes.Botões_10_18_.correct10 == 2)
                {
                    bt10.BackColor = Color.White;
                    bt10.Text = "n";
                }
                else if (Classes.Botões_10_18_.correct10 == 3)
                {
                    bt10.BackColor = Color.White;
                    bt10.Text = "s";
                    Classes.Botões_10_18_.i10 = 0;
                    Classes.Botões_10_18_.correct10 = 1;
                }
                Classes.Botões_10_18_.i10++;
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

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        public void CoresI()
        {
            bt2.BackColor = Color.Pink;
            bt6.BackColor = Color.Pink;
            bt7.BackColor = Color.Pink;
            bt11.BackColor = Color.Pink;
            bt13.BackColor = Color.Pink;
            bt18.BackColor = Color.Pink;
            bt21.BackColor = Color.Pink;
            bt23.BackColor = Color.Pink;
            bt25.BackColor = Color.Pink;
            btfinalizar.Enabled = false;
        }
        public void CoresII()
        {
            bt2.BackColor = Color.White;
            bt6.BackColor = Color.White;
            bt7.BackColor = Color.White;
            bt11.BackColor = Color.White;
            bt13.BackColor = Color.White;
            bt18.BackColor = Color.White;
            bt21.BackColor = Color.White;
            bt23.BackColor = Color.White;
            bt25.BackColor = Color.White;
            btfinalizar.Enabled = true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bt1.Text == "n" && bt2.Text == "s" && bt3.Text == "n" &&
                bt4.Text == "n" && bt5.Text == "n" && bt6.Text == "s" &&
                bt7.Text == "s" && bt8.Text == "n" && bt9.Text == "n" &&
                bt10.Text == "n" && bt11.Text == "s" && bt12.Text == "n" &&
                bt13.Text == "s" && bt14.Text == "n" && bt15.Text == "n" &&
                bt16.Text == "n" && bt17.Text == "n" && bt18.Text == "s" &&
                bt19.Text == "n" && bt20.Text == "n" && bt21.Text == "s" &&
                bt22.Text == "n" && bt23.Text == "s" && bt24.Text == "n" &&
                bt25.Text == "s" && bt26.Text == "n" && bt27.Text == "n")
            {
                DialogResult op = MessageBox.Show("Vitória! Deseja jogar novamente?", "WINNER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (op == DialogResult.Yes)
                {
                    Limpar();
                    btprox.Enabled = true;
                }
                else if(op == DialogResult.No)
                {
                    DialogResult op2 = MessageBox.Show("Deseja voltar ao Menu Inicial?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(op2 == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Clique no Botão 'Próximo Jogo', para avançar","WARNING");
                        btprox.Enabled = true;
                    }
                }
            }
            else 
            if (   bt1.Text != "" && bt2.Text != "" && bt3.Text != "" &&
                        bt4.Text != "" && bt5.Text != "" && bt6.Text != "" &&
                        bt7.Text != "" && bt8.Text != "" && bt9.Text != "" &&
                        bt10.Text != "" && bt11.Text != "" && bt12.Text != "" &&
                        bt13.Text != "" && bt14.Text != "" && bt15.Text != "" &&
                        bt16.Text != "" && bt17.Text != "" && bt18.Text != "" &&
                        bt19.Text != "" && bt20.Text != "" && bt21.Text != "" &&
                        bt22.Text != "" && bt23.Text != "" && bt24.Text != "" &&
                        bt25.Text != "" && bt26.Text != "" && bt27.Text == "n")
            {
                DialogResult op = MessageBox.Show("Perdeu! Deseja jogar novamente?", "LOSER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (op == DialogResult.Yes)
                {
                    Limpar();
                    btprox.Enabled = false;
                }
                else
                {
                    this.Close();
                    MenuConvidado voltar = new MenuConvidado();
                    voltar.Show();
                }
            }else if (  bt1.Text == "" && bt2.Text == "" && bt3.Text == "" &&
                        bt4.Text == "" && bt5.Text == "" && bt6.Text == "" &&
                        bt7.Text == "" && bt8.Text == "" && bt9.Text == "" &&
                        bt10.Text == "" && bt11.Text == "" && bt12.Text == "" &&
                        bt13.Text == "" && bt14.Text == "" && bt15.Text == "" &&
                        bt16.Text == "" && bt17.Text == "" && bt18.Text == "" &&
                        bt19.Text == "" && bt20.Text == "" && bt21.Text == "" &&
                        bt22.Text == "" && bt23.Text == "" && bt24.Text == "" &&
                        bt25.Text == "" && bt26.Text == "" && bt27.Text == "")
                  {
                         MessageBox.Show("Jogue para obter um resultado!");
                  }
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Classes.Verificar.btresp2 = Classes.Verificar.btresp2 + 1;

            while (Classes.Verificar.btresp < Classes.Verificar.btresp2)
            {
                if (Classes.Verificar.btresp2 == 2)
                {
                    bt1.Text = "n"; bt2.Text = "s"; bt3.Text = "n";
                    bt4.Text = "n"; bt5.Text = "n"; bt6.Text = "s";
                    bt7.Text = "s"; bt8.Text = "n";  bt9.Text = "n";
                    bt10.Text = "n"; bt11.Text = "s"; bt12.Text = "n";
                    bt13.Text = "s"; bt14.Text = "n"; bt15.Text = "n";
                    bt16.Text = "n"; bt17.Text = "n"; bt18.Text = "s";
                    bt19.Text = "n";  bt20.Text = "n"; bt21.Text = "s";
                    bt22.Text = "n";  bt23.Text = "s";  bt24.Text = "n";
                    bt25.Text = "s";  bt26.Text = "n";  bt27.Text = "n";

                    CoresI();
                }
                else if (Classes.Verificar.btresp2 == 3)
                {
                    Limpar();
                    CoresII();
                    Classes.Verificar.btresp2 = 1;
                    Classes.Verificar.btresp = 0;
                }
                Classes.Verificar.btresp++;
            }
        }
    }
}
