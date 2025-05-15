using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App__22_aprel_.Exceptions;

public class NotAvailableException:Exception
{
    public NotAvailableException(string msg):base(msg)
    {
        
    }
}
