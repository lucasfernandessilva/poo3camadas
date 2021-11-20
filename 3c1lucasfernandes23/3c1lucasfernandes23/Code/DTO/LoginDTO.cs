using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3c1lucasfernandes23.Code.DTO
{
    class LoginDTO
    {
        private int _id;
        private string _nome;
        private string _palavrachave;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Palavrachave { get => _palavrachave; set => _palavrachave = value; }
    }
}
