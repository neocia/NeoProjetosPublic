namespace Projeto_01_2._0
{
    partial class CadastroAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroAdministrador));
            this.labelname = new System.Windows.Forms.Label();
            this.cbtipoadm = new System.Windows.Forms.ComboBox();
            this.btsair = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.btacessar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelname.Location = new System.Drawing.Point(13, 93);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(101, 13);
            this.labelname.TabIndex = 28;
            this.labelname.Text = "Tipo de Usuário:";
            // 
            // cbtipoadm
            // 
            this.cbtipoadm.BackColor = System.Drawing.Color.Thistle;
            this.cbtipoadm.ForeColor = System.Drawing.Color.DeepPink;
            this.cbtipoadm.FormattingEnabled = true;
            this.cbtipoadm.Items.AddRange(new object[] {
            "Administrador",
            "Convidado"});
            this.cbtipoadm.Location = new System.Drawing.Point(127, 90);
            this.cbtipoadm.Name = "cbtipoadm";
            this.cbtipoadm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbtipoadm.Size = new System.Drawing.Size(233, 21);
            this.cbtipoadm.TabIndex = 27;
            // 
            // btsair
            // 
            this.btsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsair.ForeColor = System.Drawing.Color.DeepPink;
            this.btsair.Location = new System.Drawing.Point(295, 117);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(65, 23);
            this.btsair.TabIndex = 26;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            // 
            // btlimpar
            // 
            this.btlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlimpar.ForeColor = System.Drawing.Color.DeepPink;
            this.btlimpar.Location = new System.Drawing.Point(211, 117);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(65, 23);
            this.btlimpar.TabIndex = 25;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            // 
            // btacessar
            // 
            this.btacessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btacessar.ForeColor = System.Drawing.Color.DeepPink;
            this.btacessar.Location = new System.Drawing.Point(127, 117);
            this.btacessar.Name = "btacessar";
            this.btacessar.Size = new System.Drawing.Size(65, 23);
            this.btacessar.TabIndex = 24;
            this.btacessar.Text = "Cadastrar";
            this.btacessar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_01_2._0.Properties.Resources.ds3;
            this.pictureBox1.Location = new System.Drawing.Point(366, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // txtpass
            // 
            this.txtpass.ForeColor = System.Drawing.Color.DeepPink;
            this.txtpass.Location = new System.Drawing.Point(127, 64);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(233, 20);
            this.txtpass.TabIndex = 21;
            // 
            // txtusuario
            // 
            this.txtusuario.ForeColor = System.Drawing.Color.DeepPink;
            this.txtusuario.Location = new System.Drawing.Point(127, 38);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(233, 20);
            this.txtusuario.TabIndex = 20;
            // 
            // txtnome
            // 
            this.txtnome.ForeColor = System.Drawing.Color.DeepPink;
            this.txtnome.Location = new System.Drawing.Point(127, 12);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(233, 20);
            this.txtnome.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(67, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome de Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome Completo:";
            // 
            // CadastroAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(475, 146);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.cbtipoadm);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btacessar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroAdministrador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.ComboBox cbtipoadm;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Button btacessar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}