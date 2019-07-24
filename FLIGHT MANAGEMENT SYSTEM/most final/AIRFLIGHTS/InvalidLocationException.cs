using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRFLIGHTS
{
    class InvalidLocationException:Exception
    {public InvalidLocationException(string msg):base(msg)
        {

        }
        public InvalidLocationException()
    {

    }
        
    }
}
