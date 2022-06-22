namespace RestGest
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.btAdicionarCliente = new System.Windows.Forms.Button();
            this.btAlterarForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbNif = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.tbCodPostal = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbTelemovel = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxListaClientes = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telemovel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restGestDBDataSet = new RestGest.RestGestDBDataSet();
            this.pessoasClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoas_ClienteTableAdapter = new RestGest.RestGestDBDataSetTableAdapters.Pessoas_ClienteTableAdapter();
            this.pessoasTableAdapter = new RestGest.RestGestDBDataSetTableAdapters.PessoasTableAdapter();
            this.moradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moradasTableAdapter = new RestGest.RestGestDBDataSetTableAdapters.MoradasTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBoxListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestão de Clientes";
            // 
            // btAdicionarCliente
            // 
            this.btAdicionarCliente.BackColor = System.Drawing.Color.SlateGray;
            this.btAdicionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionarCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btAdicionarCliente.Location = new System.Drawing.Point(484, 524);
            this.btAdicionarCliente.Name = "btAdicionarCliente";
            this.btAdicionarCliente.Size = new System.Drawing.Size(157, 37);
            this.btAdicionarCliente.TabIndex = 14;
            this.btAdicionarCliente.Text = "Registar Cliente";
            this.btAdicionarCliente.UseVisualStyleBackColor = false;
            this.btAdicionarCliente.Click += new System.EventHandler(this.btAdicionarCliente_Click);
            // 
            // btAlterarForm
            // 
            this.btAlterarForm.BackColor = System.Drawing.Color.SlateGray;
            this.btAlterarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterarForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btAlterarForm.Location = new System.Drawing.Point(301, 524);
            this.btAlterarForm.Name = "btAlterarForm";
            this.btAlterarForm.Size = new System.Drawing.Size(157, 36);
            this.btAlterarForm.TabIndex = 15;
            this.btAlterarForm.Text = "Alterar Clientes";
            this.btAlterarForm.UseVisualStyleBackColor = false;
            this.btAlterarForm.Click += new System.EventHandler(this.btAlterarForm_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(876, 524);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 22;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbPais);
            this.groupBox1.Controls.Add(this.tbNif);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbRua);
            this.groupBox1.Controls.Add(this.tbCodPostal);
            this.groupBox1.Controls.Add(this.tbCidade);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.tbTelemovel);
            this.groupBox1.Location = new System.Drawing.Point(301, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 195);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registar Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telemovel:";
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(461, 75);
            this.tbPais.Margin = new System.Windows.Forms.Padding(4);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(219, 22);
            this.tbPais.TabIndex = 15;
            this.tbPais.Validating += new System.ComponentModel.CancelEventHandler(this.tbPais_Validating);
            // 
            // tbNif
            // 
            this.tbNif.Location = new System.Drawing.Point(461, 33);
            this.tbNif.Margin = new System.Windows.Forms.Padding(4);
            this.tbNif.Name = "tbNif";
            this.tbNif.Size = new System.Drawing.Size(219, 22);
            this.tbNif.TabIndex = 14;
            this.tbNif.Text = " ";
            this.tbNif.TextChanged += new System.EventHandler(this.tbNif_TextChanged);
            this.tbNif.Validating += new System.ComponentModel.CancelEventHandler(this.tbNif_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nif:";
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(64, 113);
            this.tbRua.Margin = new System.Windows.Forms.Padding(4);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(273, 22);
            this.tbRua.TabIndex = 12;
            this.tbRua.Validating += new System.ComponentModel.CancelEventHandler(this.tbRua_Validating);
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Location = new System.Drawing.Point(526, 156);
            this.tbCodPostal.Margin = new System.Windows.Forms.Padding(4);
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(154, 22);
            this.tbCodPostal.TabIndex = 11;
            this.tbCodPostal.Text = " ";
            this.tbCodPostal.Validating += new System.ComponentModel.CancelEventHandler(this.tbCodPostal_Validating);
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(492, 113);
            this.tbCidade.Margin = new System.Windows.Forms.Padding(4);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(188, 22);
            this.tbCidade.TabIndex = 10;
            this.tbCidade.Validating += new System.ComponentModel.CancelEventHandler(this.tbCidade_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Rua:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(418, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cod. Postal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "País:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cidade:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(77, 35);
            this.tbNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(260, 22);
            this.tbNome.TabIndex = 4;
            this.tbNome.Text = " ";
            this.tbNome.Validating += new System.ComponentModel.CancelEventHandler(this.tbNome_Validating);
            // 
            // tbTelemovel
            // 
            this.tbTelemovel.Location = new System.Drawing.Point(109, 73);
            this.tbTelemovel.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelemovel.Name = "tbTelemovel";
            this.tbTelemovel.Size = new System.Drawing.Size(228, 22);
            this.tbTelemovel.TabIndex = 5;
            this.tbTelemovel.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelemovel_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(688, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Apagar Cliente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnApagarCliente);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBoxListaClientes
            // 
            this.groupBoxListaClientes.Controls.Add(this.dataGridView1);
            this.groupBoxListaClientes.Location = new System.Drawing.Point(301, 295);
            this.groupBoxListaClientes.Name = "groupBoxListaClientes";
            this.groupBoxListaClientes.Size = new System.Drawing.Size(693, 205);
            this.groupBoxListaClientes.TabIndex = 25;
            this.groupBoxListaClientes.TabStop = false;
            this.groupBoxListaClientes.Text = "Lista de Clientes:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Nome,
            this.Telemovel});
            this.dataGridView1.DataSource = this.pessoasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(665, 165);
            this.dataGridView1.TabIndex = 0;
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
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 125;
            // 
            // Telemovel
            // 
            this.Telemovel.DataPropertyName = "Telemovel";
            this.Telemovel.HeaderText = "Telemovel";
            this.Telemovel.MinimumWidth = 6;
            this.Telemovel.Name = "Telemovel";
            this.Telemovel.ReadOnly = true;
            this.Telemovel.Width = 125;
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataMember = "Pessoas";
            this.pessoasBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // restGestDBDataSet
            // 
            this.restGestDBDataSet.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoasClienteBindingSource
            // 
            this.pessoasClienteBindingSource.DataMember = "Pessoas_Cliente";
            this.pessoasClienteBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // pessoas_ClienteTableAdapter
            // 
            this.pessoas_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // pessoasTableAdapter
            // 
            this.pessoasTableAdapter.ClearBeforeFill = true;
            // 
            // moradasBindingSource
            // 
            this.moradasBindingSource.DataMember = "Moradas";
            this.moradasBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // moradasTableAdapter
            // 
            this.moradasTableAdapter.ClearBeforeFill = true;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 590);
            this.Controls.Add(this.groupBoxListaClientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btAlterarForm);
            this.Controls.Add(this.btAdicionarCliente);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClientes";
            this.Text = "Gestão de Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBoxListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdicionarCliente;
        private System.Windows.Forms.Button btAlterarForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.TextBox tbCodPostal;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbTelemovel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBoxListaClientes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource pessoasClienteBindingSource;
        private RestGestDBDataSetTableAdapters.Pessoas_ClienteTableAdapter pessoas_ClienteTableAdapter;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private RestGestDBDataSetTableAdapters.PessoasTableAdapter pessoasTableAdapter;
        private System.Windows.Forms.BindingSource moradasBindingSource;
        private RestGestDBDataSetTableAdapters.MoradasTableAdapter moradasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telemovel;
    }
}

