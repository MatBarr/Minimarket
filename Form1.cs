using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minimarket2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidePanel.Height = botonInicio.Height;
            inicioInicio1.BringToFront();

        }

        private void botonInicio_Click(object sender, EventArgs e)
        {
            sidePanel.Height = botonInicio.Height;
            inicioInicio1.BringToFront();

        }

        private void botonProveedores_Click(object sender, EventArgs e)
        {
            sidePanel.Height = botonProveedores.Height;
            inicioProveedor1.BringToFront();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
