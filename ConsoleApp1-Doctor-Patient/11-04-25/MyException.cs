using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_04_25;

public class MyException:Exception
{
    public MyException(string message):base(message)
    {
        
    }
}
