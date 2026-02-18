using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice21calculmoyenne.exception
{
    internal class InvalidArrayException:Exception
    {
        public InvalidArrayException(string message) :base (message) 
        {}

        
    }
}
