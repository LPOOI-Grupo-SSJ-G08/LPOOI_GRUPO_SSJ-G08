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

        public static void delete_producto(int iCodigo)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete_producto_sp";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@codigo", iCodigo);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static DataSet list_productos_vendidos_rango_fechas(DateTime fechaInicial, DateTime fechaFinal) {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("selectProductosVendidosRangoFechas", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter("@FechaInicial", SqlDbType.Date);
            param.Direction = ParameterDirection.Input;
            param.Value = fechaInicial;
            da.SelectCommand.Parameters.Add(param);

            param = new SqlParameter("@FechaFinal", SqlDbType.Date);
            param.Direction = ParameterDirection.Input;
            param.Value = fechaFinal;
            da.SelectCommand.Parameters.Add(param);

            DataSet ds = new DataSet();
            da.Fill(ds, "view_productos_vendidos_rango_fechas");

            return ds;
        }
    }
}
