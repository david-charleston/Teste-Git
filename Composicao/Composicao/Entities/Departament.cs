using System;

namespace Composicao.Entities
{
    class Departament
    {
        public string Name { get; private set; }

        public Departament(string departament)
        {
            Name = departament;
        }
    }
}
