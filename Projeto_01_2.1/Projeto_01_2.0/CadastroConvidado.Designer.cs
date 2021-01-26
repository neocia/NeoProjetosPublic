namespace Projeto_01_2._0
{
    partial class CadastroConvidado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroConvidado));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btlimpar = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.btacessar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome de Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(64, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(10, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de Usuário:";
            // 
            // txtnome
            // 
            this.txtnome.ForeColor = System.Drawing.Color.DeepPink;
            this.txtnome.Location = new System.Drawing.Point(124, 12);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(233, 20);
            this.txtnome.TabIndex = 5;
            // 
            // txtusuario
            // 
            this.txtusuario.ForeColor = System.Drawing.Color.DeepPink;
            this.txtusuario.Location = new System.Drawing.Point(124, 38);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(233, 20);
            this.txtusuario.TabIndex = 6;
            // 
            // txtpass
            // 
            this.txtpass.ForeColor = System.Drawing.Color.DeepPink;
            this.txtpass.Location = new System.Drawing.Point(124, 64);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(233, 20);
            this.txtpass.TabIndex = 7;
            // 
            // cbtype
            // 
            this.cbtype.BackColor = System.Drawing.Color.LightPink;
            this.cbtype.ForeColor = System.Drawing.Color.DeepPink;
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Items.AddRange(new object[] {
            "Convidado"});
            this.cbtype.Location = new System.Drawing.Point(124, 88);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(233, 21);
            this.cbtype.TabIndex = 8;
            this.cbtype.SelectedIndexChanged += new System.EventHandler(this.cbtype_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_01_2._0.Properties.Resources.ds3;
            this.pictureBox1.Location = new System.Drawing.Point(363, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btlimpar
            // 
            this.btlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlimpar.ForeColor = System.Drawing.Color.DeepPink;
            this.btlimpar.Location = new System.Drawing.Point(208, 115);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(65, 23);
            this.btlimpar.TabIndex = 11;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // btsair
            // 
            this.btsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsair.ForeColor = System.Drawing.Color.DeepPink;
            this.btsair.Location = new System.Drawing.Point(292, 115);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(65, 23);
            this.btsair.TabIndex = 12;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // btacessar
            // 
            this.btacessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btacessar.ForeColor = System.Drawing.Color.DeepPink;
            this.btacessar.Location = new System.Drawing.Point(124, 115);
            this.btacessar.Name = "btacessar";
            this.btacessar.Size = new System.Drawing.Size(65, 23);
            this.btacessar.TabIndex = 10;
            this.btacessar.Text = "Cadastrar";
            this.btacessar.UseVisualStyleBackColor = true;
            this.btacessar.Click += new System.EventHandler(this.btacessar_Click);
            // 
            // CadastroConvidado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(475, 146);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btacessar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbtype);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroConvidado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.ComboBox cbtype;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button btacessar;
    }
}