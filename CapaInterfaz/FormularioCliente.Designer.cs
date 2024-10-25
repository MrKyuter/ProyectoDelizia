namespace CapaInterfaz
{
    partial class FormularioCliente
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
            this.txtboxCedula = new System.Windows.Forms.TextBox();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.txtboxApellido = new System.Windows.Forms.TextBox();
            this.txtboxTelefono = new System.Windows.Forms.TextBox();
            this.txtboxDireccion = new System.Windows.Forms.TextBox();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxCedula
            // 
            this.txtboxCedula.Location = new System.Drawing.Point(269, 107);
            this.txtboxCedula.Name = "txtboxCedula";
            this.txtboxCedula.Size = new System.Drawing.Size(100, 20);
            this.txtboxCedula.TabIndex = 0;
            this.txtboxCedula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.Location = new System.Drawing.Point(269, 156);
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtboxNombre.TabIndex = 1;
            // 
            // txtboxApellido
            // 
            this.txtboxApellido.Location = new System.Drawing.Point(269, 210);
            this.txtboxApellido.Name = "txtboxApellido";
            this.txtboxApellido.Size = new System.Drawing.Size(100, 20);
            this.txtboxApellido.TabIndex = 2;
            // 
            // txtboxTelefono
            // 
            this.txtboxTelefono.Location = new System.Drawing.Point(269, 256);
            this.txtboxTelefono.Name = "txtboxTelefono";
            this.txtboxTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtboxTelefono.TabIndex = 3;
            // 
            // txtboxDireccion
            // 
            this.txtboxDireccion.Location = new System.Drawing.Point(269, 294);
            this.txtboxDireccion.Name = "txtboxDireccion";
            this.txtboxDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtboxDireccion.TabIndex = 4;
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelRegistro.Location = new System.Drawing.Point(253, 67);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(135, 20);
            this.labelRegistro.TabIndex = 5;
            this.labelRegistro.Text = "Registrar Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cedula";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Direccion";
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.Location = new System.Drawing.Point(257, 362);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistro.TabIndex = 11;
            this.BtnRegistro.Text = "Registrarse";
            this.BtnRegistro.UseVisualStyleBackColor = true;
            // 
            // FormularioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRegistro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.txtboxDireccion);
            this.Controls.Add(this.txtboxTelefono);
            this.Controls.Add(this.txtboxApellido);
            this.Controls.Add(this.txtboxNombre);
            this.Controls.Add(this.txtboxCedula);
            this.Name = "FormularioCliente";
            this.Text = "FormularioCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxCedula;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.TextBox txtboxApellido;
        private System.Windows.Forms.TextBox txtboxTelefono;
        private System.Windows.Forms.TextBox txtboxDireccion;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnRegistro;
    }
}