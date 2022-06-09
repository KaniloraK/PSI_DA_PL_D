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

            MessageBox.Show("Restaurante registado com sucesso");



            //MessageBox.Show("Restaurante Alterado com sucesso");

        }

        private void AlterarRestaurante_Load(object sender, EventArgs e)
        {
            restaurantes = container.Restaurantes.ToList();

            cbRestauranteAAlterar.DataSource = null;
            cbRestauranteAAlterar.DisplayMember = "Nome";
            cbRestauranteAAlterar.DataSource = restaurantes;

            /*
            tbNome.Text = restaurantes[0].Nome;
            tbCodPostal.Text = moradas[0].CodPostal;
            tbPais.Text = moradas[0].Pais;
            tbCidade.Text = moradas[0].Cidade;
            tbRua.Text = moradas[0].Rua;
           */

           


            //container.SaveChanges();

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

                
                /*
                tbNome.Text = restaurantes.Nome;
                tbCodPostal.Text = moradas.CodPostal;
                tbPais.Text = moradas.Pais;
                tbCidade.Text = moradas.Cidade;
                tbRua.Text = moradas.Rua;
                */
            
        }

    }
}
