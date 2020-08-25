using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Tracing;
using System.Net;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;
using System.Data.Common;

namespace minimarket2
{
    public partial class InicioProveedor : UserControl
    {

        public InicioProveedor()
        {
            InitializeComponent();
            detJSON();
            

        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            Proveedor prov = new Proveedor();
            prov.Nombre = nombreTextBox.Text;
            prov.Telefono = telefonoTextBox.Text;
            prov.Correo = correoTextBox.Text;
            prov.Direccion = direccionTextBox.Text;


            addData(prov);

            nombreTextBox.Clear();
            telefonoTextBox.Clear();
            correoTextBox.Clear();
            direccionTextBox.Clear();
        }

        private void addData(Proveedor prov)
        {


            //String[] row = { prov.nombre.ToString(), prov.telfono.ToString(), prov.direccion.ToString(), prov.email.ToString()};

            //dataGridView1.Rows.Add(row);
            //listaProv.Add(prov);


        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {




        }

        private void InicioProveedor_Load(object sender, EventArgs e)
        {


        }

        public void detJSON()
        {
           
            List<Proveedor> provs = new List<Proveedor>();

            using (var webClient = new WebClient())
            {
                string rawjson = webClient.DownloadString("https://mini-market-zonita.herokuapp.com/Proveedores_GETALL.php");

                provs = JsonConvert.DeserializeObject<List<Proveedor>>(rawjson);
                dataGridView1.DataSource = provs;


            }


        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
