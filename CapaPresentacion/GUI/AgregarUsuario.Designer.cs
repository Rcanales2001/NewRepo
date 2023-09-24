namespace CapaPresentacion.GUI
{
    partial class AgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUsuario));
            this.panelCliente = new System.Windows.Forms.Panel();
            this.ccbEstado = new System.Windows.Forms.ComboBox();
            this.ccbRoles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbClave = new System.Windows.Forms.TextBox();
            this.txbid = new System.Windows.Forms.Label();
            this.txbIDS = new System.Windows.Forms.TextBox();
            this.txbdui = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCliente
            // 
            this.panelCliente.BackColor = System.Drawing.Color.White;
            this.panelCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCliente.Controls.Add(this.ccbEstado);
            this.panelCliente.Controls.Add(this.ccbRoles);
            this.panelCliente.Controls.Add(this.label3);
            this.panelCliente.Controls.Add(this.label2);
            this.panelCliente.Controls.Add(this.txbUser);
            this.panelCliente.Controls.Add(this.label1);
            this.panelCliente.Controls.Add(this.txbClave);
            this.panelCliente.Controls.Add(this.txbid);
            this.panelCliente.Controls.Add(this.txbIDS);
            this.panelCliente.Controls.Add(this.txbdui);
            this.panelCliente.Location = new System.Drawing.Point(12, 12);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(713, 177);
            this.panelCliente.TabIndex = 38;
            // 
            // ccbEstado
            // 
            this.ccbEstado.FormattingEnabled = true;
            this.ccbEstado.Location = new System.Drawing.Point(421, 79);
            this.ccbEstado.Name = "ccbEstado";
            this.ccbEstado.Size = new System.Drawing.Size(140, 21);
            this.ccbEstado.TabIndex = 43;
            this.ccbEstado.SelectedIndexChanged += new System.EventHandler(this.ccbEstado_SelectedIndexChanged);
            // 
            // ccbRoles
            // 
            this.ccbRoles.FormattingEnabled = true;
            this.ccbRoles.Location = new System.Drawing.Point(421, 8);
            this.ccbRoles.Name = "ccbRoles";
            this.ccbRoles.Size = new System.Drawing.Size(140, 21);
            this.ccbRoles.TabIndex = 42;
            this.ccbRoles.SelectedIndexChanged += new System.EventHandler(this.txR_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "ID Roles:";
            // 
            // txbUser
            // 
            this.txbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUser.Location = new System.Drawing.Point(84, 49);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(212, 20);
            this.txbUser.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Contraseña:";
            // 
            // txbClave
            // 
            this.txbClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbClave.Location = new System.Drawing.Point(84, 104);
            this.txbClave.Name = "txbClave";
            this.txbClave.PasswordChar = '*';
            this.txbClave.Size = new System.Drawing.Size(212, 20);
            this.txbClave.TabIndex = 35;
            // 
            // txbid
            // 
            this.txbid.AutoSize = true;
            this.txbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbid.Location = new System.Drawing.Point(3, 10);
            this.txbid.Name = "txbid";
            this.txbid.Size = new System.Drawing.Size(77, 13);
            this.txbid.TabIndex = 23;
            this.txbid.Text = "ID Usuarios:";
            // 
            // txbIDS
            // 
            this.txbIDS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIDS.Location = new System.Drawing.Point(86, 8);
            this.txbIDS.Name = "txbIDS";
            this.txbIDS.ReadOnly = true;
            this.txbIDS.Size = new System.Drawing.Size(100, 20);
            this.txbIDS.TabIndex = 21;
            // 
            // txbdui
            // 
            this.txbdui.AutoSize = true;
            this.txbdui.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbdui.Location = new System.Drawing.Point(3, 56);
            this.txbdui.Name = "txbdui";
            this.txbdui.Size = new System.Drawing.Size(54, 13);
            this.txbdui.TabIndex = 3;
            this.txbdui.Text = "Usuario:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(332, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 75);
            this.groupBox1.TabIndex = 37;
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
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(730, 274);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txbClave;
        private System.Windows.Forms.Label txbid;
        public System.Windows.Forms.TextBox txbIDS;
        private System.Windows.Forms.Label txbdui;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.ComboBox ccbEstado;
        public System.Windows.Forms.ComboBox ccbRoles;
    }
}