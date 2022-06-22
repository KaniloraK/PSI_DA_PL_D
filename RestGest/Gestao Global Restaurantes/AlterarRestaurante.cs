using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RestGest
{
    public partial class AlterarRestaurante : Form
    {
        RestGestContainer container;
        List<Restaurante> restaurantes = null;
        Restaurante restauranteSelecionado = null;



        public AlterarRestaurante()
        {
            InitializeComponent();
            container = new RestGestContainer();

        }

        private void btSairMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormGlobalRestaurantes().Show();
        }


        private void btAlterarRestaurante_Click(object sender, EventArgs e)
        {
           
            restauranteSelecionado.Morada.Cidade = tbCidade.Text;
            restauranteSelecionado.Morada.Rua = tbRua.Text;
            restauranteSelecionado.Morada.CodPostal = tbCodPostal.Text;
            restauranteSelecionado.Morada.Pais = tbPais.Text;

            restauranteSelecionado.Nome = tbNome.Text;

            container.SaveChanges();

            MessageBox.Show("Restaurante alterado com sucesso");
        }

        private void AlterarRestaurante_Load(object sender, EventArgs e)
        {
            restaurantes = container.Restaurantes.ToList();

            cbRestauranteAAlterar.DataSource = null;
            cbRestauranteAAlterar.DisplayMember = "Nome";
            cbRestauranteAAlterar.DataSource = restaurantes;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormPrincipal().Show();
        }

        private void cbRestauranteAAlterar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbRestauranteAAlterar.SelectedIndex;    

            if (cbRestauranteAAlterar.Items.Count != -1)
            {
                restauranteSelecionado = restaurantes[selectedIndex];
                tbNome.Text = restauranteSelecionado.Nome;
                tbCodPostal.Text = restauranteSelecionado.Morada.CodPostal;
                tbCidade.Text = restauranteSelecionado.Morada.Cidade;
                tbPais.Text = restauranteSelecionado.Morada.Pais;
                tbRua.Text = restauranteSelecionado.Morada.Rua;
            }
            
        }

        private void tbNome_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNome.Text))
            {
                e.Cancel = true;
                tbRua.Focus();
                errorProvider1.SetError(tbNome, "Rua não pode ser deixado em branco!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNome, "");
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

        private void tbCidade_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCidade.Text))
            {
                e.Cancel = true;
                tbCidade.Focus();
                errorProvider1.SetError(tbCidade, "Rua não pode ser deixado em branco!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbCidade, "");
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

        private void tbPais_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPais.Text))
            {
                e.Cancel = true;
                tbPais.Focus();
                errorProvider1.SetError(tbPais, "Rua não pode ser deixado em branco!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPais, "");
            }
        }
    }
}
