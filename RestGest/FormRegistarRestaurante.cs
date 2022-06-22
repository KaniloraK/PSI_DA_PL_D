using System;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormRegistarRestaurante : Form
    {
        RestGestContainer container;  
       
        public FormRegistarRestaurante()
        {
            InitializeComponent();
            container = new RestGestContainer();
          
        }

        private void btRegistar_Click(object sender, EventArgs e)
        {
            //Registar Restaurante e uma morada na base de dados 
            Morada restauranteMorada = new Morada();
            Restaurante restaurante = new Restaurante();

            restauranteMorada.Cidade = tbCidade.Text;
            restauranteMorada.Rua = tbRua.Text;
            restauranteMorada.CodPostal = tbCodPostal.Text;
            restauranteMorada.Pais = tbPais.Text;
            
            container.Moradas.Add(restauranteMorada);
            restaurante.Nome = tbNome.Text;
            restaurante.Morada = restauranteMorada;
            container.Restaurantes.Add(restaurante);

             container.SaveChanges();

            MessageBox.Show("Restaurante registado com sucesso");
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormGlobalRestaurantes().Show();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbCidade.Clear();
            tbCodPostal.Clear();
            tbRua.Clear();
            tbNome.Clear();
            tbPais.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormPrincipal().Show();
        }

        private void tbNome_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void tbCodPostal_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void tbCidade_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCidade.Text))
            {
                e.Cancel = true;
                tbCidade.Focus();
                errorProvider1.SetError(tbNome, "Cidade não pode ser deixado em branco!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbCodPostal, "");
            }
        }

        private void tbPais_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPais.Text))
            {
                e.Cancel = true;
                tbPais.Focus();
                errorProvider1.SetError(tbNome, "País não pode ser deixado em branco!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPais, "");
            }
        }

        private void tbRua_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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
