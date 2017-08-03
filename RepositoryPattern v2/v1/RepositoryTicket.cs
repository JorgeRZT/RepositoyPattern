using RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoyPattern.v1
{
    class RepositoryTicket:RepositoryGeneric<Ticket>
    {
        public override void Add(Ticket entity)
        {
            //TODO (Si hay que hacer algún cambio se puede hacer desde aqui)
            base.Add(entity);
        }

    }
}
