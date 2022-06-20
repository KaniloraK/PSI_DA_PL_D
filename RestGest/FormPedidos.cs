using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormPedidos : Form
    {
        public FormPedidos()
        {
            InitializeComponent();
        }

        private void butNovoPedido_Click(object sender, EventArgs e)
        {
            new FormAddNovoPedido().Show();
            this.Close(); // fechar a janela porque no formulário temos btn para sair
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restGestDBDataSet.Pedidos' table. You can move, or remove it, as needed.
            this.pedidosTableAdapter.Fill(this.restGestDBDataSet.Pedidos);
           
        }

        private void goHome_Click(object sender, EventArgs e)
        {
            new FormPrincipal().Show();
            this.Close();
        }

        private void butExportarPDF_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            DialogResult result = printDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                printDocument1.Print();
            }

           
        }
     
        private void listViewGestaoPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butExportarTXT_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Salvar Ficheiro";
            save.Filter = "Ficheiros de Texto (*.txt)|*.txt| Todos os ficheiros (*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                
                write.WriteLine(save.FileName);

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("RestGest | DADOS DO PEDIDO:", new Font("Arial", 20, FontStyle.Bold), Brushes.DarkBlue, new Point(7, 7));

        }
    }

    
}
