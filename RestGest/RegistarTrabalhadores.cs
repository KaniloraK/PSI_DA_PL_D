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
          

            trabalhadorMorada.Cidade = tbCidade.Text;
            trabalhadorMorada.CodPostal = tbCodPostal.Text;
            trabalhadorMorada.Rua = tbRua.Text;
            trabalhadorMorada.Pais = tbPais.Text;

            container.Moradas.Add(trabalhadorMorada);

            trabalhador.Posicao = tbSalario.Text;
            trabalhador.Nome = tbNome.Text;
            trabalhador.Salario.ToString(tbSalario.Text);
            trabalhador.Morada = trabalhadorMorada;


            container.Pessoas.Add(trabalhador);

            container.SaveChanges();

            MessageBox.Show("Trabalhador Adicionado Com sucesso");
        }
    }
}
