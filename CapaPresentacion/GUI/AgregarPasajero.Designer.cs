namespace CapaPresentacion.GUI
{
    partial class AgregarPasajero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPasajero));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbPais = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbpasaje = new System.Windows.Forms.TextBox();
            this.txbIdDi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ccbbMunicipio = new System.Windows.Forms.ComboBox();
            this.cbbDepartamento = new System.Windows.Forms.ComboBox();
            this.txbnumeroc = new System.Windows.Forms.TextBox();
            this.txbCalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDepartamento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txbcorreo = new System.Windows.Forms.Label();
            this.fechatxt = new System.Windows.Forms.DateTimePicker();
            this.txbnump = new System.Windows.Forms.TextBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomApe = new System.Windows.Forms.TextBox();
            this.txbid = new System.Windows.Forms.Label();
            this.txbIdPasajero = new System.Windows.Forms.TextBox();
            this.txv = new System.Windows.Forms.Label();
            this.txbapellido = new System.Windows.Forms.Label();
            this.txbnombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(344, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 75);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(6, 19);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 38);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(142, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 38);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(270, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 38);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(725, 186);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dirección";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txbPais);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbpasaje);
            this.panel1.Controls.Add(this.txbIdDi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ccbbMunicipio);
            this.panel1.Controls.Add(this.cbbDepartamento);
            this.panel1.Controls.Add(this.txbnumeroc);
            this.panel1.Controls.Add(this.txbCalle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbDepartamento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 161);
            this.panel1.TabIndex = 33;
            // 
            // txbPais
            // 
            this.txbPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPais.Location = new System.Drawing.Point(44, 121);
            this.txbPais.Name = "txbPais";
            this.txbPais.Size = new System.Drawing.Size(273, 20);
            this.txbPais.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Pais:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "ID Dirección:";
            // 
            // txbpasaje
            // 
            this.txbpasaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbpasaje.Location = new System.Drawing.Point(399, 92);
            this.txbpasaje.Name = "txbpasaje";
            this.txbpasaje.Size = new System.Drawing.Size(201, 20);
            this.txbpasaje.TabIndex = 32;
            // 
            // txbIdDi
            // 
            this.txbIdDi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIdDi.Location = new System.Drawing.Point(99, 60);
            this.txbIdDi.Name = "txbIdDi";
            this.txbIdDi.ReadOnly = true;
            this.txbIdDi.Size = new System.Drawing.Size(100, 20);
            this.txbIdDi.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "PasajePoligono:";
            // 
            // ccbbMunicipio
            // 
            this.ccbbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbbMunicipio.FormattingEnabled = true;
            this.ccbbMunicipio.Location = new System.Drawing.Point(399, 15);
            this.ccbbMunicipio.Name = "ccbbMunicipio";
            this.ccbbMunicipio.Size = new System.Drawing.Size(273, 21);
            this.ccbbMunicipio.TabIndex = 28;
            // 
            // cbbDepartamento
            // 
            this.cbbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDepartamento.FormattingEnabled = true;
            this.cbbDepartamento.Location = new System.Drawing.Point(99, 15);
            this.cbbDepartamento.Name = "cbbDepartamento";
            this.cbbDepartamento.Size = new System.Drawing.Size(187, 21);
            this.cbbDepartamento.TabIndex = 27;
            this.cbbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbbDepartamento_SelectedIndexChanged);
            // 
            // txbnumeroc
            // 
            this.txbnumeroc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbnumeroc.Location = new System.Drawing.Point(99, 91);
            this.txbnumeroc.MaxLength = 8;
            this.txbnumeroc.Name = "txbnumeroc";
            this.txbnumeroc.Size = new System.Drawing.Size(90, 20);
            this.txbnumeroc.TabIndex = 12;
            // 
            // txbCalle
            // 
            this.txbCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCalle.Location = new System.Drawing.Point(399, 55);
            this.txbCalle.Name = "txbCalle";
            this.txbCalle.Size = new System.Drawing.Size(273, 20);
            this.txbCalle.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Municipio:";
            // 
            // txbDepartamento
            // 
            this.txbDepartamento.AutoSize = true;
            this.txbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDepartamento.Location = new System.Drawing.Point(3, 18);
            this.txbDepartamento.Name = "txbDepartamento";
            this.txbDepartamento.Size = new System.Drawing.Size(90, 13);
            this.txbDepartamento.TabIndex = 5;
            this.txbDepartamento.Text = "Departamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NumeroCasa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Calle:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Controls.Add(this.panelCliente);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(12, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 207);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pasajero";
            // 
            // panelCliente
            // 
            this.panelCliente.BackColor = System.Drawing.Color.White;
            this.panelCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCliente.Controls.Add(this.txtCorreo);
            this.panelCliente.Controls.Add(this.txbcorreo);
            this.panelCliente.Controls.Add(this.fechatxt);
            this.panelCliente.Controls.Add(this.txbnump);
            this.panelCliente.Controls.Add(this.cbbEstado);
            this.panelCliente.Controls.Add(this.label3);
            this.panelCliente.Controls.Add(this.txtNomApe);
            this.panelCliente.Controls.Add(this.txbid);
            this.panelCliente.Controls.Add(this.txbIdPasajero);
            this.panelCliente.Controls.Add(this.txv);
            this.panelCliente.Controls.Add(this.txbapellido);
            this.panelCliente.Controls.Add(this.txbnombre);
            this.panelCliente.Location = new System.Drawing.Point(6, 19);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(704, 177);
            this.panelCliente.TabIndex = 32;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Location = new System.Drawing.Point(377, 62);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(293, 20);
            this.txtCorreo.TabIndex = 43;
            // 
            // txbcorreo
            // 
            this.txbcorreo.AutoSize = true;
            this.txbcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcorreo.Location = new System.Drawing.Point(315, 69);
            this.txbcorreo.Name = "txbcorreo";
            this.txbcorreo.Size = new System.Drawing.Size(48, 13);
            this.txbcorreo.TabIndex = 42;
            this.txbcorreo.Text = "Correo:";
            // 
            // fechatxt
            // 
            this.fechatxt.Location = new System.Drawing.Point(83, 118);
            this.fechatxt.Name = "fechatxt";
            this.fechatxt.Size = new System.Drawing.Size(249, 20);
            this.fechatxt.TabIndex = 41;
            // 
            // txbnump
            // 
            this.txbnump.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbnump.Location = new System.Drawing.Point(83, 62);
            this.txbnump.Name = "txbnump";
            this.txbnump.Size = new System.Drawing.Size(212, 20);
            this.txbnump.TabIndex = 35;
            // 
            // cbbEstado
            // 
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(430, 115);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(151, 21);
            this.cbbEstado.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Estado:";
            // 
            // txtNomApe
            // 
            this.txtNomApe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomApe.Location = new System.Drawing.Point(377, 16);
            this.txtNomApe.Name = "txtNomApe";
            this.txtNomApe.Size = new System.Drawing.Size(318, 20);
            this.txtNomApe.TabIndex = 11;
            // 
            // txbid
            // 
            this.txbid.AutoSize = true;
            this.txbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbid.Location = new System.Drawing.Point(3, 10);
            this.txbid.Name = "txbid";
            this.txbid.Size = new System.Drawing.Size(77, 13);
            this.txbid.TabIndex = 23;
            this.txbid.Text = "ID Pasajero:";
            // 
            // txbIdPasajero
            // 
            this.txbIdPasajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIdPasajero.Location = new System.Drawing.Point(83, 8);
            this.txbIdPasajero.Name = "txbIdPasajero";
            this.txbIdPasajero.ReadOnly = true;
            this.txbIdPasajero.Size = new System.Drawing.Size(100, 20);
            this.txbIdPasajero.TabIndex = 21;
            // 
            // txv
            // 
            this.txv.AutoSize = true;
            this.txv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txv.Location = new System.Drawing.Point(3, 56);
            this.txv.Name = "txv";
            this.txv.Size = new System.Drawing.Size(68, 26);
            this.txv.TabIndex = 3;
            this.txv.Text = "Numero \r\nPasaporte:";
            // 
            // txbapellido
            // 
            this.txbapellido.AutoSize = true;
            this.txbapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbapellido.Location = new System.Drawing.Point(3, 113);
            this.txbapellido.Name = "txbapellido";
            this.txbapellido.Size = new System.Drawing.Size(74, 26);
            this.txbapellido.TabIndex = 2;
            this.txbapellido.Text = "Fecha de\r\nNacimiento:";
            // 
            // txbnombre
            // 
            this.txbnombre.AutoSize = true;
            this.txbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnombre.Location = new System.Drawing.Point(311, 10);
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(66, 26);
            this.txbnombre.TabIndex = 1;
            this.txbnombre.Text = "Nombres \r\ny Apellido:";
            // 
            // AgregarPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(747, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarPasajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txbPais;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txbpasaje;
        public System.Windows.Forms.TextBox txbIdDi;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox ccbbMunicipio;
        public System.Windows.Forms.ComboBox cbbDepartamento;
        public System.Windows.Forms.TextBox txbnumeroc;
        public System.Windows.Forms.TextBox txbCalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txbDepartamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelCliente;
        public System.Windows.Forms.TextBox txbnump;
        public System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNomApe;
        private System.Windows.Forms.Label txbid;
        public System.Windows.Forms.TextBox txbIdPasajero;
        private System.Windows.Forms.Label txv;
        private System.Windows.Forms.Label txbapellido;
        private System.Windows.Forms.Label txbnombre;
        public System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label txbcorreo;
        public System.Windows.Forms.DateTimePicker fechatxt;
    }
}