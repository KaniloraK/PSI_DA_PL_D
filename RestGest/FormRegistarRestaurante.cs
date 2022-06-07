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
    }
}
