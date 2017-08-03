using RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoyPattern.v1
{
    class RepositoryPerson:RepositoryGeneric<Persona>
    {
        public override void Add(Persona entity)
        {
            //TODO (Si hay que hacer algún cambio se puede hacer desde aqui)
            base.Add(entity);
        }
    }
}
