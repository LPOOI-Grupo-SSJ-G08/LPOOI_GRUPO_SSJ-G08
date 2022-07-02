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
            //da.Fill(ds, "view_productos_vendidos_rango_fechas");
            da.Fill(ds, "view_productos_venta_cliente");

            return ds;
        }

        public static DataSet list_productos_vendidos_por_cliente(string dni) {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("selectProductosVendidosPorCliente", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter("@ClienteDNI", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = dni;
            da.SelectCommand.Parameters.Add(param);

            DataSet ds = new DataSet();
            da.Fill(ds, "view_productos_venta_cliente");

            return ds;
        }

        public static DataSet list_todos_productos_vendidos() {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("selectTodosProductosVendidos", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            da.Fill(ds, "view_productos_venta_cliente");

            return ds;
        }

        public static DataSet list_productos_por(char categoriaOrdenacion)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("selectProductosPorDescOCateg",cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            param = new SqlParameter("categoria", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = categoriaOrdenacion;
            da.SelectCommand.Parameters.Add(param);

            DataSet ds = new DataSet();
            da.Fill(ds,"Producto");

            return ds;
        }

        public static int getCantidadProductosByFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "get_count_prod_x_fechas_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
            cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
            cmd.Parameters.Add("@cantidad_productos", SqlDbType.Int);
            cmd.Parameters["@cantidad_productos"].Direction = ParameterDirection.Output;

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            int iCantidadVentas = (int)cmd.Parameters["@cantidad_productos"].Value;

            return iCantidadVentas;
        }

        public static int getCantidadProductosByCliente(string szDNI)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "get_count_prod_x_cliente_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@DNI", szDNI);
            cmd.Parameters.Add("@cantidad_productos", SqlDbType.Int);
            cmd.Parameters["@cantidad_productos"].Direction = ParameterDirection.Output;

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            int iCantidadVentas = (int)cmd.Parameters["@cantidad_productos"].Value;

            return iCantidadVentas;
        }

        public static DataTable searchProductosCategoriaDescripcion(string textBuscar) {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand("SelectProductosSearch", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@textBuscar", textBuscar);

            DataTable dt = new DataTable();

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            cn.Close();

            return dt;
        }
    }
}
