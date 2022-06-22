using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormClientes : Form
    {

        RestGestContainer container;

        public FormClientes()
        {
            InitializeComponent();
            container = new RestGestContainer();    
        }

        private void btAdicionarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Morada clienteMorada = new Morada();
            Pessoa clientePessoa = new Pessoa();

            clienteMorada.Cidade = tbCidade.Text;
            clienteMorada.CodPostal = tbCodPostal.Text;
            clienteMorada.Rua = tbRua.Text;
            clienteMorada.Pais = tbPais.Text;

            container.Moradas.Add(clienteMorada);

            cliente.Telemovel = tbTelemovel.Text;
            cliente.Nome = tbNome.Text;    
            cliente.NumContribuinte = tbNif.Text;
            cliente.Morada = clienteMorada;
            

            container.Pessoas.Add(cliente);
           
            container.SaveChanges();
            
            MessageBox.Show("Cliente Adicionado Com sucesso");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormPrincipal().Show();
        }

        private void btAlterarForm_Click(object sender, EventArgs e)
        {
            new AlterarCliente().Show();
            this.Close();
        }

        private void tbNome_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNome.Text))
            {
                e.Cancel = true;
                tbNome.Focus();
                errorProvider1.SetError(tbNome, "Nome não pode ser deixado em branco!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNome, "");
            }
        }

        private void tbNif_Validating(object sender, CancelEventArgs e)
        {
            if (tbNif.Text.Length < 10 || tbNif.Text.Length > 10)
            {
                e.Cancel = true;
                tbNif.Focus();
                errorProvider1.SetError(tbNif, "Nif inválido!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNif, "");
            }
        }

        private void tbTelemovel_Validating(object sender, CancelEventArgs e)
        {
            if (tbTelemovel.Text.Length < 9 || tbTelemovel.Text.Length > 9)
            {
                e.Cancel = true;
                tbTelemovel.Focus();
                errorProvider1.SetError(tbTelemovel, "Número de telemóvel inválido!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbTelemovel, "");
            }
        }

        private void tbCidade_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCidade.Text))
            {
                e.Cancel = true;
                tbCidade.Focus();
                errorProvider1.SetError(tbCidade, "Cidade não pode ser deixado em branco!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbCidade, "");
            }
        }

        private void tbPais_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPais.Text))
            {
                e.Cancel = true;
                tbPais.Focus();
                errorProvider1.SetError(tbPais, "País não pode ser deixado em branco!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPais, "");
            }
        }

        private void tbCodPostal_Validating(object sender, CancelEventArgs e)
        {
            if (tbCodPostal.Text.Length < 9 || tbCodPostal.Text.Length > 9)
            {
                e.Cancel = true;
                tbCodPostal.Focus();
                errorProvider1.SetError(tbCodPostal, "Código Postal inválido!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbCodPostal, "");
            }
        }

        private void tbRua_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbRua.Text))
            {
                e.Cancel = true;
                tbRua.Focus();
                errorProvider1.SetError(tbRua, "Rua não pode ser deixado em branco!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbRua, "");
            }
        }
    }
}
