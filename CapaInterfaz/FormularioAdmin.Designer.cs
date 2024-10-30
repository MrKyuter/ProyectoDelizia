namespace CapaInterfaz
{
    partial class FormularioAdmin
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
            this.BtnGestor = new System.Windows.Forms.Button();
            this.BtnLista = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGestor
            // 
            this.BtnGestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnGestor.Location = new System.Drawing.Point(158, 67);
            this.BtnGestor.Name = "BtnGestor";
            this.BtnGestor.Size = new System.Drawing.Size(75, 40);
            this.BtnGestor.TabIndex = 0;
            this.BtnGestor.Text = "Gestor de Usuarios";
            this.BtnGestor.UseVisualStyleBackColor = true;
            // 
            // BtnLista
            // 
            this.BtnLista.Location = new System.Drawing.Point(369, 67);
            this.BtnLista.Name = "BtnLista";
            this.BtnLista.Size = new System.Drawing.Size(75, 40);
            this.BtnLista.TabIndex = 1;
            this.BtnLista.Text = "Lista de Pedidos";
            this.BtnLista.UseVisualStyleBackColor = true;
            // 
            // BtnClientes
            // 
            this.BtnClientes.Location = new System.Drawing.Point(369, 146);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(75, 40);
            this.BtnClientes.TabIndex = 2;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = true;
            // 
            // BtnProductos
            // 
            this.BtnProductos.Location = new System.Drawing.Point(158, 146);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(75, 40);
            this.BtnProductos.TabIndex = 3;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(369, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(158, 220);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // FormularioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnProductos);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.BtnLista);
            this.Controls.Add(this.BtnGestor);
            this.Name = "FormularioAdmin";
            this.Text = "FormularioAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGestor;
        private System.Windows.Forms.Button BtnLista;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}