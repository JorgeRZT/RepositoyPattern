using RepositoyPattern.v1;
using System;

namespace RepositoryPattern_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket() { Total = 1000 };
            var repositoryTicket = new RepositoryTicket();
            repositoryTicket.Add(ticket);
        }
    }
}