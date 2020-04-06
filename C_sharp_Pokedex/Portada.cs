using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_Pokedex
{
    public partial class Portada : Form
    {
        public Portada()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            this.Hide();

            VentanaPrincipal ventana = new VentanaPrincipal();
            ventana.Show();
        }
    }
}
