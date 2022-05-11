namespace RestGest
{
    partial class FormPrincipal
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
            this.buttonRestaurantes = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonPedidos = new System.Windows.Forms.Button();
            this.buttonMenus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRestaurantes
            // 
            this.buttonRestaurantes.Location = new System.Drawing.Point(277, 80);
            this.buttonRestaurantes.Name = "buttonRestaurantes";
            this.buttonRestaurantes.Size = new System.Drawing.Size(189, 23);
            this.buttonRestaurantes.TabIndex = 0;
            this.buttonRestaurantes.Text = "Restaurantes";
            this.buttonRestaurantes.UseVisualStyleBackColor = true;
            // 
            // buttonClientes
            // 
            this.buttonClientes.Location = new System.Drawing.Point(277, 147);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(189, 23);
            this.buttonClientes.TabIndex = 1;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            // 
            // buttonPedidos
            // 
            this.buttonPedidos.Location = new System.Drawing.Point(277, 216);
            this.buttonPedidos.Name = "buttonPedidos";
            this.buttonPedidos.Size = new System.Drawing.Size(189, 23);
            this.buttonPedidos.TabIndex = 2;
            this.buttonPedidos.Text = "Pedidos";
            this.buttonPedidos.UseVisualStyleBackColor = true;
            // 
            // buttonMenus
            // 
            this.buttonMenus.Location = new System.Drawing.Point(277, 285);
            this.buttonMenus.Name = "buttonMenus";
            this.buttonMenus.Size = new System.Drawing.Size(189, 23);
            this.buttonMenus.TabIndex = 3;
            this.buttonMenus.Text = "Menus";
            this.buttonMenus.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMenus);
            this.Controls.Add(this.buttonPedidos);
            this.Controls.Add(this.buttonClientes);
            this.Controls.Add(this.buttonRestaurantes);
            this.Name = "FormPrincipal";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRestaurantes;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonPedidos;
        private System.Windows.Forms.Button buttonMenus;
    }
}