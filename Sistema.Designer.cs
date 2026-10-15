namespace RegistroPacientes
{
    partial class SistemaDePacientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLeerPacientes = new System.Windows.Forms.Button();
            this.btnBuscarPacientes = new System.Windows.Forms.Button();
            this.btnBorrarPacientes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido/a.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eliga una opcion.";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(123, 239);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(254, 41);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "1. Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLeerPacientes
            // 
            this.btnLeerPacientes.Location = new System.Drawing.Point(123, 308);
            this.btnLeerPacientes.Name = "btnLeerPacientes";
            this.btnLeerPacientes.Size = new System.Drawing.Size(254, 43);
            this.btnLeerPacientes.TabIndex = 3;
            this.btnLeerPacientes.Text = "2. Leer";
            this.btnLeerPacientes.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPacientes
            // 
            this.btnBuscarPacientes.Location = new System.Drawing.Point(123, 368);
            this.btnBuscarPacientes.Name = "btnBuscarPacientes";
            this.btnBuscarPacientes.Size = new System.Drawing.Size(254, 42);
            this.btnBuscarPacientes.TabIndex = 4;
            this.btnBuscarPacientes.Text = "3. Buscar";
            this.btnBuscarPacientes.UseVisualStyleBackColor = true;
            this.btnBuscarPacientes.Click += new System.EventHandler(this.btnBuscarPacientes_Click);
            // 
            // btnBorrarPacientes
            // 
            this.btnBorrarPacientes.Location = new System.Drawing.Point(123, 428);
            this.btnBorrarPacientes.Name = "btnBorrarPacientes";
            this.btnBorrarPacientes.Size = new System.Drawing.Size(254, 38);
            this.btnBorrarPacientes.TabIndex = 5;
            this.btnBorrarPacientes.Text = "4. Borrar";
            this.btnBorrarPacientes.UseVisualStyleBackColor = true;
            this.btnBorrarPacientes.Click += new System.EventHandler(this.btnBorrarPacientes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(363, 531);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 51);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // SistemaDePacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(478, 594);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrarPacientes);
            this.Controls.Add(this.btnBuscarPacientes);
            this.Controls.Add(this.btnLeerPacientes);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SistemaDePacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Pacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLeerPacientes;
        private System.Windows.Forms.Button btnBuscarPacientes;
        private System.Windows.Forms.Button btnBorrarPacientes;
        private System.Windows.Forms.Button btnSalir;
    }
}