using Corte1.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1
{
    public partial class Form1 : Form
    {
        private Registro registro;
        private Operacion operacion;

        public Form1()
        {
            InitializeComponent();
            registro = new Registro();
            operacion = new Operacion();
            cmbCiudad.Items.AddRange(new string[] { "Managua", "Chinandega", "Esteli" });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nombres = tbName.Text;
            string apellidos = tbLastName.Text;
            DateTime fechaNacimiento = dtpFechaNac.Value;

            if (cmbCiudad.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una ciudad.");
                return;
            }

            string ciudad = cmbCiudad.SelectedItem.ToString();
            Persona nuevaPersona = new Persona(nombres, apellidos, fechaNacimiento, ciudad);

            try
            {
                registro.AgregarPersona(nuevaPersona);
                lbPersona.Items.Add($"{nombres} {apellidos}, {ciudad}");
                MessageBox.Show("Persona agregada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            if (registro.ObtenerPersonas().Count > 0)
            {
                Persona persona = registro.ObtenerPersonas()[0];
                int edad = operacion.CalcularEdad(persona.FechaNacimiento);
                string mayorEdad = operacion.VerificarMayorEdad(persona.FechaNacimiento);

                MessageBox.Show($"Edad: {edad} años. {mayorEdad}");
            }
            else
            {
                MessageBox.Show("No hay personas registradas.");
            }
        }
    }
}