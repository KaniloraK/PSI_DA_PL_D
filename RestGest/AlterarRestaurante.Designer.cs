namespace RestGest
{
    partial class AlterarRestaurante
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarRestaurante));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRestauranteAAlterar = new System.Windows.Forms.ComboBox();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbCodPostal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btAlterarRestaurante = new System.Windows.Forms.Button();
            this.btSairMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterar Restaurante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecione o Restaurante a alterar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rua:";
            // 
            // cbRestauranteAAlterar
            // 
            this.cbRestauranteAAlterar.FormattingEnabled = true;
            this.cbRestauranteAAlterar.Location = new System.Drawing.Point(467, 55);
            this.cbRestauranteAAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRestauranteAAlterar.Name = "cbRestauranteAAlterar";
            this.cbRestauranteAAlterar.Size = new System.Drawing.Size(293, 24);
            this.cbRestauranteAAlterar.TabIndex = 4;
            this.cbRestauranteAAlterar.SelectedIndexChanged += new System.EventHandler(this.cbRestauranteAAlterar_SelectedIndexChanged);
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(179, 190);
            this.tbRua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(241, 22);
            this.tbRua.TabIndex = 6;
            this.tbRua.Validating += new System.ComponentModel.CancelEventHandler(this.tbRua_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.tbPais);
            this.groupBox1.Controls.Add(this.tbCidade);
            this.groupBox1.Controls.Add(this.tbCodPostal);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbRua);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbRestauranteAAlterar);
            this.groupBox1.Location = new System.Drawing.Point(198, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(849, 380);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar Restaurante";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(179, 135);
            this.tbNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(241, 22);
            this.tbNome.TabIndex = 15;
            this.tbNome.Validating += new System.ComponentModel.CancelEventHandler(this.tbNome_Validating);
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(179, 336);
            this.tbPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(241, 22);
            this.tbPais.TabIndex = 14;
            this.tbPais.Validating += new System.ComponentModel.CancelEventHandler(this.tbPais_Validating);
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(179, 238);
            this.tbCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(241, 22);
            this.tbCidade.TabIndex = 13;
            this.tbCidade.Validating += new System.ComponentModel.CancelEventHandler(this.tbCidade_Validating);
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Location = new System.Drawing.Point(208, 288);
            this.tbCodPostal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(212, 22);
            this.tbCodPostal.TabIndex = 12;
            this.tbCodPostal.Validating += new System.ComponentModel.CancelEventHandler(this.tbCodPostal_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Código Postal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "País:";
            // 
            // btAlterarRestaurante
            // 
            this.btAlterarRestaurante.BackColor = System.Drawing.Color.SlateGray;
            this.btAlterarRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btAlterarRestaurante.ForeColor = System.Drawing.SystemColors.Control;
            this.btAlterarRestaurante.Location = new System.Drawing.Point(611, 542);
            this.btAlterarRestaurante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAlterarRestaurante.Name = "btAlterarRestaurante";
            this.btAlterarRestaurante.Size = new System.Drawing.Size(183, 54);
            this.btAlterarRestaurante.TabIndex = 8;
            this.btAlterarRestaurante.Text = "Alterar";
            this.btAlterarRestaurante.UseVisualStyleBackColor = false;
            this.btAlterarRestaurante.Click += new System.EventHandler(this.btAlterarRestaurante_Click);
            // 
            // btSairMenu
            // 
            this.btSairMenu.BackColor = System.Drawing.Color.SlateGray;
            this.btSairMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSairMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btSairMenu.Location = new System.Drawing.Point(849, 542);
            this.btSairMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSairMenu.Name = "btSairMenu";
            this.btSairMenu.Size = new System.Drawing.Size(176, 54);
            this.btSairMenu.TabIndex = 9;
            this.btSairMenu.Text = "Sair";
            this.btSairMenu.UseVisualStyleBackColor = false;
            this.btSairMenu.Click += new System.EventHandler(this.btSairMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(984, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AlterarRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 626);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSairMenu);
            this.Controls.Add(this.btAlterarRestaurante);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AlterarRestaurante";
            this.Text = "AlterarRestaurante";
            this.Load += new System.EventHandler(this.AlterarRestaurante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRestauranteAAlterar;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAlterarRestaurante;
        private System.Windows.Forms.Button btSairMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbCodPostal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}