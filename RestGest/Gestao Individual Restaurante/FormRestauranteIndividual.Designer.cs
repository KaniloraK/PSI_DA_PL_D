namespace RestGest
{
    partial class FormRestauranteIndividual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRestauranteIndividual));
            this.label1 = new System.Windows.Forms.Label();
            this.cbRestauranteSelecionado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFuncionarios = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSairRestauranteIndividual = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegistarMenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.restGestDBDataSet = new RestGest.RestGestDBDataSet();
            this.itemMenusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemMenusTableAdapter = new RestGest.RestGestDBDataSetTableAdapters.ItemMenusTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.categoriaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMenusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurante:";
            // 
            // cbRestauranteSelecionado
            // 
            this.cbRestauranteSelecionado.FormattingEnabled = true;
            this.cbRestauranteSelecionado.Location = new System.Drawing.Point(487, 42);
            this.cbRestauranteSelecionado.Name = "cbRestauranteSelecionado";
            this.cbRestauranteSelecionado.Size = new System.Drawing.Size(310, 24);
            this.cbRestauranteSelecionado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Funcionários:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Menus:";
            // 
            // lbFuncionarios
            // 
            this.lbFuncionarios.FormattingEnabled = true;
            this.lbFuncionarios.ItemHeight = 16;
            this.lbFuncionarios.Location = new System.Drawing.Point(487, 98);
            this.lbFuncionarios.Name = "lbFuncionarios";
            this.lbFuncionarios.Size = new System.Drawing.Size(314, 196);
            this.lbFuncionarios.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btSairRestauranteIndividual
            // 
            this.btSairRestauranteIndividual.BackColor = System.Drawing.Color.SlateGray;
            this.btSairRestauranteIndividual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSairRestauranteIndividual.ForeColor = System.Drawing.SystemColors.Control;
            this.btSairRestauranteIndividual.Location = new System.Drawing.Point(973, 35);
            this.btSairRestauranteIndividual.Name = "btSairRestauranteIndividual";
            this.btSairRestauranteIndividual.Size = new System.Drawing.Size(109, 45);
            this.btSairRestauranteIndividual.TabIndex = 11;
            this.btSairRestauranteIndividual.Text = "Sair";
            this.btSairRestauranteIndividual.UseVisualStyleBackColor = false;
            this.btSairRestauranteIndividual.Click += new System.EventHandler(this.btSairRestauranteIndividual_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(872, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "Registar Trabalhador";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistarMenu
            // 
            this.btnRegistarMenu.BackColor = System.Drawing.Color.SlateGray;
            this.btnRegistarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistarMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistarMenu.Location = new System.Drawing.Point(872, 195);
            this.btnRegistarMenu.Name = "btnRegistarMenu";
            this.btnRegistarMenu.Size = new System.Drawing.Size(210, 51);
            this.btnRegistarMenu.TabIndex = 13;
            this.btnRegistarMenu.Text = "Registar Menu";
            this.btnRegistarMenu.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.fotografiaDataGridViewTextBoxColumn,
            this.ingredientesDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.categoriaIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemMenusBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 408);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1027, 229);
            this.dataGridView1.TabIndex = 14;
            // 
            // restGestDBDataSet
            // 
            this.restGestDBDataSet.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemMenusBindingSource
            // 
            this.itemMenusBindingSource.DataMember = "ItemMenus";
            this.itemMenusBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // itemMenusTableAdapter
            // 
            this.itemMenusTableAdapter.ClearBeforeFill = true;
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
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // fotografiaDataGridViewTextBoxColumn
            // 
            this.fotografiaDataGridViewTextBoxColumn.DataPropertyName = "Fotografia";
            this.fotografiaDataGridViewTextBoxColumn.HeaderText = "Fotografia";
            this.fotografiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fotografiaDataGridViewTextBoxColumn.Name = "fotografiaDataGridViewTextBoxColumn";
            this.fotografiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // ingredientesDataGridViewTextBoxColumn
            // 
            this.ingredientesDataGridViewTextBoxColumn.DataPropertyName = "Ingredientes";
            this.ingredientesDataGridViewTextBoxColumn.HeaderText = "Ingredientes";
            this.ingredientesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ingredientesDataGridViewTextBoxColumn.Name = "ingredientesDataGridViewTextBoxColumn";
            this.ingredientesDataGridViewTextBoxColumn.Width = 125;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // categoriaIdDataGridViewTextBoxColumn
            // 
            this.categoriaIdDataGridViewTextBoxColumn.DataPropertyName = "CategoriaId";
            this.categoriaIdDataGridViewTextBoxColumn.HeaderText = "CategoriaId";
            this.categoriaIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoriaIdDataGridViewTextBoxColumn.Name = "categoriaIdDataGridViewTextBoxColumn";
            this.categoriaIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormRestauranteIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 649);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegistarMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSairRestauranteIndividual);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbFuncionarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRestauranteSelecionado);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRestauranteIndividual";
            this.Text = "Gestão Individual de Restaurante";
            this.Load += new System.EventHandler(this.FormRestauranteIndividual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMenusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRestauranteSelecionado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbFuncionarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btSairRestauranteIndividual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegistarMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource itemMenusBindingSource;
        private RestGestDBDataSetTableAdapters.ItemMenusTableAdapter itemMenusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotografiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaIdDataGridViewTextBoxColumn;
    }
}