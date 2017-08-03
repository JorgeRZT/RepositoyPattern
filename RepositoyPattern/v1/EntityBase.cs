using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoyPattern.v1
{
    public abstract class EntityBase
    {
        //Identificador único global
        public Guid Id { get; set; }    
        public static Guid CreateIdentifier()
        {
            return new Guid();
        }
    }
}
