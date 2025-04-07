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
            lblMensajes.Text = "";
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
                btnSigTurno.Enabled = true;
                btnIniciarCarrera.Enabled = false;

                Label lblClimaSel = new Label();
                lblClimaSel.Text = $"Clima de la Carrera: { Carrera.Instancia.Clima.ToUpper()}";
                lblClimaSel.Width = 250;
                lblClimaSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                panelBarras.Controls.Add(lblClimaSel);

                //crear barras de progreso para los participantes
                List<Auto> participantes = Carrera.Instancia.ObtenerParcipantes();
                foreach (var auto in participantes)
                {
                    //label para el nombre
                    Label lblNomAuto = new Label();
                    lblNomAuto.Text = auto.Nombre;
                    lblNomAuto.Width = 200;

                    //barra de progreso
                    ProgressBar barra = new ProgressBar();
                    barra.Minimum = 0;
                    barra.Maximum = 150;
                    barra.Value = 0;
                    barra.Width = 200;
                    barra.Height = 20;
                    barra.Name = $"barra_{auto.Nombre}";

                    //agregar labels y barras al panel
                   
                    panelBarras.Controls.Add(barra);
                    panelBarras.Controls.Add(lblNomAuto);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnSigTurno_Click(object sender, EventArgs e)
        {
            string mensaje = Carrera.Instancia.siguienteTurno();
            List<Auto> participantes = Carrera.Instancia.ObtenerParcipantes();
            foreach (var auto in participantes)
            {
                var barra = panelBarras.Controls.OfType<ProgressBar>().FirstOrDefault(pb => pb.Name == $"barra_{auto.Nombre}");

                if (barra != null)
                    barra.Value = Math.Min(150, auto.DistanciaRecorrida);

                if (auto.DistanciaRecorrida >= 150)
                    btnSigTurno.Enabled = false;
                
            }
            lblMensajes.Visible = true;
            lblMensajes.Text = "Resultados: \n" + mensaje;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            btnAgregarAuto.Enabled = true;
            btnIniciarCarrera.Enabled = true;
            btnSigTurno.Enabled = false;
            cmbClima.SelectedIndex = -1;
            
            lblMensajes.Text = "Carrera reiniciada. Ingrese nuevos autos.";
            lstParticipantes.Items.Clear();
            panelBarras.Controls.Clear();
            Carrera.Instancia.reiniciarCarrera();
            
        }
    }
}
