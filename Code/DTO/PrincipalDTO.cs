using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoTeste.Code.BLL;



namespace ProjetoTeste.Code.DTO
{
    class PrincipalDTO
    {
        private int id;
        public int Id
        {
            get { return Id; }
            set { id = value; }
        }

        private string nome;
         public string Nome
        {
            get { return Nome; }
            set { nome = value; }
        }
        private string senha;
        public string Senha
        {
            get { return Senha; }
            set { senha = value; }
        }


    }
}
