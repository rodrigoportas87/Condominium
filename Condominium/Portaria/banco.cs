using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Portaria
{
    class banco
    {
        public SqlConnection conexao = new SqlConnection(Properties.Settings.Default.PortariaDBConnectionString);

        public Boolean executar(string sql)
        {

            while (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }


            try
            {             
                SqlCommand comando = new SqlCommand(sql, conexao);       
                comando.ExecuteNonQuery();
                conexao.Close();
                return true;
            }
            catch (Exception E)
            {
                String e = E.ToString();
                conexao.Close();
                return false;
            }
        }

        public DataTable Pesquisa(String Sql)
        {
            
            DataTable DtRetorno = new DataTable();
            SqlCommand Comando = new SqlCommand(Sql,conexao);
            conexao.Open();                        
            //create data adapter();
            SqlDataAdapter da = new SqlDataAdapter(Comando);
            // this will query your database and return the result to your datatable
            da.Fill(DtRetorno);
            conexao.Close();
            //da.Dispose();
            return DtRetorno;
        }
        
     
    }
}
