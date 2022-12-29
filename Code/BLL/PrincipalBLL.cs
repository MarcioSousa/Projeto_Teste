using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProjetoTeste.Code.DAL;

namespace ProjetoTeste.Code.BLL
{
    class PrincipalBLL
    {
        DataTable dt = new DataTable();


        Conexao con;
        public DataTable SelecionaTodos()
        {

            try
            {
                con = new Conexao();
                con.Conectar();

                dt = con.RetDataTable("SELECT id, usuario, senha FROM tbTeste");
            }

            catch(Exception ex)
            {

                throw new Exception("Erro ao tentar selecionar os dados: " + ex.Message);

            }
            finally
            {
                con = null;
            }
            return dt;
        }

    }


}

