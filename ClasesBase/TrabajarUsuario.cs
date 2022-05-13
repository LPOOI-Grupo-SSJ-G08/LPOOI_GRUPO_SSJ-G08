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
    }
}
