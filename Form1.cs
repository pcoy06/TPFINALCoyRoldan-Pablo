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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cargar();
            ocultarColumnas();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormNuevo ventanaEmpleado = new FormNuevo();
            ventanaEmpleado.ShowDialog();
            cargar();
        }

        private void cargar()
        {
            EmpleadoConexion conexion = new EmpleadoConexion();
            dgvEmpleados.DataSource = conexion.listarEmpleados();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvEmpleados.SelectedRows.Count>0)
            {
                dgvEmpleados.EditMode = DataGridViewEditMode.EditProgrammatically;
                dgvEmpleados.ReadOnly = false;
                dgvEmpleados.BeginEdit(true);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Está seguro que desea eliminar al Empleado?", "Está seguro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)


                    if (dgvEmpleados.SelectedRows.Count > 0)
                    {
                        dgvEmpleados.SelectedRows[0].Selected.ToString();
                        
                    }


                {
                    MessageBox.Show("Empleado Eliminado Correctamente", "Empleado Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                }/*              
                else
                    {
                        MessageBox.Show("No se pudo Eliminar el Empleado", "Ocurrio un error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }*/

                dgvEmpleados.Refresh();            


                
            }
            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


        }

        private void dgvEmpleados_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            EmpleadoConexion conexion = new EmpleadoConexion();
            Empleado empleadoModificado = new Empleado();
            empleadoModificado.Id = (int)dgvEmpleados.SelectedRows[0].Cells["Id"].Value;
            empleadoModificado.Casado = (bool)dgvEmpleados.SelectedRows[0].Cells["Casado"].Value;
            empleadoModificado.DNI = dgvEmpleados.SelectedRows[0].Cells["DNI"].Value.ToString();
            empleadoModificado.Edad = (int)dgvEmpleados.SelectedRows[0].Cells["Edad"].Value;
            empleadoModificado.NombreCompleto = dgvEmpleados.SelectedRows[0].Cells["NombreCompleto"].Value.ToString();
            empleadoModificado.Salario = (decimal)dgvEmpleados.SelectedRows[0].Cells["Salario"].Value;

            conexion.modificar(empleadoModificado);
        }

        private void dgvEmpleados_DeletedRow(Object sender, EventArgs e)
        {
            EmpleadoConexion conexion = new EmpleadoConexion();
            Empleado empleadoEliminado = new Empleado();                    
            empleadoEliminado.Id = (int)dgvEmpleados.SelectedRows[0].Cells["Id"].Value;
            empleadoEliminado.Casado = (bool)dgvEmpleados.SelectedRows[0].Cells["Casado"].Value;
            empleadoEliminado.DNI = dgvEmpleados.SelectedRows[0].Cells["DNI"].Value.ToString();
            empleadoEliminado.Edad = (int)dgvEmpleados.SelectedRows[0].Cells["Edad"].Value;
            empleadoEliminado.NombreCompleto = dgvEmpleados.SelectedRows[0].Cells["NombreCompleto"].Value.ToString();
            empleadoEliminado.Salario = (decimal)dgvEmpleados.SelectedRows[0].Cells["Salario"].Value;
            


            conexion.eliminar(empleadoEliminado);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ocultarColumnas()
        {
            dgvEmpleados.Columns[0].Visible = false;
        }
    }

}
   
