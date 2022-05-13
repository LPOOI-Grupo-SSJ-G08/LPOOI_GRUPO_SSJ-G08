using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
    {




        public static int search_usuario(string szUsername, string szPassword)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " ISNULL(Rol_Codigo, 0) ";
            cmd.CommandText += " FROM Usuario ";
            cmd.CommandText += " WHERE ";
            cmd.CommandText += " Usu_NombreUsuario=@user AND Usu_Contrasenia=@pass";
            cmd.CommandType = CommandType.Text;

            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@user", szUsername);
            cmd.Parameters.AddWithValue("@pass", szPassword);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            cn.Open();
            int iRol = Convert.ToInt32(cmd.ExecuteScalar());
            cn.Close();

            return iRol;
        }
        public static void agregarUsuario(Usuario usuario)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(usu_NombreUsuario,usu_Contrasenia,usu_ApellidoNombre,rol_Codigo) values(@nombreUsuario,@contrasenia,@apellidoNombre,@rolCodigo)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@nombreUsuario", usuario.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@contrasenia", usuario.Usu_Contrasenia);
            cmd.Parameters.AddWithValue("@apellidoNombre", usuario.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rolCodigo", usuario.Rol_Codigo);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        
        public static DataTable list_usuarios()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString );
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " rol_Codigo as 'Rol', ";
            cmd.CommandText += " usu_NombreUsuario as 'Usuario' , ";
            cmd.CommandText += " usu_Contrasenia as 'Contraseña'";
            cmd.CommandText += " usu_ApellidoNombre as 'Nombre'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cdm);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }
        
    }
}
