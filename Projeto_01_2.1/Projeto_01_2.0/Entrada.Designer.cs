namespace Projeto_01_2._0
{
    partial class Entrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.btacessar = new System.Windows.Forms.Button();
            this.btcadastro = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(177, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(172, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(118, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Usuário:";
            // 
            // txtlogin
            // 
            this.txtlogin.ForeColor = System.Drawing.Color.DarkOrchid;
            this.txtlogin.Location = new System.Drawing.Point(225, 12);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(119, 20);
            this.txtlogin.TabIndex = 3;
            // 
            // txtsenha
            // 
            this.txtsenha.ForeColor = System.Drawing.Color.DarkOrchid;
            this.txtsenha.Location = new System.Drawing.Point(225, 35);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '✧';
            this.txtsenha.Size = new System.Drawing.Size(119, 20);
            this.txtsenha.TabIndex = 4;
            // 
            // cbtipo
            // 
            this.cbtipo.ForeColor = System.Drawing.Color.DarkViolet;
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "Administrador",
            "Convidado"});
            this.cbtipo.Location = new System.Drawing.Point(225, 58);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(119, 21);
            this.cbtipo.TabIndex = 7;
            // 
            // btacessar
            // 
            this.btacessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btacessar.ForeColor = System.Drawing.Color.DeepPink;
            this.btacessar.Location = new System.Drawing.Point(137, 84);
            this.btacessar.Name = "btacessar";
            this.btacessar.Size = new System.Drawing.Size(65, 23);
            this.btacessar.TabIndex = 8;
            this.btacessar.Text = "Acessar";
            this.btacessar.UseVisualStyleBackColor = true;
            this.btacessar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btcadastro
            // 
            this.btcadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcadastro.ForeColor = System.Drawing.Color.DarkViolet;
            this.btcadastro.Location = new System.Drawing.Point(208, 84);
            this.btcadastro.Name = "btcadastro";
            this.btcadastro.Size = new System.Drawing.Size(65, 24);
            this.btcadastro.TabIndex = 9;
            this.btcadastro.Text = "Cadastrar";
            this.btcadastro.UseVisualStyleBackColor = true;
            this.btcadastro.Click += new System.EventHandler(this.btcadastro_Click);
            // 
            // btsair
            // 
            this.btsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsair.ForeColor = System.Drawing.Color.DeepPink;
            this.btsair.Location = new System.Drawing.Point(279, 84);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(65, 24);
            this.btsair.TabIndex = 10;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_01_2._0.Properties.Resources.ds1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(349, 118);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btcadastro);
            this.Controls.Add(this.btacessar);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.Button btacessar;
        private System.Windows.Forms.Button btcadastro;
        private System.Windows.Forms.Button btsair;
    }
}