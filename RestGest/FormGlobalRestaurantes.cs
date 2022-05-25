using System;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormGlobalRestaurantes : Form
    {
        public FormGlobalRestaurantes()
        {
            InitializeComponent();
        }


        private void btAbrirMenu_Click(object sender, EventArgs e)
        {
            new FormRegistarRestaurante().Show();
            this.Hide();
        }

        private void btAlterarRestaurante_Click(object sender, EventArgs e)
        {
            new AlterarRestaurante().Show();
            this.Hide();
        }
    }
}
