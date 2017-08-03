using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoyPattern.v1
{
    class RepositoryTicket
    {
        void Add(Ticket ticket)
        {
            ticket.Id = Ticket.CreateIdentifier();
            //TODO (Guardar en base de datos)
        }
    }
}
