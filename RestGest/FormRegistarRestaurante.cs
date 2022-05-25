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
    public partial class FormRegistarRestaurante : Form
    {
        public FormRegistarRestaurante()
        {
            InitializeComponent();
        }

        private void btRegistar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNome.Text) || string.IsNullOrEmpty(tbMorada.Text))
            {
                return;
            }
        }

    
    }
}
