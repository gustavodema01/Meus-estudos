using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_em_POO___C_.Entities
{
    internal class Department
    {
        public string name { get; private set; }

        public Department(string _name)
        {
            name = _name;
        }
    }
}
