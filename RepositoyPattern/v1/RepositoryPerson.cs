using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoyPattern.v1
{
    class RepositoryPerson
    {
        void Add(Persona persona)
        {
            persona.Id = Persona.CreateIdentifier();
            //TODO (Guardar en base de datos)
        }
    }
}
