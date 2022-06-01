namespace RestGest
{
    partial class FormAddNovoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddNovoPedido));
            this.comboBoxSelecionarFuncionario = new System.Windows.Forms.ComboBox();
            this.labelSelecionarFuncionario = new System.Windows.Forms.Label();
            this.labelAdicionarPedido = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelClienteTotal = new System.Windows.Forms.Label();
            this.groupBoxAdicionarItem = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxItensJaAdicionados = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.butAdicionarAoPedido = new System.Windows.Forms.Button();
            this.butRemoverDoPedido = new System.Windows.Forms.Button();
            this.listBoxAdicionarItemAoPedido = new System.Windows.Forms.ListBox();
            this.listBoxItensJaPedidos = new System.Windows.Forms.ListBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.labelCategoriaItem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butSairPedido = new System.Windows.Forms.Button();
            this.butGuardarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.groupBoxAdicionarItem.SuspendLayout();
            this.groupBoxItensJaAdicionados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSelecionarFuncionario
            // 
            this.comboBoxSelecionarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelecionarFuncionario.FormattingEnabled = true;
            this.comboBoxSelecionarFuncionario.Location = new System.Drawing.Point(175, 36);
            this.comboBoxSelecionarFuncionario.Name = "comboBoxSelecionarFuncionario";
            this.comboBoxSelecionarFuncionario.Size = new System.Drawing.Size(263, 28);
            this.comboBoxSelecionarFuncionario.TabIndex = 20;
            // 
            // labelSelecionarFuncionario
            // 
            this.labelSelecionarFuncionario.AutoSize = true;
            this.labelSelecionarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelecionarFuncionario.Location = new System.Drawing.Point(175, 13);
            this.labelSelecionarFuncionario.Name = "labelSelecionarFuncionario";
            this.labelSelecionarFuncionario.Size = new System.Drawing.Size(207, 20);
            this.labelSelecionarFuncionario.TabIndex = 19;
            this.labelSelecionarFuncionario.Text = "Selecione um Funcionário:";
            // 
            // labelAdicionarPedido
            // 
            this.labelAdicionarPedido.AutoSize = true;
            this.labelAdicionarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdicionarPedido.Location = new System.Drawing.Point(740, 67);
            this.labelAdicionarPedido.Name = "labelAdicionarPedido";
            this.labelAdicionarPedido.Size = new System.Drawing.Size(290, 36);
            this.labelAdicionarPedido.TabIndex = 23;
            this.labelAdicionarPedido.Text = "Editar / Novo Pedido";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(11, 13);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(157, 150);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 24;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(175, 67);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(66, 20);
            this.labelCliente.TabIndex = 25;
            this.labelCliente.Text = "Cliente:";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(175, 90);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(263, 28);
            this.comboBoxCliente.TabIndex = 26;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(299, 134);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(62, 25);
            this.labelTotal.TabIndex = 27;
            this.labelTotal.Text = "Total:";
            // 
            // labelClienteTotal
            // 
            this.labelClienteTotal.AutoSize = true;
            this.labelClienteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClienteTotal.Location = new System.Drawing.Point(367, 134);
            this.labelClienteTotal.Name = "labelClienteTotal";
            this.labelClienteTotal.Size = new System.Drawing.Size(71, 29);
            this.labelClienteTotal.TabIndex = 28;
            this.labelClienteTotal.Text = "0.00€";
            // 
            // groupBoxAdicionarItem
            // 
            this.groupBoxAdicionarItem.Controls.Add(this.comboBoxCategoria);
            this.groupBoxAdicionarItem.Controls.Add(this.labelCategoriaItem);
            this.groupBoxAdicionarItem.Controls.Add(this.listBoxAdicionarItemAoPedido);
            this.groupBoxAdicionarItem.Controls.Add(this.groupBox1);
            this.groupBoxAdicionarItem.Location = new System.Drawing.Point(12, 189);
            this.groupBoxAdicionarItem.Name = "groupBoxAdicionarItem";
            this.groupBoxAdicionarItem.Size = new System.Drawing.Size(425, 283);
            this.groupBoxAdicionarItem.TabIndex = 29;
            this.groupBoxAdicionarItem.TabStop = false;
            this.groupBoxAdicionarItem.Text = "Adicionar Item:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(593, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 324);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Item:";
            // 
            // groupBoxItensJaAdicionados
            // 
            this.groupBoxItensJaAdicionados.Controls.Add(this.listBoxItensJaPedidos);
            this.groupBoxItensJaAdicionados.Controls.Add(this.groupBox3);
            this.groupBoxItensJaAdicionados.Location = new System.Drawing.Point(630, 189);
            this.groupBoxItensJaAdicionados.Name = "groupBoxItensJaAdicionados";
            this.groupBoxItensJaAdicionados.Size = new System.Drawing.Size(425, 283);
            this.groupBoxItensJaAdicionados.TabIndex = 31;
            this.groupBoxItensJaAdicionados.TabStop = false;
            this.groupBoxItensJaAdicionados.Text = "Itens Já Adicionados:";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(593, -1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 324);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adicionar Item:";
            // 
            // butAdicionarAoPedido
            // 
            this.butAdicionarAoPedido.BackColor = System.Drawing.Color.DarkTurquoise;
            this.butAdicionarAoPedido.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdicionarAoPedido.Location = new System.Drawing.Point(480, 294);
            this.butAdicionarAoPedido.Name = "butAdicionarAoPedido";
            this.butAdicionarAoPedido.Size = new System.Drawing.Size(119, 38);
            this.butAdicionarAoPedido.TabIndex = 33;
            this.butAdicionarAoPedido.Text = ">>>";
            this.butAdicionarAoPedido.UseVisualStyleBackColor = false;
            // 
            // butRemoverDoPedido
            // 
            this.butRemoverDoPedido.BackColor = System.Drawing.Color.DarkTurquoise;
            this.butRemoverDoPedido.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRemoverDoPedido.Location = new System.Drawing.Point(480, 361);
            this.butRemoverDoPedido.Name = "butRemoverDoPedido";
            this.butRemoverDoPedido.Size = new System.Drawing.Size(119, 38);
            this.butRemoverDoPedido.TabIndex = 34;
            this.butRemoverDoPedido.Text = "<<<";
            this.butRemoverDoPedido.UseVisualStyleBackColor = false;
            // 
            // listBoxAdicionarItemAoPedido
            // 
            this.listBoxAdicionarItemAoPedido.FormattingEnabled = true;
            this.listBoxAdicionarItemAoPedido.ItemHeight = 16;
            this.listBoxAdicionarItemAoPedido.Location = new System.Drawing.Point(21, 73);
            this.listBoxAdicionarItemAoPedido.Name = "listBoxAdicionarItemAoPedido";
            this.listBoxAdicionarItemAoPedido.Size = new System.Drawing.Size(377, 196);
            this.listBoxAdicionarItemAoPedido.TabIndex = 31;
            // 
            // listBoxItensJaPedidos
            // 
            this.listBoxItensJaPedidos.FormattingEnabled = true;
            this.listBoxItensJaPedidos.ItemHeight = 16;
            this.listBoxItensJaPedidos.Location = new System.Drawing.Point(23, 41);
            this.listBoxItensJaPedidos.Name = "listBoxItensJaPedidos";
            this.listBoxItensJaPedidos.Size = new System.Drawing.Size(377, 228);
            this.listBoxItensJaPedidos.TabIndex = 32;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(21, 41);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(377, 28);
            this.comboBoxCategoria.TabIndex = 36;
            // 
            // labelCategoriaItem
            // 
            this.labelCategoriaItem.AutoSize = true;
            this.labelCategoriaItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoriaItem.Location = new System.Drawing.Point(21, 18);
            this.labelCategoriaItem.Name = "labelCategoriaItem";
            this.labelCategoriaItem.Size = new System.Drawing.Size(164, 20);
            this.labelCategoriaItem.TabIndex = 35;
            this.labelCategoriaItem.Text = "Selecione Categoria:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(984, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // butSairPedido
            // 
            this.butSairPedido.BackColor = System.Drawing.Color.DarkTurquoise;
            this.butSairPedido.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSairPedido.Location = new System.Drawing.Point(558, 499);
            this.butSairPedido.Name = "butSairPedido";
            this.butSairPedido.Size = new System.Drawing.Size(157, 43);
            this.butSairPedido.TabIndex = 37;
            this.butSairPedido.Text = "Sair";
            this.butSairPedido.UseVisualStyleBackColor = false;
            // 
            // butGuardarPedido
            // 
            this.butGuardarPedido.BackColor = System.Drawing.Color.DarkTurquoise;
            this.butGuardarPedido.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGuardarPedido.Location = new System.Drawing.Point(340, 499);
            this.butGuardarPedido.Name = "butGuardarPedido";
            this.butGuardarPedido.Size = new System.Drawing.Size(157, 43);
            this.butGuardarPedido.TabIndex = 36;
            this.butGuardarPedido.Text = "Guardar";
            this.butGuardarPedido.UseVisualStyleBackColor = false;
            // 
            // FormAddNovoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.butSairPedido);
            this.Controls.Add(this.butGuardarPedido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butRemoverDoPedido);
            this.Controls.Add(this.butAdicionarAoPedido);
            this.Controls.Add(this.groupBoxItensJaAdicionados);
            this.Controls.Add(this.groupBoxAdicionarItem);
            this.Controls.Add(this.labelClienteTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelAdicionarPedido);
            this.Controls.Add(this.comboBoxSelecionarFuncionario);
            this.Controls.Add(this.labelSelecionarFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddNovoPedido";
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.groupBoxAdicionarItem.ResumeLayout(false);
            this.groupBoxAdicionarItem.PerformLayout();
            this.groupBoxItensJaAdicionados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxSelecionarFuncionario;
        private System.Windows.Forms.Label labelSelecionarFuncionario;
        private System.Windows.Forms.Label labelAdicionarPedido;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelClienteTotal;
        private System.Windows.Forms.GroupBox groupBoxAdicionarItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxItensJaAdicionados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label labelCategoriaItem;
        private System.Windows.Forms.ListBox listBoxAdicionarItemAoPedido;
        private System.Windows.Forms.ListBox listBoxItensJaPedidos;
        private System.Windows.Forms.Button butAdicionarAoPedido;
        private System.Windows.Forms.Button butRemoverDoPedido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butSairPedido;
        private System.Windows.Forms.Button butGuardarPedido;
    }
}