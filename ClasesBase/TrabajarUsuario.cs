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


        public static string get_rol(int iRolCodigo)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Rol_Descripcion FROM Roles WHERE Rol_Codigo=@codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@codigo", iRolCodigo);

            cn.Open();
            string szRolDescripcion = cmd.ExecuteScalar().ToString();
            cn.Close();

            return szRolDescripcion;
        }

        public static int validate_login(string szUsername, string szPassword)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " ISNULL(Rol_Codigo, 0) ";
            cmd.CommandText += " FROM Usuario ";
            cmd.CommandText += " WHERE ";
            cmd.CommandText += " Usu_NombreUsuario=@user COLLATE SQL_Latin1_General_CP1_CS_AS AND ";
            cmd.CommandText += " Usu_Contrasenia=@pass COLLATE SQL_Latin1_General_CP1_CS_AS";
            cmd.CommandType = CommandType.Text;

            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@user", szUsername);
            cmd.Parameters.AddWithValue("@pass", szPassword);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            cn.Open();
            int iRolCodigo = Convert.ToInt32(cmd.ExecuteScalar());
            cn.Close();

            return iRolCodigo;
        }
    }
}
