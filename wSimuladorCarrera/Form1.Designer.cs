
namespace wSimuladorCarrera
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDatosVeh = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.lstParticipantes = new System.Windows.Forms.ListBox();
            this.lblParticipantes = new System.Windows.Forms.Label();
            this.lblDatosCarrera = new System.Windows.Forms.Label();
            this.lblClima = new System.Windows.Forms.Label();
            this.cmbClima = new System.Windows.Forms.ComboBox();
            this.btnIniciarCarrera = new System.Windows.Forms.Button();
            this.btnSigTurno = new System.Windows.Forms.Button();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.panelBarras = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(120, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(49, 120);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(277, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(312, 29);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "SIMULADOR DE CARRERA";
            // 
            // lblDatosVeh
            // 
            this.lblDatosVeh.AutoSize = true;
            this.lblDatosVeh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosVeh.Location = new System.Drawing.Point(49, 81);
            this.lblDatosVeh.Name = "lblDatosVeh";
            this.lblDatosVeh.Size = new System.Drawing.Size(142, 20);
            this.lblDatosVeh.TabIndex = 3;
            this.lblDatosVeh.Text = "Datos del Vehículo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Deportivo",
            "Todoterreno",
            "Hibrido"});
            this.cmbTipo.Location = new System.Drawing.Point(319, 112);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 28);
            this.cmbTipo.TabIndex = 4;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(274, 120);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 20);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo";
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAuto.Location = new System.Drawing.Point(464, 112);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(110, 28);
            this.btnAgregarAuto.TabIndex = 6;
            this.btnAgregarAuto.Text = "Agregar";
            this.btnAgregarAuto.UseVisualStyleBackColor = false;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // lstParticipantes
            // 
            this.lstParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstParticipantes.FormattingEnabled = true;
            this.lstParticipantes.ItemHeight = 20;
            this.lstParticipantes.Location = new System.Drawing.Point(602, 114);
            this.lstParticipantes.Name = "lstParticipantes";
            this.lstParticipantes.Size = new System.Drawing.Size(221, 104);
            this.lstParticipantes.TabIndex = 7;
            // 
            // lblParticipantes
            // 
            this.lblParticipantes.AutoSize = true;
            this.lblParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipantes.Location = new System.Drawing.Point(598, 81);
            this.lblParticipantes.Name = "lblParticipantes";
            this.lblParticipantes.Size = new System.Drawing.Size(147, 20);
            this.lblParticipantes.TabIndex = 8;
            this.lblParticipantes.Text = "Autos Participantes";
            // 
            // lblDatosCarrera
            // 
            this.lblDatosCarrera.AutoSize = true;
            this.lblDatosCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCarrera.Location = new System.Drawing.Point(50, 191);
            this.lblDatosCarrera.Name = "lblDatosCarrera";
            this.lblDatosCarrera.Size = new System.Drawing.Size(147, 20);
            this.lblDatosCarrera.TabIndex = 9;
            this.lblDatosCarrera.Text = "Datos de la Carrera";
            // 
            // lblClima
            // 
            this.lblClima.AutoSize = true;
            this.lblClima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClima.Location = new System.Drawing.Point(48, 237);
            this.lblClima.Name = "lblClima";
            this.lblClima.Size = new System.Drawing.Size(48, 20);
            this.lblClima.TabIndex = 11;
            this.lblClima.Text = "Clima";
            // 
            // cmbClima
            // 
            this.cmbClima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClima.FormattingEnabled = true;
            this.cmbClima.Items.AddRange(new object[] {
            "Soleado",
            "Lluvioso",
            "Ventoso"});
            this.cmbClima.Location = new System.Drawing.Point(121, 229);
            this.cmbClima.Name = "cmbClima";
            this.cmbClima.Size = new System.Drawing.Size(121, 28);
            this.cmbClima.TabIndex = 10;
            // 
            // btnIniciarCarrera
            // 
            this.btnIniciarCarrera.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIniciarCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarCarrera.Location = new System.Drawing.Point(255, 228);
            this.btnIniciarCarrera.Name = "btnIniciarCarrera";
            this.btnIniciarCarrera.Size = new System.Drawing.Size(141, 28);
            this.btnIniciarCarrera.TabIndex = 12;
            this.btnIniciarCarrera.Text = "Iniciar Carrera";
            this.btnIniciarCarrera.UseVisualStyleBackColor = false;
            this.btnIniciarCarrera.Click += new System.EventHandler(this.btnIniciarCarrera_Click);
            // 
            // btnSigTurno
            // 
            this.btnSigTurno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSigTurno.Enabled = false;
            this.btnSigTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigTurno.Location = new System.Drawing.Point(405, 228);
            this.btnSigTurno.Name = "btnSigTurno";
            this.btnSigTurno.Size = new System.Drawing.Size(141, 28);
            this.btnSigTurno.TabIndex = 13;
            this.btnSigTurno.Text = "Siguiente Turno";
            this.btnSigTurno.UseVisualStyleBackColor = false;
            this.btnSigTurno.Click += new System.EventHandler(this.btnSigTurno_Click);
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajes.Location = new System.Drawing.Point(374, 295);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(94, 20);
            this.lblMensajes.TabIndex = 14;
            this.lblMensajes.Text = "Resultados:";
            this.lblMensajes.Visible = false;
            // 
            // panelBarras
            // 
            this.panelBarras.Location = new System.Drawing.Point(54, 295);
            this.panelBarras.Name = "panelBarras";
            this.panelBarras.Size = new System.Drawing.Size(272, 177);
            this.panelBarras.TabIndex = 15;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(556, 229);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(141, 28);
            this.btnReiniciar.TabIndex = 16;
            this.btnReiniciar.Text = "Reiniciar Carrera";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 500);
            this.Controls.Add(this.lblMensajes);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.panelBarras);
            this.Controls.Add(this.btnSigTurno);
            this.Controls.Add(this.btnIniciarCarrera);
            this.Controls.Add(this.lblClima);
            this.Controls.Add(this.cmbClima);
            this.Controls.Add(this.lblDatosCarrera);
            this.Controls.Add(this.lblParticipantes);
            this.Controls.Add(this.lstParticipantes);
            this.Controls.Add(this.btnAgregarAuto);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblDatosVeh);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDatosVeh;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.ListBox lstParticipantes;
        private System.Windows.Forms.Label lblParticipantes;
        private System.Windows.Forms.Label lblDatosCarrera;
        private System.Windows.Forms.Label lblClima;
        private System.Windows.Forms.ComboBox cmbClima;
        private System.Windows.Forms.Button btnIniciarCarrera;
        private System.Windows.Forms.Button btnSigTurno;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.FlowLayoutPanel panelBarras;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

