using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase {
    public class TrabajarObraSocial {
        public static DataTable showAllObrasSociales() {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand("selectTodasObrasSociales", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            cn.Close();

            return dt;
        }
    }
}
