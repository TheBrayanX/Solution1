using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace Interfaz
{
    public partial class comprar : Form
    {
        negocio neg = new negocio();
        public comprar()
        {
            InitializeComponent();
            CargarDataGrid();
        }
        public void CargarDataGrid()
        {
            datos.DataSource = neg.Leer().Tables["productos"];
        }

        public void LimpiarCampos()
        {
            cliente.Text = string.Empty;
            producto.Text = string.Empty;
            direccion.Text = string.Empty;
            cantidad.Text = string.Empty;
            txtid.Text = string.Empty;
            iddir.Text = string.Empty;
            direcc.Text = string.Empty;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            entidades enti = new entidades();
            enti.cl = cliente.Text;
            enti.pr = producto.Text;
            enti.dir = direccion.Text;
            enti.cant = cantidad.Text;
            neg.Crear(enti);
            MessageBox.Show("Producto guardado, en breves un agente de ventas te contactara ");
            LimpiarCampos();
            CargarDataGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            this.Hide();
            inicio.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entidades enti = new entidades();
            enti.id = txtid.Text;
            neg.Eliminar(enti);
            MessageBox.Show("Producto eliminado ");
            LimpiarCampos();
            CargarDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            entidades enti = new entidades();
            enti.id = iddir.Text;
            enti.dir = direcc.Text;
            neg.Actualizar(enti);
            MessageBox.Show("Dirección actualizada ");
            LimpiarCampos();
            CargarDataGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reportes rpt = new Reportes();
            rpt.Show();
        }
    }
}
