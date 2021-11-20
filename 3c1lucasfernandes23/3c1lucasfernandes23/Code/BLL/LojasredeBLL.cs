using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3c1lucasfernandes23.Code.DTO;
using _3c1lucasfernandes23.Code.DAL;
using System.Data;

namespace _3c1lucasfernandes23.Code.BLL
{
    class LojasredeBLL
    {
        Acessoaobancodedados conexao = new Acessoaobancodedados();
        string tabela = "cadastrodeproduto";

        public void Inserir(LojasredeDTO medDto)
        {
            string inserir = $"insert into {tabela} values(null,'{medDto.Nomeproduto}','{medDto.Quantidadecomprada}')";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(LojasredeDTO meddDto)
        {
            string alterar = $"update {tabela} set nproduto = '{meddDto.Nomeproduto}', quantcomprada = '{meddDto.Quantidadecomprada}' where id = '{meddDto.Id}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(LojasredeDTO medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
    }
}
