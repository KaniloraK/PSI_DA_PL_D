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
    }
}
