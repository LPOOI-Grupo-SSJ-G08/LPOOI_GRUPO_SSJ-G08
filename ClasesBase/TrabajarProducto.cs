using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarProducto
    {
        public static DataTable list_productos()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "list_productos_sp";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void insert_producto(Producto oProducto)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert_producto_sp";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@categoria", oProducto.Prod_Categoria);
            cmd.Parameters.AddWithValue("@descripcion", oProducto.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@precio", oProducto.Prod_Precio);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void update_producto(Producto oProducto)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update_producto_sp";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@codigo", oProducto.Prod_Codigo);
            cmd.Parameters.AddWithValue("@categoria", oProducto.Prod_Categoria);
            cmd.Parameters.AddWithValue("@descripcion", oProducto.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@precio", oProducto.Prod_Precio);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void delete_producto(string szCodigo)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete_producto_sp";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@codigo", szCodigo);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
