﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGest

{
    public partial class FormApagarCliente : Form
    {
        RestGestContainer container;
        public FormApagarCliente()
        {
            InitializeComponent();
            container = new RestGestContainer();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            new FormClientes().Show();
            this.Close();
        }

        private void btApagarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult questao = MessageBox.Show("Pretende mesmo apagar?", "Apagar Cliente", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                string nomeClinete;

                if (questao == DialogResult.Yes)
                {
                    Cliente cliente = comboBoxListaClientes.SelectedItem as Cliente;
                    if (cliente == null)
                    {
                        MessageBox.Show("Não existem clientes registados");
                        return;
                    }
                    nomeClinete = cliente.Nome;

                    container.SaveChanges();


                    MessageBox.Show("Cliente apagado");

                    Update();
                }
                }
          
            catch (DbEntityValidationException er)
            {
                MessageBox.Show(er.Message);
            }
        }



        
        private void comboBoxListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxListaClientes.SelectedIndex;
            if (selectedIndex == -1)
            {

            }
                            

        }
    }
    
}
