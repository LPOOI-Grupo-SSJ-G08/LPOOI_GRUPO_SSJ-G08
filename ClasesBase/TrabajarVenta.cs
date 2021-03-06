using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase {
    public class TrabajarVenta {

        public static DataTable getAllClientes() {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            return dt;
        }

        public static DataTable getAllProductos() {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Producto";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static int agregarVenta(Venta venta) {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Venta(Ven_Fecha, Cli_DNI) values(@fechaVenta, @dniCLiente); SELECT SCOPE_IDENTITY()";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@fechaVenta", venta.Ven_Fecha);
            cmd.Parameters.AddWithValue("@dniCLiente", venta.Cli_DNI);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            cn.Open();
            int iVentaNro = Convert.ToInt32(cmd.ExecuteScalar());
            cn.Close();

            return iVentaNro;
        }

        public static void agregarDetalleVenta(VentaDetalle ventaDetalle) {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO VentaDetalle(Ven_Nro, Prod_Codigo, Det_Precio, Det_Cantidad, Det_Total) values(@ventaNro, @prodCodigo, @detPrecio, @detCantidad, @detTotal); SELECT SCOPE_IDENTITY()";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@ventaNro", ventaDetalle.Ven_Nro);
            cmd.Parameters.AddWithValue("@prodCodigo", ventaDetalle.Prod_Codigo);
            cmd.Parameters.AddWithValue("@detPrecio", ventaDetalle.Det_Precio);
            cmd.Parameters.AddWithValue("@detCantidad", ventaDetalle.Det_Cantidad);
            cmd.Parameters.AddWithValue("@detTotal", ventaDetalle.Det_Total);

            cn.Open();
            int iVentaNro = Convert.ToInt32(cmd.ExecuteScalar());
            cn.Close();
        }

        public static DataTable getAllVentas()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_ventas_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable getVentasByCliente(string szDNI)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_ventas_x_cliente_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@DNI", szDNI);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static int getCantidadVentasByCliente(string szDNI)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "get_count_ventas_x_cliente_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@DNI", szDNI);
            cmd.Parameters.Add("@cantidad_ventas", SqlDbType.Int);
            cmd.Parameters["@cantidad_ventas"].Direction = ParameterDirection.Output;

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            int iCantidadVentas = (int) cmd.Parameters["@cantidad_ventas"].Value;

            return iCantidadVentas;
        }

        public static DataTable getVentasByFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_ventas_x_fechas_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
            cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static int getCantidadVentasByFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "get_count_ventas_x_fechas_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
            cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
            cmd.Parameters.Add("@cantidad_ventas", SqlDbType.Int);
            cmd.Parameters["@cantidad_ventas"].Direction = ParameterDirection.Output;

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            int iCantidadVentas = (int)cmd.Parameters["@cantidad_ventas"].Value;

            return iCantidadVentas;
        }

        public static void delete_venta(int iCodigo)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete_venta_sp";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@codigo", iCodigo);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

    }
}
