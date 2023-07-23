using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaEntidade;
using System.Data.SqlClient;
using System.Data;

namespace CamadaDados
{
    public class ClasseDados
    {
        SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionString["sql"].ConnectionString);

        public DataTable Dlogin(ClasseEntidade obj)
        {
            SqlCommand cmd = new SqlCommand("sp_logar", conectar);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obj.user);
            cmd.Parameters.AddWithValue("@usuario", obj.passe);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
