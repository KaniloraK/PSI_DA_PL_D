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
            MessageBox.Show("Restaurante registado com sucesso");

            Morada morada = new Morada();
            Restaurante restaurante = new Restaurante();
            Morada moradaRestaurante = new Morada();
        
            container.Restaurantes.Add(restaurante);
            container.SaveChanges();


            MessageBox.Show("Restaurante registado com sucesso");

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormGlobalRestaurantes().Show();
        }
    }
}
