using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _3c1lucasfernandes23.Code.DTO; 
using _3c1lucasfernandes23.Code.DAL;

namespace _3c1lucasfernandes23.Code.BLL
{
    class LoginBLL
    {
       
        Acessoaobancodedados conexao = new Acessoaobancodedados();
        string tabela = "login";

        public bool RealizarLogin(LoginDTO login)    
        {
            string sql = $"select * from {tabela} where nome='{login.Nome}' and palavrachave='{login.Palavrachave}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}

