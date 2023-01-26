using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFINALCoyRoldan_Pablo
{
    public partial class FormNuevo : Form
    {
        public FormNuevo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Empleado nuevo = new Empleado();
            EmpleadoConexion conexion = new EmpleadoConexion();

            nuevo.NombreCompleto = txtNombre.Text;
            nuevo.DNI = txtDni.Text;
            nuevo.Edad = int.Parse(txtEdad.Text);
            nuevo.Casado = Convert.ToBoolean(cmbCasado.SelectedValue);
            nuevo.Salario = decimal.Parse(txtSalario.Text);

            conexion.agregar(nuevo);
            MessageBox.Show("Se agrego Correctamente");
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            //Application.Exit();
        }
    }
}
