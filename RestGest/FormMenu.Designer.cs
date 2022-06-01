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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butNovoMenu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxSelecionarRestaurante = new System.Windows.Forms.ListBox();
            this.labelSelecionarRestaurante = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Foto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butApagar = new System.Windows.Forms.Button();
            this.butEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // butNovoMenu
            // 
            this.butNovoMenu.BackColor = System.Drawing.Color.DarkTurquoise;
            this.butNovoMenu.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNovoMenu.Location = new System.Drawing.Point(882, 98);
            this.butNovoMenu.Name = "butNovoMenu";
            this.butNovoMenu.Size = new System.Drawing.Size(157, 54);
            this.butNovoMenu.TabIndex = 11;
            this.butNovoMenu.Text = "+ Novo Menu";
            this.butNovoMenu.UseVisualStyleBackColor = false;
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
            this.label1.Location = new System.Drawing.Point(790, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gestão de Menus";
            // 
            // listBoxSelecionarRestaurante
            // 
            this.listBoxSelecionarRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSelecionarRestaurante.FormattingEnabled = true;
            this.listBoxSelecionarRestaurante.ItemHeight = 22;
            this.listBoxSelecionarRestaurante.Location = new System.Drawing.Point(228, 98);
            this.listBoxSelecionarRestaurante.Name = "listBoxSelecionarRestaurante";
            this.listBoxSelecionarRestaurante.Size = new System.Drawing.Size(284, 26);
            this.listBoxSelecionarRestaurante.TabIndex = 14;
            // 
            // labelSelecionarRestaurante
            // 
            this.labelSelecionarRestaurante.AutoSize = true;
            this.labelSelecionarRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelecionarRestaurante.Location = new System.Drawing.Point(225, 66);
            this.labelSelecionarRestaurante.Name = "labelSelecionarRestaurante";
            this.labelSelecionarRestaurante.Size = new System.Drawing.Size(211, 20);
            this.labelSelecionarRestaurante.TabIndex = 15;
            this.labelSelecionarRestaurante.Text = "Selecione um Restaurante:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Foto,
            this.Descricao,
            this.Preco});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(32, 176);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1007, 266);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            this.butApagar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.butApagar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butApagar.Location = new System.Drawing.Point(920, 448);
            this.butApagar.Name = "butApagar";
            this.butApagar.Size = new System.Drawing.Size(119, 38);
            this.butApagar.TabIndex = 18;
            this.butApagar.Text = "Apagar";
            this.butApagar.UseVisualStyleBackColor = false;
            // 
            // butEditar
            // 
            this.butEditar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.butEditar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEditar.Location = new System.Drawing.Point(795, 448);
            this.butEditar.Name = "butEditar";
            this.butEditar.Size = new System.Drawing.Size(119, 38);
            this.butEditar.TabIndex = 19;
            this.butEditar.Text = "Editar";
            this.butEditar.UseVisualStyleBackColor = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.butEditar);
            this.Controls.Add(this.butApagar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelSelecionarRestaurante);
            this.Controls.Add(this.listBoxSelecionarRestaurante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butNovoMenu);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butNovoMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxSelecionarRestaurante;
        private System.Windows.Forms.Label labelSelecionarRestaurante;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Foto;
        private System.Windows.Forms.ColumnHeader Descricao;
        private System.Windows.Forms.ColumnHeader Preco;
        private System.Windows.Forms.Button butApagar;
        private System.Windows.Forms.Button butEditar;
    }
}