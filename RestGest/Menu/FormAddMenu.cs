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
    public partial class FormAddMenu : Form
    {
        public FormAddMenu()
        {
            InitializeComponent();
        }

        private void butImagemPrato_Click(object sender, EventArgs e)
        {

        }

        private void goHome_Click(object sender, EventArgs e)
        {
                new FormPrincipal().Show();
                this.Close();
            }
        }
    }

