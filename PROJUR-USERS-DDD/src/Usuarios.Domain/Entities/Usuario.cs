using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Usuarios.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public string Nome { get;  set; }
        public string Sobrenome { get;  set; }
        public string Email { get;  set; }
        public DateTime DataNascimento { get;  set; }
        public int Escolaridade { get;  set; }

    }
}