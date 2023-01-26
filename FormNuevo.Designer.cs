namespace TPFINALCoyRoldan_Pablo
{
    partial class FormNuevo
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.cmbCasado = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblCasado = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(140, 101);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(144, 20);
            this.txtDni.TabIndex = 1;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(140, 149);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(144, 20);
            this.txtEdad.TabIndex = 2;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(140, 242);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(144, 20);
            this.txtSalario.TabIndex = 3;
            // 
            // cmbCasado
            // 
            this.cmbCasado.FormattingEnabled = true;
            this.cmbCasado.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbCasado.Location = new System.Drawing.Point(140, 195);
            this.cmbCasado.Name = "cmbCasado";
            this.cmbCasado.Size = new System.Drawing.Size(144, 21);
            this.cmbCasado.TabIndex = 4;
            this.cmbCasado.Text = "Seleccione";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(99, 301);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(262, 301);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre Completo: ";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(96, 108);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 8;
            this.lblDni.Text = "DNI:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(94, 156);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(38, 13);
            this.lblEdad.TabIndex = 9;
            this.lblEdad.Text = "Edad: ";
            // 
            // lblCasado
            // 
            this.lblCasado.AutoSize = true;
            this.lblCasado.Location = new System.Drawing.Point(64, 203);
            this.lblCasado.Name = "lblCasado";
            this.lblCasado.Size = new System.Drawing.Size(46, 13);
            this.lblCasado.TabIndex = 10;
            this.lblCasado.Text = "Casado:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(87, 249);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(45, 13);
            this.lblSalario.TabIndex = 11;
            this.lblSalario.Text = "Salario: ";
            // 
            // FormNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 363);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblCasado);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbCasado);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Name = "FormNuevo";
            this.ShowIcon = false;
            this.Text = "Nuevo Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.ComboBox cmbCasado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblCasado;
        private System.Windows.Forms.Label lblSalario;
    }
}