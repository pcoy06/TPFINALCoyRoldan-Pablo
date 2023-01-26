using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TPFINALCoyRoldan_Pablo
{
    internal class EmpleadoConexion
    {

        public List<Empleado> listarEmpleados()
        {

            List<Empleado> lista = new List<Empleado>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            conexion.ConnectionString = "data source=localhost; initial catalog=EMPLEADOS_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select Id, NombreCompleto, DNI, Edad, Casado, Salario  from Empleados";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Empleado aux = new Empleado();
                aux.Id = lector.GetInt32(0);
                aux.NombreCompleto = lector.GetString(1);
                aux.DNI = lector.GetString(2);
                aux.Edad = lector.GetInt32(3);
                aux.Casado = lector.GetBoolean(4);
                aux.Salario = lector.GetDecimal(5);

                lista.Add(aux);
            }
            conexion.Close();

            return lista;

        }

        internal void agregar(Empleado nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            conexion.ConnectionString = "data source=localhost; initial catalog=EMPLEADOS_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "insert into Empleados values (@nombre, @dni, @edad, @casado, @salario)";
            comando.Parameters.AddWithValue("@nombre", nuevo.NombreCompleto);
            comando.Parameters.AddWithValue("@dni", nuevo.DNI);
            comando.Parameters.AddWithValue("@edad", nuevo.Edad);
            comando.Parameters.AddWithValue("@casado", nuevo.Casado);
            comando.Parameters.AddWithValue("@salario", nuevo.Salario);

            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();

        }



        internal void modificar(Empleado empleado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=localhost; initial catalog=EMPLEADOS_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "update Empleados set ";
            comando.CommandText += "NombreCompleto = @nombre, ";
            comando.CommandText += "Dni = @dni, ";
            comando.CommandText += "Edad = @edad, ";
            comando.CommandText += "Casado = @casado, ";
            comando.CommandText += "Salario = @salario ";
            comando.CommandText += "Where Id = @id"; 
            comando.Parameters.AddWithValue("@nombre", empleado.NombreCompleto);
            comando.Parameters.AddWithValue("@dni", empleado.DNI);
            comando.Parameters.AddWithValue("@edad", empleado.Edad);
            comando.Parameters.AddWithValue("@casado", empleado.Casado);
            comando.Parameters.AddWithValue("@salario", empleado.Salario);
            comando.Parameters.AddWithValue("@id", empleado.Id);

           

            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();


        }

        internal void eliminar(Empleado empleeli)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=localhost; initial catalog=EMPLEADOS_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "delete from Empleados where ";
            comando.CommandText += "NombreCompleto = @nombre, ";
            comando.CommandText += "Dni = @dni, ";
            comando.CommandText += "Edad = @edad, ";
            comando.CommandText += "Casado = @casado, ";
            comando.CommandText += "Salario = @salario ";
            comando.CommandText += "Where Id = @id";
            comando.Parameters.AddWithValue("@nombre", empleeli.NombreCompleto);
            comando.Parameters.AddWithValue("@dni", empleeli.DNI);
            comando.Parameters.AddWithValue("@edad", empleeli.Edad);
            comando.Parameters.AddWithValue("@casado", empleeli.Casado);
            comando.Parameters.AddWithValue("@salario", empleeli.Salario);
            comando.Parameters.AddWithValue("@id", empleeli.Id);

            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();

        }


    }
}


