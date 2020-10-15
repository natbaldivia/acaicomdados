using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acaicomdados.api
{
    public class pessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public estadocivil estadocivil { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}
