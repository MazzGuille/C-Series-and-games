using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface IEntregable
    {
        string Entregar 
        {
            get;
            set;
        }
        string Devolver 
        {
            get;
            set;
        }

    }
}