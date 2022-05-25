namespace RestGest
{
    partial class FormGlobalRestaurantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGlobalRestaurantes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btAbrirMenu = new System.Windows.Forms.Button();
            this.btAlterarRestaurante = new System.Windows.Forms.Button();
            this.lbMétodosPagamento = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(304, 98);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(430, 36);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Gestão Global de Restaurantes";
            // 
            // btAbrirMenu
            // 
            this.btAbrirMenu.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btAbrirMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAbrirMenu.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrirMenu.Location = new System.Drawing.Point(204, 269);
            this.btAbrirMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btAbrirMenu.Name = "btAbrirMenu";
            this.btAbrirMenu.Size = new System.Drawing.Size(248, 57);
            this.btAbrirMenu.TabIndex = 2;
            this.btAbrirMenu.Text = "Registar Restaurante";
            this.btAbrirMenu.UseVisualStyleBackColor = false;
            this.btAbrirMenu.Click += new System.EventHandler(this.btAbrirMenu_Click);
            // 
            // btAlterarRestaurante
            // 
            this.btAlterarRestaurante.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btAlterarRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterarRestaurante.Location = new System.Drawing.Point(628, 269);
            this.btAlterarRestaurante.Margin = new System.Windows.Forms.Padding(4);
            this.btAlterarRestaurante.Name = "btAlterarRestaurante";
            this.btAlterarRestaurante.Size = new System.Drawing.Size(240, 57);
            this.btAlterarRestaurante.TabIndex = 3;
            this.btAlterarRestaurante.Text = "Alterar Restaurante";
            this.btAlterarRestaurante.UseVisualStyleBackColor = false;
            this.btAlterarRestaurante.Click += new System.EventHandler(this.btAlterarRestaurante_Click);
            // 
            // lbMétodosPagamento
            // 
            this.lbMétodosPagamento.FormattingEnabled = true;
            this.lbMétodosPagamento.ItemHeight = 16;
            this.lbMétodosPagamento.Items.AddRange(new object[] {
            "Multibanco",
            "Cartão de Crédito",
            "Numerário"});
            this.lbMétodosPagamento.Location = new System.Drawing.Point(26, 388);
            this.lbMétodosPagamento.Name = "lbMétodosPagamento";
            this.lbMétodosPagamento.Size = new System.Drawing.Size(473, 196);
            this.lbMétodosPagamento.TabIndex = 4;
            // 
            // FormGlobalRestaurantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 629);
            this.Controls.Add(this.lbMétodosPagamento);
            this.Controls.Add(this.btAlterarRestaurante);
            this.Controls.Add(this.btAbrirMenu);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGlobalRestaurantes";
            this.Text = "FormGlobalRestaurantes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btAbrirMenu;
        private System.Windows.Forms.Button btAlterarRestaurante;
        private System.Windows.Forms.ListBox lbMétodosPagamento;
    }
}