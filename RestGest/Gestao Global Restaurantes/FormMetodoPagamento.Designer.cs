namespace RestGest.Gestao_Global_Restaurantes
{
    partial class FormMetodoPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMetodoPagamento));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewCategoria = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblSelecionarCliente = new System.Windows.Forms.Label();
            this.lblAddCat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.restGestDBDataSet = new RestGest.RestGestDBDataSet();
            this.metodoPagamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metodoPagamentosTableAdapter = new RestGest.RestGestDBDataSetTableAdapters.MetodoPagamentosTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoPagamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(199, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 46;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewCategoria
            // 
            this.dataGridViewCategoria.AllowUserToOrderColumns = true;
            this.dataGridViewCategoria.AutoGenerateColumns = false;
            this.dataGridViewCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.metodoPagamentDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn});
            this.dataGridViewCategoria.DataSource = this.metodoPagamentosBindingSource;
            this.dataGridViewCategoria.Location = new System.Drawing.Point(90, 218);
            this.dataGridViewCategoria.Name = "dataGridViewCategoria";
            this.dataGridViewCategoria.RowHeadersWidth = 51;
            this.dataGridViewCategoria.RowTemplate.Height = 24;
            this.dataGridViewCategoria.Size = new System.Drawing.Size(430, 150);
            this.dataGridViewCategoria.TabIndex = 45;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SlateGray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSair.Location = new System.Drawing.Point(322, 390);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(105, 36);
            this.btnSair.TabIndex = 44;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblSelecionarCliente
            // 
            this.lblSelecionarCliente.AutoSize = true;
            this.lblSelecionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarCliente.Location = new System.Drawing.Point(97, 197);
            this.lblSelecionarCliente.Name = "lblSelecionarCliente";
            this.lblSelecionarCliente.Size = new System.Drawing.Size(317, 18);
            this.lblSelecionarCliente.TabIndex = 43;
            this.lblSelecionarCliente.Text = "Adicionar / Modificar Métodos de Pagamentos ";
            // 
            // lblAddCat
            // 
            this.lblAddCat.AutoSize = true;
            this.lblAddCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCat.Location = new System.Drawing.Point(137, 27);
            this.lblAddCat.Name = "lblAddCat";
            this.lblAddCat.Size = new System.Drawing.Size(356, 29);
            this.lblAddCat.TabIndex = 42;
            this.lblAddCat.Text = "Gerir Métodos de Pagamento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(243, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // restGestDBDataSet
            // 
            this.restGestDBDataSet.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metodoPagamentosBindingSource
            // 
            this.metodoPagamentosBindingSource.DataMember = "MetodoPagamentos";
            this.metodoPagamentosBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // metodoPagamentosTableAdapter
            // 
            this.metodoPagamentosTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // metodoPagamentDataGridViewTextBoxColumn
            // 
            this.metodoPagamentDataGridViewTextBoxColumn.DataPropertyName = "MetodoPagament";
            this.metodoPagamentDataGridViewTextBoxColumn.HeaderText = "MetodoPagament";
            this.metodoPagamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.metodoPagamentDataGridViewTextBoxColumn.Name = "metodoPagamentDataGridViewTextBoxColumn";
            this.metodoPagamentDataGridViewTextBoxColumn.Width = 125;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // FormMetodoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewCategoria);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblSelecionarCliente);
            this.Controls.Add(this.lblAddCat);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMetodoPagamento";
            this.Text = "FormMetodoPagamento";
            this.Load += new System.EventHandler(this.FormMetodoPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewCategoria;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblSelecionarCliente;
        private System.Windows.Forms.Label lblAddCat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource metodoPagamentosBindingSource;
        private RestGestDBDataSetTableAdapters.MetodoPagamentosTableAdapter metodoPagamentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoPagamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
    }
}