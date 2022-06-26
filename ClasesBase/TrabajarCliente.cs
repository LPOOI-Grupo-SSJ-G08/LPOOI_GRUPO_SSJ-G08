﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCliente
    {
        public static void insert_cliente(Cliente oCliente)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Cliente(Cli_DNI, Cli_Nombre, Cli_Apellido, Cli_Direccion, OS_CUIT, Cli_NroCarnet) ";
            cmd.CommandText += "values(@DNI, @nombre, @apellido, @direccion, @CUIT, @nroCarnet)";
            cmd.CommandType = CommandType.Text;

            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@DNI", oCliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@nombre", oCliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", oCliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@direccion", oCliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@CUIT", oCliente.Os_CUIT);
            cmd.Parameters.AddWithValue("@nroCarnet", oCliente.Cli_NroCarnet);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static DataTable list_clientes()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " Cli_DNI as 'DNI', ";
            cmd.CommandText += " Cli_Nombre as 'Nombre', ";
            cmd.CommandText += " Cli_Apellido as 'Apellido', ";
            cmd.CommandText += " Cli_Direccion as 'Direccion', ";
            cmd.CommandText += " OS_CUIT as 'CUIT', ";
            cmd.CommandText += " Cli_NroCarnet as 'Nro de Carnet' ";
            cmd.CommandText += " FROM Cliente ";
            cmd.CommandType = CommandType.Text;

            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void update_cliente(Cliente oCliente)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Cliente SET ";
            cmd.CommandText += " Cli_Nombre=@nombre, ";
            cmd.CommandText += " Cli_Apellido=@apellido, ";
            cmd.CommandText += " Cli_Direccion=@direccion, ";
            cmd.CommandText += " OS_CUIT=@CUIT, ";
            cmd.CommandText += " Cli_NroCarnet=@nroCarnet ";
            cmd.CommandText += " WHERE Cli_DNI=@DNI";
            cmd.CommandType = CommandType.Text;

            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@nombre", oCliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", oCliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@direccion", oCliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@CUIT", oCliente.Os_CUIT);
            cmd.Parameters.AddWithValue("@nroCarnet", oCliente.Cli_NroCarnet);
            cmd.Parameters.AddWithValue("@DNI", oCliente.Cli_DNI);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void delete_cliente(string szDNI)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Cliente WHERE Cli_DNI=@DNI";
            cmd.CommandType = CommandType.Text;

            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@DNI", szDNI);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static DataTable search_clientes(string szTextoBuscar)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "list_clientes_x_filtros_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@textoBuscar", "%" + szTextoBuscar + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataSet list_cliente_por_apellido(char? tipoOrdenacion)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand( "listar_clientes_x_apellido" ,cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            param = new SqlParameter("@tipoOrdenacion", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = tipoOrdenacion;
            da.SelectCommand.Parameters.Add(param);

            DataSet ds = new DataSet();
            da.Fill(ds, "Clientes");


            return ds;
        }

        public static DataTable list_cliente_por_orden(char? tipoOrdenacion, string szTextoBuscar)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_clientes_ordenados_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@textoBuscar", "%" + szTextoBuscar + "%");
            cmd.Parameters.AddWithValue("@tipoOrdenacion", tipoOrdenacion);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
