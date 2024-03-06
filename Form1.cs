using ejemplito.Controlador;
using ejemplito.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ejemplito
{
    public partial class Form1 : Form
    {
        HabitacionControlador habControlador = new HabitacionControlador();
        public Form1()
        {
            InitializeComponent();
            txtID.Text = habControlador.getUltimoID().ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)

        {
            try {
               
                Habitacion habitacionNueva = new Habitacion();
                habitacionNueva.Nombre = txtNombre.Text;
                habitacionNueva.Descripcion = txtDescripcion.Text;
                habitacionNueva.Id = int.Parse(txtID.Text);
                Trace.WriteLine("Se esta creando una nueva habitacion");

                habControlador.CrearHabitacion(habitacionNueva);

                txtID.Text = habControlador.getUltimoID().ToString();

            } catch(Exception ex) { 
                Trace.WriteLine(ex.ToString());
            }
            
            
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
