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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelSelecionarRestaurante = new System.Windows.Forms.Label();
            this.comboBoxSelecionarRestaurante = new System.Windows.Forms.ComboBox();
            this.labelGestaoPedidos = new System.Windows.Forms.Label();
            this.butNovoPedido = new System.Windows.Forms.Button();
            this.butEditarPedido = new System.Windows.Forms.Button();
            this.butExportarTXT = new System.Windows.Forms.Button();
            this.butExportarPDF = new System.Windows.Forms.Button();
            this.butConsultarPedidosTerminados = new System.Windows.Forms.Button();
            this.goHome = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restauranteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabalhadorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restGestDBDataSet = new RestGest.RestGestDBDataSet();
            this.pedidosTableAdapter = new RestGest.RestGestDBDataSetTableAdapters.PedidosTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
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
            this.butNovoPedido.BackColor = System.Drawing.Color.SlateGray;
            this.butNovoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNovoPedido.ForeColor = System.Drawing.SystemColors.Control;
            this.butNovoPedido.Location = new System.Drawing.Point(886, 109);
            this.butNovoPedido.Name = "butNovoPedido";
            this.butNovoPedido.Size = new System.Drawing.Size(157, 54);
            this.butNovoPedido.TabIndex = 19;
            this.butNovoPedido.Text = "Novo Pedido";
            this.butNovoPedido.UseVisualStyleBackColor = false;
            this.butNovoPedido.Click += new System.EventHandler(this.butNovoPedido_Click);
            // 
            // butEditarPedido
            // 
            this.butEditarPedido.BackColor = System.Drawing.Color.SlateGray;
            this.butEditarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEditarPedido.ForeColor = System.Drawing.SystemColors.Control;
            this.butEditarPedido.Location = new System.Drawing.Point(490, 485);
            this.butEditarPedido.Name = "butEditarPedido";
            this.butEditarPedido.Size = new System.Drawing.Size(119, 38);
            this.butEditarPedido.TabIndex = 22;
            this.butEditarPedido.Text = "Editar Pedido";
            this.butEditarPedido.UseVisualStyleBackColor = false;
            // 
            // butExportarTXT
            // 
            this.butExportarTXT.BackColor = System.Drawing.Color.SlateGray;
            this.butExportarTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExportarTXT.ForeColor = System.Drawing.SystemColors.Control;
            this.butExportarTXT.Location = new System.Drawing.Point(924, 485);
            this.butExportarTXT.Name = "butExportarTXT";
            this.butExportarTXT.Size = new System.Drawing.Size(119, 38);
            this.butExportarTXT.TabIndex = 21;
            this.butExportarTXT.Text = "Exportar TXT";
            this.butExportarTXT.UseVisualStyleBackColor = false;
            this.butExportarTXT.Click += new System.EventHandler(this.butExportarTXT_Click);
            // 
            // butExportarPDF
            // 
            this.butExportarPDF.BackColor = System.Drawing.Color.SlateGray;
            this.butExportarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExportarPDF.ForeColor = System.Drawing.SystemColors.Control;
            this.butExportarPDF.Location = new System.Drawing.Point(799, 485);
            this.butExportarPDF.Name = "butExportarPDF";
            this.butExportarPDF.Size = new System.Drawing.Size(119, 38);
            this.butExportarPDF.TabIndex = 23;
            this.butExportarPDF.Text = "Exportar PDF";
            this.butExportarPDF.UseVisualStyleBackColor = false;
            this.butExportarPDF.Click += new System.EventHandler(this.butExportarPDF_Click);
            // 
            // butConsultarPedidosTerminados
            // 
            this.butConsultarPedidosTerminados.BackColor = System.Drawing.Color.SlateGray;
            this.butConsultarPedidosTerminados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConsultarPedidosTerminados.ForeColor = System.Drawing.SystemColors.Control;
            this.butConsultarPedidosTerminados.Location = new System.Drawing.Point(615, 485);
            this.butConsultarPedidosTerminados.Name = "butConsultarPedidosTerminados";
            this.butConsultarPedidosTerminados.Size = new System.Drawing.Size(178, 38);
            this.butConsultarPedidosTerminados.TabIndex = 24;
            this.butConsultarPedidosTerminados.Text = "Ver Pedidos Concluídos";
            this.butConsultarPedidosTerminados.UseVisualStyleBackColor = false;
            // 
            // goHome
            // 
            this.goHome.Image = ((System.Drawing.Image)(resources.GetObject("goHome.Image")));
            this.goHome.Location = new System.Drawing.Point(984, 16);
            this.goHome.Name = "goHome";
            this.goHome.Size = new System.Drawing.Size(46, 37);
            this.goHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goHome.TabIndex = 25;
            this.goHome.TabStop = false;
            this.goHome.Click += new System.EventHandler(this.goHome_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.clienteIdDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn,
            this.estadoIdDataGridViewTextBoxColumn,
            this.restauranteIdDataGridViewTextBoxColumn,
            this.trabalhadorIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pedidosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(25, 212);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 267);
            this.dataGridView1.TabIndex = 26;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // clienteIdDataGridViewTextBoxColumn
            // 
            this.clienteIdDataGridViewTextBoxColumn.DataPropertyName = "ClienteId";
            this.clienteIdDataGridViewTextBoxColumn.HeaderText = "ClienteId";
            this.clienteIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clienteIdDataGridViewTextBoxColumn.Name = "clienteIdDataGridViewTextBoxColumn";
            this.clienteIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoIdDataGridViewTextBoxColumn
            // 
            this.estadoIdDataGridViewTextBoxColumn.DataPropertyName = "EstadoId";
            this.estadoIdDataGridViewTextBoxColumn.HeaderText = "EstadoId";
            this.estadoIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoIdDataGridViewTextBoxColumn.Name = "estadoIdDataGridViewTextBoxColumn";
            this.estadoIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // restauranteIdDataGridViewTextBoxColumn
            // 
            this.restauranteIdDataGridViewTextBoxColumn.DataPropertyName = "RestauranteId";
            this.restauranteIdDataGridViewTextBoxColumn.HeaderText = "RestauranteId";
            this.restauranteIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.restauranteIdDataGridViewTextBoxColumn.Name = "restauranteIdDataGridViewTextBoxColumn";
            this.restauranteIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // trabalhadorIdDataGridViewTextBoxColumn
            // 
            this.trabalhadorIdDataGridViewTextBoxColumn.DataPropertyName = "TrabalhadorId";
            this.trabalhadorIdDataGridViewTextBoxColumn.HeaderText = "TrabalhadorId";
            this.trabalhadorIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trabalhadorIdDataGridViewTextBoxColumn.Name = "trabalhadorIdDataGridViewTextBoxColumn";
            this.trabalhadorIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "Pedidos";
            this.pedidosBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // restGestDBDataSet
            // 
            this.restGestDBDataSet.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.goHome);
            this.Controls.Add(this.butConsultarPedidosTerminados);
            this.Controls.Add(this.butExportarPDF);
            this.Controls.Add(this.butEditarPedido);
            this.Controls.Add(this.butExportarTXT);
            this.Controls.Add(this.butNovoPedido);
            this.Controls.Add(this.labelGestaoPedidos);
            this.Controls.Add(this.comboBoxSelecionarRestaurante);
            this.Controls.Add(this.labelSelecionarRestaurante);
            this.Controls.Add(this.pictureBoxLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPedidos";
            this.Text = "Gestão de Pedidos";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelSelecionarRestaurante;
        private System.Windows.Forms.ComboBox comboBoxSelecionarRestaurante;
        private System.Windows.Forms.Label labelGestaoPedidos;
        private System.Windows.Forms.Button butNovoPedido;
        private System.Windows.Forms.Button butEditarPedido;
        private System.Windows.Forms.Button butExportarTXT;
        private System.Windows.Forms.Button butExportarPDF;
        private System.Windows.Forms.Button butConsultarPedidosTerminados;
        private System.Windows.Forms.PictureBox goHome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private RestGestDBDataSetTableAdapters.PedidosTableAdapter pedidosTableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restauranteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trabalhadorIdDataGridViewTextBoxColumn;
    }
}