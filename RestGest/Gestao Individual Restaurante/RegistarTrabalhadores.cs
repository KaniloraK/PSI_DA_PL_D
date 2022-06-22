using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGest
{
    public partial class RegistarTrabalhadores : Form
    {

        RestGestContainer container;
        public RegistarTrabalhadores()
        {
            InitializeComponent();
            container = new RestGestContainer();
        }

        private void btRegistarTrabalhador_Click(object sender, EventArgs e)
        {
            Trabalhador trabalhador = new Trabalhador();
            Morada trabalhadorMorada = new Morada();
            Restaurante trabalhadorRestaurante = new Restaurante();

            
                trabalhadorMorada.Cidade = tbCidade.Text;
                trabalhadorMorada.CodPostal = tbCodPostal.Text;
                trabalhadorMorada.Rua = tbRua.Text;
                trabalhadorMorada.Pais = tbPais.Text;

                container.Moradas.Add(trabalhadorMorada);

                trabalhador.Posicao = tbSalario.Text;
                trabalhador.Nome = tbNome.Text;
                trabalhador.Salario.ToString(tbSalario.Text);
                trabalhador.Telemovel = tbTelemovel.Text;
                trabalhador.Morada = trabalhadorMorada;
                trabalhador.Restaurante = trabalhadorRestaurante;
            trabalhador.RestauranteId = trabalhadorRestaurante.Id;

                container.Pessoas.Add(trabalhador);
            try
            {
                container.SaveChanges();
            }
            catch (DbEntityValidationException error)
            {
                foreach (var eve in error.EntityValidationErrors)
                {
                    Console.WriteLine("Entidade do tipo \"{0}\" no estado \"{1}\" tem os seguintes erros de validação:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Erro: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }



            MessageBox.Show("Trabalhador Adicionado Com sucesso");
        }

       
    }
}
