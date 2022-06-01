namespace RestGest
{
    partial class FormPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidos));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelSelecionarRestaurante = new System.Windows.Forms.Label();
            this.comboBoxSelecionarRestaurante = new System.Windows.Forms.ComboBox();
            this.labelGestaoPedidos = new System.Windows.Forms.Label();
            this.butNovoPedido = new System.Windows.Forms.Button();
            this.listViewGestaoPedidos = new System.Windows.Forms.ListView();
            this.butEditarPedido = new System.Windows.Forms.Button();
            this.butExportarTXT = new System.Windows.Forms.Button();
            this.butExportarPDF = new System.Windows.Forms.Button();
            this.butConsultarPedidosTerminados = new System.Windows.Forms.Button();
            this.IdPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeFuncionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MeioPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
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
            // labelSelecionarRestaurante
            // 
            this.labelSelecionarRestaurante.AutoSize = true;
            this.labelSelecionarRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelecionarRestaurante.Location = new System.Drawing.Point(211, 97);
            this.labelSelecionarRestaurante.Name = "labelSelecionarRestaurante";
            this.labelSelecionarRestaurante.Size = new System.Drawing.Size(211, 20);
            this.labelSelecionarRestaurante.TabIndex = 12;
            this.labelSelecionarRestaurante.Text = "Selecione um Restaurante:";
            // 
            // comboBoxSelecionarRestaurante
            // 
            this.comboBoxSelecionarRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelecionarRestaurante.FormattingEnabled = true;
            this.comboBoxSelecionarRestaurante.Location = new System.Drawing.Point(211, 130);
            this.comboBoxSelecionarRestaurante.Name = "comboBoxSelecionarRestaurante";
            this.comboBoxSelecionarRestaurante.Size = new System.Drawing.Size(399, 33);
            this.comboBoxSelecionarRestaurante.TabIndex = 13;
            // 
            // labelGestaoPedidos
            // 
            this.labelGestaoPedidos.AutoSize = true;
            this.labelGestaoPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGestaoPedidos.Location = new System.Drawing.Point(775, 70);
            this.labelGestaoPedidos.Name = "labelGestaoPedidos";
            this.labelGestaoPedidos.Size = new System.Drawing.Size(268, 36);
            this.labelGestaoPedidos.TabIndex = 14;
            this.labelGestaoPedidos.Text = "Gestão de Pedidos";
            // 
            // butNovoPedido
            // 
            this.butNovoPedido.BackColor = System.Drawing.Color.DarkTurquoise;
            this.butNovoPedido.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNovoPedido.Location = new System.Drawing.Point(886, 109);
            this.butNovoPedido.Name = "butNovoPedido";
            this.butNovoPedido.Size = new System.Drawing.Size(157, 54);
            this.butNovoPedido.TabIndex = 19;
            this.butNovoPedido.Text = "Novo Pedido";
            this.butNovoPedido.UseVisualStyleBackColor = false;
            // 
            // listViewGestaoPedidos
            // 
            this.listViewGestaoPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdPedido,
            this.NomeFuncionario,
            this.Estado,
            this.ValorTotal,
            this.MeioPagamento});
            this.listViewGestaoPedidos.HideSelection = false;
            this.listViewGestaoPedidos.Location = new System.Drawing.Point(16, 185);
            this.listViewGestaoPedidos.Name = "listViewGestaoPedidos";
            this.listViewGestaoPedidos.Size = new System.Drawing.Size(1027, 289);
            this.listViewGestaoPedidos.TabIndex = 20;
            this.listViewGestaoPedidos.UseCompatibleStateImageBehavior = false;
            // 
            // butEditarPedido
            // 
            this.butEditarPedido.BackColor = System.Drawing.Color.DarkTurquoise;
            this.butEditarPedido.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEditarPedido.Location = new System.Drawing.Point(490, 485);
            this.butEditarPedido.Name = "butEditarPedido";
            this.butEditarPedido.Size = new System.Drawing.Size(119, 38);
            this.butEditarPedido.TabIndex = 22;
            this.butEditarPedido.Text = "Editar Pedido";
            this.butEditarPedido.UseVisualStyleBackColor = false;
            // 
            // butExportarTXT
            // 
            this.butExportarTXT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.butExportarTXT.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExportarTXT.Location = new System.Drawing.Point(924, 485);
            this.butExportarTXT.Name = "butExportarTXT";
            this.butExportarTXT.Size = new System.Drawing.Size(119, 38);
            this.butExportarTXT.TabIndex = 21;
            this.butExportarTXT.Text = "Exportar TXT";
            this.butExportarTXT.UseVisualStyleBackColor = false;
            // 
            // butExportarPDF
            // 
            this.butExportarPDF.BackColor = System.Drawing.Color.DarkTurquoise;
            this.butExportarPDF.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExportarPDF.Location = new System.Drawing.Point(799, 485);
            this.butExportarPDF.Name = "butExportarPDF";
            this.butExportarPDF.Size = new System.Drawing.Size(119, 38);
            this.butExportarPDF.TabIndex = 23;
            this.butExportarPDF.Text = "Exportar PDF";
            this.butExportarPDF.UseVisualStyleBackColor = false;
            // 
            // butConsultarPedidosTerminados
            // 
            this.butConsultarPedidosTerminados.BackColor = System.Drawing.Color.DarkTurquoise;
            this.butConsultarPedidosTerminados.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConsultarPedidosTerminados.Location = new System.Drawing.Point(615, 485);
            this.butConsultarPedidosTerminados.Name = "butConsultarPedidosTerminados";
            this.butConsultarPedidosTerminados.Size = new System.Drawing.Size(178, 38);
            this.butConsultarPedidosTerminados.TabIndex = 24;
            this.butConsultarPedidosTerminados.Text = "Ver Pedidos Concluídos";
            this.butConsultarPedidosTerminados.UseVisualStyleBackColor = false;
            // 
            // IdPedido
            // 
            this.IdPedido.Text = "Nr Pedido";
            // 
            // NomeFuncionario
            // 
            this.NomeFuncionario.Text = "Funcionário";
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            // 
            // ValorTotal
            // 
            this.ValorTotal.Text = "Valor Total";
            // 
            // MeioPagamento
            // 
            this.MeioPagamento.Text = "MeioPagamento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(984, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butConsultarPedidosTerminados);
            this.Controls.Add(this.butExportarPDF);
            this.Controls.Add(this.butEditarPedido);
            this.Controls.Add(this.butExportarTXT);
            this.Controls.Add(this.listViewGestaoPedidos);
            this.Controls.Add(this.butNovoPedido);
            this.Controls.Add(this.labelGestaoPedidos);
            this.Controls.Add(this.comboBoxSelecionarRestaurante);
            this.Controls.Add(this.labelSelecionarRestaurante);
            this.Controls.Add(this.pictureBoxLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPedidos";
            this.Text = "Gestão de Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelSelecionarRestaurante;
        private System.Windows.Forms.ComboBox comboBoxSelecionarRestaurante;
        private System.Windows.Forms.Label labelGestaoPedidos;
        private System.Windows.Forms.Button butNovoPedido;
        private System.Windows.Forms.ListView listViewGestaoPedidos;
        private System.Windows.Forms.Button butEditarPedido;
        private System.Windows.Forms.Button butExportarTXT;
        private System.Windows.Forms.Button butExportarPDF;
        private System.Windows.Forms.Button butConsultarPedidosTerminados;
        private System.Windows.Forms.ColumnHeader IdPedido;
        private System.Windows.Forms.ColumnHeader NomeFuncionario;
        private System.Windows.Forms.ColumnHeader Estado;
        private System.Windows.Forms.ColumnHeader ValorTotal;
        private System.Windows.Forms.ColumnHeader MeioPagamento;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}