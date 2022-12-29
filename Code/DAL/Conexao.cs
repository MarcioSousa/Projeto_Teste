using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTeste.Code.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        private DataTable data;
        private SqlDataAdapter da;
        private SqlCommandBuilder cb;


        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-KVDH1EE\SQLEXPRESS;Initial Catalog=TesteBD;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
                return con;
        }

        public DataTable RetDataTable (string sql)
        {
            data = new DataTable();
            da = new SqlDataAdapter(sql, con);
            cb = new SqlCommandBuilder(da);
            da.Fill(data);

            return data;
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
