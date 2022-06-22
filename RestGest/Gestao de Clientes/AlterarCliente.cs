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
    public partial class AlterarCliente : Form
    {

        RestGestContainer container;
        List<Pessoa> pessoasCliente = null;
        Cliente clienteSelecionado = null;
        Pessoa clientePessoa = null;
        List<Cliente> clientes = null;
      

        public AlterarCliente()
        {
            InitializeComponent();

            container = new RestGestContainer(); 
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            clienteSelecionado.Morada.Cidade = tbCidade.Text;
            clienteSelecionado.Morada.Rua = tbRua.Text;
            clienteSelecionado.Morada.CodPostal = tbCodPostal.Text;
            clienteSelecionado.Morada.Pais = tbPais.Text;
            clienteSelecionado.NumContribuinte = tbNif.Text;
            clienteSelecionado.Telemovel = tbTelemovel.Text;    

            clienteSelecionado.Nome = tbNome.Text;

            container.SaveChanges();

            MessageBox.Show("Cliente alterado com sucesso");
        }

        private void AlterarCliente_Load(object sender, EventArgs e)
        {
            pessoasCliente = container.Pessoas.ToList();

            cbAlterarCliente.DataSource = null;
            cbAlterarCliente.DisplayMember = "Nome";
            cbAlterarCliente.DataSource = pessoasCliente;

        }

        private void cbAlterarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbAlterarCliente.SelectedIndex;
            Cliente cliente = new Cliente();    

            if (cbAlterarCliente.Items.Count != -1)
            {
                clientePessoa = pessoasCliente[selectedIndex];
                tbNome.Text = clientePessoa.Nome;
                tbCodPostal.Text = clientePessoa.Morada.CodPostal;
                tbCidade.Text = clientePessoa.Morada.Cidade;
                tbPais.Text = clientePessoa.Morada.Pais;
                tbRua.Text = clientePessoa.Morada.Rua;
                tbTelemovel.Text = clientePessoa.Telemovel;
            }
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
            if (tbCodPostal.Text.Length < 8 || tbCodPostal.Text.Length > 8)
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

        private void btSairForm_Click(object sender, EventArgs e)
        {
            
            new FormPrincipal().Show();
            this.Close();
        }
    }
}

