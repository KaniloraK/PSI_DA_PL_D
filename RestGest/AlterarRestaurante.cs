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
    public partial class AlterarRestaurante : Form
    {
        RestGestContainer container;
       
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
        }

        private void cbRestauranteAAlterar_DropDown(object sender, EventArgs e)
        { 
            Morada restauranteMorada = new Morada();
            Restaurante restaurante = new Restaurante();

            cbRestauranteAAlterar.Items.Add(container.Restaurantes);
        }
    }
}
