namespace CapaInterfaz
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
            this.BtnBD = new System.Windows.Forms.Button();
            this.labelLog = new System.Windows.Forms.Label();
            this.txtboxUsuario = new System.Windows.Forms.TextBox();
            this.txtboxContra = new System.Windows.Forms.TextBox();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.LabelContraseña = new System.Windows.Forms.Label();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBD
            // 
            this.BtnBD.Location = new System.Drawing.Point(695, 372);
            this.BtnBD.Name = "BtnBD";
            this.BtnBD.Size = new System.Drawing.Size(75, 23);
            this.BtnBD.TabIndex = 0;
            this.BtnBD.Text = "PruebaBD";
            this.BtnBD.UseVisualStyleBackColor = true;
            this.BtnBD.Click += new System.EventHandler(this.BtnBD_Click);
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelLog.Location = new System.Drawing.Point(341, 168);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(110, 18);
            this.labelLog.TabIndex = 1;
            this.labelLog.Text = "Inicio de sesion";
            // 
            // txtboxUsuario
            // 
            this.txtboxUsuario.Location = new System.Drawing.Point(344, 207);
            this.txtboxUsuario.Name = "txtboxUsuario";
            this.txtboxUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtboxUsuario.TabIndex = 2;
            // 
            // txtboxContra
            // 
            this.txtboxContra.Location = new System.Drawing.Point(344, 250);
            this.txtboxContra.Name = "txtboxContra";
            this.txtboxContra.PasswordChar = '*';
            this.txtboxContra.Size = new System.Drawing.Size(100, 20);
            this.txtboxContra.TabIndex = 3;
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LabelUsuario.Location = new System.Drawing.Point(279, 210);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(57, 17);
            this.LabelUsuario.TabIndex = 4;
            this.LabelUsuario.Text = "Usuario";
            this.LabelUsuario.Click += new System.EventHandler(this.LabelUsuario_Click);
            // 
            // LabelContraseña
            // 
            this.LabelContraseña.AutoSize = true;
            this.LabelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LabelContraseña.Location = new System.Drawing.Point(257, 253);
            this.LabelContraseña.Name = "LabelContraseña";
            this.LabelContraseña.Size = new System.Drawing.Size(81, 17);
            this.LabelContraseña.TabIndex = 5;
            this.LabelContraseña.Text = "Contraseña";
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(344, 332);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(75, 23);
            this.BtnIniciar.TabIndex = 6;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.LabelContraseña);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.txtboxContra);
            this.Controls.Add(this.txtboxUsuario);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.BtnBD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBD;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.TextBox txtboxUsuario;
        private System.Windows.Forms.TextBox txtboxContra;
        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.Label LabelContraseña;
        private System.Windows.Forms.Button BtnIniciar;
    }
}

