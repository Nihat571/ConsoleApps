using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_Console_app.Exceptions;

public class MyExceptions:Exception
{
    public MyExceptions(string msg):base(msg)
    {
        
    }
}
