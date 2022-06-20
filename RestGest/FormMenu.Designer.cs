namespace RestGest
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.butNovoPrato = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelSelecionarRestaurante = new System.Windows.Forms.Label();
            this.listViewGestaoMenus = new System.Windows.Forms.ListView();
            this.Foto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butApagar = new System.Windows.Forms.Button();
            this.butEditar = new System.Windows.Forms.Button();
            this.comboBoxSelecionarRestaurante = new System.Windows.Forms.ComboBox();
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
            this.pictureBoxLogo.TabIndex = 10;
            this.pictureBoxLogo.TabStop = false;
            // 
            // butNovoPrato
            // 
            this.butNovoPrato.BackColor = System.Drawing.Color.SlateGray;
            this.butNovoPrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNovoPrato.ForeColor = System.Drawing.SystemColors.Control;
            this.butNovoPrato.Location = new System.Drawing.Point(882, 109);
            this.butNovoPrato.Name = "butNovoPrato";
            this.butNovoPrato.Size = new System.Drawing.Size(157, 54);
            this.butNovoPrato.TabIndex = 11;
            this.butNovoPrato.Text = "+ Novo Prato";
            this.butNovoPrato.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(789, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gestão de Menus";
            // 
            // labelSelecionarRestaurante
            // 
            this.labelSelecionarRestaurante.AutoSize = true;
            this.labelSelecionarRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelecionarRestaurante.Location = new System.Drawing.Point(211, 97);
            this.labelSelecionarRestaurante.Name = "labelSelecionarRestaurante";
            this.labelSelecionarRestaurante.Size = new System.Drawing.Size(211, 20);
            this.labelSelecionarRestaurante.TabIndex = 15;
            this.labelSelecionarRestaurante.Text = "Selecione um Restaurante:";
            // 
            // listViewGestaoMenus
            // 
            this.listViewGestaoMenus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Foto,
            this.Descricao,
            this.Preco});
            this.listViewGestaoMenus.HideSelection = false;
            this.listViewGestaoMenus.Location = new System.Drawing.Point(32, 176);
            this.listViewGestaoMenus.Name = "listViewGestaoMenus";
            this.listViewGestaoMenus.Size = new System.Drawing.Size(1007, 266);
            this.listViewGestaoMenus.TabIndex = 16;
            this.listViewGestaoMenus.UseCompatibleStateImageBehavior = false;
            // 
            // Foto
            // 
            this.Foto.Text = "Imagem do Prato";
            // 
            // Descricao
            // 
            this.Descricao.Text = "Descrição";
            this.Descricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Preco
            // 
            this.Preco.Text = "Preço";
            this.Preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butApagar
            // 
            this.butApagar.BackColor = System.Drawing.Color.SlateGray;
            this.butApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butApagar.ForeColor = System.Drawing.SystemColors.Control;
            this.butApagar.Location = new System.Drawing.Point(920, 458);
            this.butApagar.Name = "butApagar";
            this.butApagar.Size = new System.Drawing.Size(119, 38);
            this.butApagar.TabIndex = 18;
            this.butApagar.Text = "Apagar";
            this.butApagar.UseVisualStyleBackColor = false;
            // 
            // butEditar
            // 
            this.butEditar.BackColor = System.Drawing.Color.SlateGray;
            this.butEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.butEditar.Location = new System.Drawing.Point(795, 458);
            this.butEditar.Name = "butEditar";
            this.butEditar.Size = new System.Drawing.Size(119, 38);
            this.butEditar.TabIndex = 19;
            this.butEditar.Text = "Editar";
            this.butEditar.UseVisualStyleBackColor = false;
            // 
            // comboBoxSelecionarRestaurante
            // 
            this.comboBoxSelecionarRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelecionarRestaurante.FormattingEnabled = true;
            this.comboBoxSelecionarRestaurante.ItemHeight = 25;
            this.comboBoxSelecionarRestaurante.Location = new System.Drawing.Point(211, 130);
            this.comboBoxSelecionarRestaurante.Name = "comboBoxSelecionarRestaurante";
            this.comboBoxSelecionarRestaurante.Size = new System.Drawing.Size(399, 33);
            this.comboBoxSelecionarRestaurante.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(984, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.goHome_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxSelecionarRestaurante);
            this.Controls.Add(this.butEditar);
            this.Controls.Add(this.butApagar);
            this.Controls.Add(this.listViewGestaoMenus);
            this.Controls.Add(this.labelSelecionarRestaurante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butNovoPrato);
            this.Controls.Add(this.pictureBoxLogo);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "Gestão de Menus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button butNovoPrato;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSelecionarRestaurante;
        private System.Windows.Forms.ListView listViewGestaoMenus;
        private System.Windows.Forms.ColumnHeader Foto;
        private System.Windows.Forms.ColumnHeader Descricao;
        private System.Windows.Forms.ColumnHeader Preco;
        private System.Windows.Forms.Button butApagar;
        private System.Windows.Forms.Button butEditar;
        private System.Windows.Forms.ComboBox comboBoxSelecionarRestaurante;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}