using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wSimuladorCarrera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ActualizarListaParticipantes(List<Auto> autosParticipantes)
        {
            lstParticipantes.Items.Clear();

            foreach (var auto in autosParticipantes)
            {
                lstParticipantes.Items.Add(auto.Nombre + " Tipo: " + auto.Tipo);

            }
        }

        private void limpiarCamposVehículo()
        {
            txtNombre.Clear();
            cmbTipo.SelectedIndex = -1;
        }
        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = "";
                string tipo = "";

                //Validaciones
                if (string.IsNullOrEmpty(txtNombre.Text.Trim().ToUpper()))
                    throw new ArgumentException("El nombre del vehículo no puede estar vacío");
                else
                    nombre = txtNombre.Text.Trim().ToUpper();

                if (cmbTipo.SelectedIndex == -1)
                    throw new ArgumentException("El tipo de vehículo no puede estar vacío");
                else
                    tipo = cmbTipo.SelectedItem.ToString();

                //se crea el auto  y se agrega a la lista de participantes
                var auto = AutoFactory.CrearAuto(nombre, tipo);
                Carrera.Instancia.agregarAuto(auto);

                ActualizarListaParticipantes(Carrera.Instancia.ObtenerParcipantes());
                limpiarCamposVehículo();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnIniciarCarrera_Click(object sender, EventArgs e)
        {
            try
            {
                string clima = "";
                if (cmbClima.SelectedIndex == -1)
                    throw new ArgumentException("Debe seleccionar el clima para la carrera.");
                else
                    clima = cmbClima.SelectedItem.ToString().ToLower();

                Carrera.Instancia.establecerClima(clima);
                Carrera.Instancia.iniciarCarrera();
                btnAgregarAuto.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
