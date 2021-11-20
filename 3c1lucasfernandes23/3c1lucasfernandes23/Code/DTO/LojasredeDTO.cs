using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3c1lucasfernandes23.Code.DTO
{
    class LojasredeDTO
    {
        private int _id;
        private string _nproduto;
        private string _quantcomprada;

        public int Id { get => _id; set => _id = value; }
        public string Nomeproduto { get => _nproduto; set => _nproduto = value; }
        public string Quantidadecomprada { get => _quantcomprada; set => _quantcomprada = value; }
    }
}
