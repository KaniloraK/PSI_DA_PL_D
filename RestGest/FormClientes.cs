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

            clienteMorada.Cidade = tbTelemovel.Text;
            clienteMorada.CodPostal = tbCodPostal.Text;
            clienteMorada.Rua = tbRua.Text;
            clienteMorada.Pais = tbCidade.Text;

            container.Moradas.Add(clienteMorada);

            cliente.Telemovel = tbTelemovel.Text;
            cliente.Nome = tbNome.Text;
            cliente.nif = tbNif.Text;
            cliente.Morada = clienteMorada;
           
            container.Pessoas.Add(cliente);
           
            container.SaveChanges();
            lbClientesCriados.DataSource = null;
            lbClientesCriados.Items.Add(container);
            
            MessageBox.Show("Cliente Adicionado Com sucesso");
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormPrincipal().Show();
        }
    }
}
