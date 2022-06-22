namespace RestGest
{
    partial class FormApagarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApagarCliente));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblApagarCliente = new System.Windows.Forms.Label();
            this.lblSelecionarCliente = new System.Windows.Forms.Label();
            this.comboBoxListaClientes = new System.Windows.Forms.ComboBox();
            this.btApagarCliente = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(137, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblApagarCliente
            // 
            this.lblApagarCliente.AutoSize = true;
            this.lblApagarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagarCliente.Location = new System.Drawing.Point(115, 9);
            this.lblApagarCliente.Name = "lblApagarCliente";
            this.lblApagarCliente.Size = new System.Drawing.Size(186, 29);
            this.lblApagarCliente.TabIndex = 28;
            this.lblApagarCliente.Text = "Apagar Cliente";
            // 
            // lblSelecionarCliente
            // 
            this.lblSelecionarCliente.AutoSize = true;
            this.lblSelecionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarCliente.Location = new System.Drawing.Point(72, 225);
            this.lblSelecionarCliente.Name = "lblSelecionarCliente";
            this.lblSelecionarCliente.Size = new System.Drawing.Size(260, 18);
            this.lblSelecionarCliente.TabIndex = 29;
            this.lblSelecionarCliente.Text = "Selecione o cliente que deseja apagar:";
            // 
            // comboBoxListaClientes
            // 
            this.comboBoxListaClientes.FormattingEnabled = true;
            this.comboBoxListaClientes.Location = new System.Drawing.Point(33, 262);
            this.comboBoxListaClientes.Name = "comboBoxListaClientes";
            this.comboBoxListaClientes.Size = new System.Drawing.Size(339, 24);
            this.comboBoxListaClientes.TabIndex = 30;
            this.comboBoxListaClientes.SelectedIndexChanged += new System.EventHandler(this.comboBoxListaClientes_SelectedIndexChanged);
            // 
            // btApagarCliente
            // 
            this.btApagarCliente.BackColor = System.Drawing.Color.SlateGray;
            this.btApagarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApagarCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btApagarCliente.Location = new System.Drawing.Point(33, 345);
            this.btApagarCliente.Name = "btApagarCliente";
            this.btApagarCliente.Size = new System.Drawing.Size(105, 36);
            this.btApagarCliente.TabIndex = 32;
            this.btApagarCliente.Text = "Apagar";
            this.btApagarCliente.UseVisualStyleBackColor = false;
            this.btApagarCliente.Click += new System.EventHandler(this.btApagarCliente_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SlateGray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSair.Location = new System.Drawing.Point(267, 345);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(105, 36);
            this.btnSair.TabIndex = 33;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormApagarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 418);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btApagarCliente);
            this.Controls.Add(this.comboBoxListaClientes);
            this.Controls.Add(this.lblSelecionarCliente);
            this.Controls.Add(this.lblApagarCliente);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormApagarCliente";
            this.Text = "FormApagarCliente";
            this.Load += new System.EventHandler(this.FormApagarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblApagarCliente;
        private System.Windows.Forms.Label lblSelecionarCliente;
        private System.Windows.Forms.ComboBox comboBoxListaClientes;
        private System.Windows.Forms.Button btApagarCliente;
        private System.Windows.Forms.Button btnSair;
    }
}