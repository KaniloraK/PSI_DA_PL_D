namespace RestGest
{
    partial class FormAddMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddMenu));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxAdicionarNovoMenu = new System.Windows.Forms.GroupBox();
            this.butImagemPrato = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.labelPrecoPrato = new System.Windows.Forms.Label();
            this.textBoxIngredientesPrato = new System.Windows.Forms.TextBox();
            this.textBoxNomePrato = new System.Windows.Forms.TextBox();
            this.labelIngredientesPrato = new System.Windows.Forms.Label();
            this.labelNomePrato = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.butGuardar = new System.Windows.Forms.Button();
            this.butSair = new System.Windows.Forms.Button();
            this.labelAdicionarNovoItem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.groupBoxAdicionarNovoMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(11, 13);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(157, 150);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 11;
            this.pictureBoxLogo.TabStop = false;
            // 
            // groupBoxAdicionarNovoMenu
            // 
            this.groupBoxAdicionarNovoMenu.Controls.Add(this.butImagemPrato);
            this.groupBoxAdicionarNovoMenu.Controls.Add(this.checkBox1);
            this.groupBoxAdicionarNovoMenu.Controls.Add(this.textBoxPreco);
            this.groupBoxAdicionarNovoMenu.Controls.Add(this.labelPrecoPrato);
            this.groupBoxAdicionarNovoMenu.Controls.Add(this.textBoxIngredientesPrato);
            this.groupBoxAdicionarNovoMenu.Controls.Add(this.textBoxNomePrato);
            this.groupBoxAdicionarNovoMenu.Controls.Add(this.labelIngredientesPrato);
            this.groupBoxAdicionarNovoMenu.Controls.Add(this.labelNomePrato);
            this.groupBoxAdicionarNovoMenu.Controls.Add(this.comboBox1);
            this.groupBoxAdicionarNovoMenu.Controls.Add(this.labelCategoria);
            this.groupBoxAdicionarNovoMenu.Location = new System.Drawing.Point(189, 152);
            this.groupBoxAdicionarNovoMenu.Name = "groupBoxAdicionarNovoMenu";
            this.groupBoxAdicionarNovoMenu.Size = new System.Drawing.Size(736, 271);
            this.groupBoxAdicionarNovoMenu.TabIndex = 12;
            this.groupBoxAdicionarNovoMenu.TabStop = false;
            this.groupBoxAdicionarNovoMenu.Text = "Adicionar Novo Item ao Menu:";
            // 
            // butImagemPrato
            // 
            this.butImagemPrato.BackColor = System.Drawing.Color.DarkSlateGray;
            this.butImagemPrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butImagemPrato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butImagemPrato.Location = new System.Drawing.Point(15, 190);
            this.butImagemPrato.Name = "butImagemPrato";
            this.butImagemPrato.Size = new System.Drawing.Size(698, 30);
            this.butImagemPrato.TabIndex = 12;
            this.butImagemPrato.Text = "Clique para selecionar uma imagem do prato";
            this.butImagemPrato.UseVisualStyleBackColor = false;
            this.butImagemPrato.Click += new System.EventHandler(this.butImagemPrato_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(636, 241);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Ativo?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPreco.Location = new System.Drawing.Point(132, 127);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(581, 27);
            this.textBoxPreco.TabIndex = 8;
            // 
            // labelPrecoPrato
            // 
            this.labelPrecoPrato.AutoSize = true;
            this.labelPrecoPrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecoPrato.Location = new System.Drawing.Point(10, 126);
            this.labelPrecoPrato.Name = "labelPrecoPrato";
            this.labelPrecoPrato.Size = new System.Drawing.Size(63, 25);
            this.labelPrecoPrato.TabIndex = 7;
            this.labelPrecoPrato.Text = "Preço";
            // 
            // textBoxIngredientesPrato
            // 
            this.textBoxIngredientesPrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIngredientesPrato.Location = new System.Drawing.Point(132, 94);
            this.textBoxIngredientesPrato.Name = "textBoxIngredientesPrato";
            this.textBoxIngredientesPrato.Size = new System.Drawing.Size(581, 27);
            this.textBoxIngredientesPrato.TabIndex = 6;
            // 
            // textBoxNomePrato
            // 
            this.textBoxNomePrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomePrato.Location = new System.Drawing.Point(132, 59);
            this.textBoxNomePrato.Name = "textBoxNomePrato";
            this.textBoxNomePrato.Size = new System.Drawing.Size(581, 27);
            this.textBoxNomePrato.TabIndex = 5;
            // 
            // labelIngredientesPrato
            // 
            this.labelIngredientesPrato.AutoSize = true;
            this.labelIngredientesPrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngredientesPrato.Location = new System.Drawing.Point(10, 93);
            this.labelIngredientesPrato.Name = "labelIngredientesPrato";
            this.labelIngredientesPrato.Size = new System.Drawing.Size(125, 25);
            this.labelIngredientesPrato.TabIndex = 4;
            this.labelIngredientesPrato.Text = "Ingredientes:";
            // 
            // labelNomePrato
            // 
            this.labelNomePrato.AutoSize = true;
            this.labelNomePrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomePrato.Location = new System.Drawing.Point(10, 59);
            this.labelNomePrato.Name = "labelNomePrato";
            this.labelNomePrato.Size = new System.Drawing.Size(70, 25);
            this.labelNomePrato.TabIndex = 2;
            this.labelNomePrato.Text = "Nome:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(581, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(10, 25);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(103, 25);
            this.labelCategoria.TabIndex = 0;
            this.labelCategoria.Text = "Categoria:";
            // 
            // butGuardar
            // 
            this.butGuardar.BackColor = System.Drawing.Color.SlateGray;
            this.butGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.butGuardar.Location = new System.Drawing.Point(550, 445);
            this.butGuardar.Name = "butGuardar";
            this.butGuardar.Size = new System.Drawing.Size(157, 54);
            this.butGuardar.TabIndex = 12;
            this.butGuardar.Text = "Guardar";
            this.butGuardar.UseVisualStyleBackColor = false;
            // 
            // butSair
            // 
            this.butSair.BackColor = System.Drawing.Color.SlateGray;
            this.butSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSair.ForeColor = System.Drawing.SystemColors.Control;
            this.butSair.Location = new System.Drawing.Point(768, 445);
            this.butSair.Name = "butSair";
            this.butSair.Size = new System.Drawing.Size(157, 54);
            this.butSair.TabIndex = 13;
            this.butSair.Text = "Sair";
            this.butSair.UseVisualStyleBackColor = false;
            // 
            // labelAdicionarNovoItem
            // 
            this.labelAdicionarNovoItem.AutoSize = true;
            this.labelAdicionarNovoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdicionarNovoItem.Location = new System.Drawing.Point(633, 61);
            this.labelAdicionarNovoItem.Name = "labelAdicionarNovoItem";
            this.labelAdicionarNovoItem.Size = new System.Drawing.Size(284, 36);
            this.labelAdicionarNovoItem.TabIndex = 14;
            this.labelAdicionarNovoItem.Text = "Adicionar Novo Item";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(984, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.goHome_Click);
            // 
            // FormAddMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelAdicionarNovoItem);
            this.Controls.Add(this.butSair);
            this.Controls.Add(this.butGuardar);
            this.Controls.Add(this.groupBoxAdicionarNovoMenu);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddMenu";
            this.Text = "Adicionar Novo Item ao Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.groupBoxAdicionarNovoMenu.ResumeLayout(false);
            this.groupBoxAdicionarNovoMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.GroupBox groupBoxAdicionarNovoMenu;
        private System.Windows.Forms.Button butGuardar;
        private System.Windows.Forms.Button butSair;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button butImagemPrato;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Label labelPrecoPrato;
        private System.Windows.Forms.TextBox textBoxIngredientesPrato;
        private System.Windows.Forms.TextBox textBoxNomePrato;
        private System.Windows.Forms.Label labelIngredientesPrato;
        private System.Windows.Forms.Label labelNomePrato;
        private System.Windows.Forms.Label labelAdicionarNovoItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}