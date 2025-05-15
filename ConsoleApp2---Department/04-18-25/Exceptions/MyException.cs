using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_18_25.Exceptions
{
    public class MyException:Exception
    {
        public MyException(string message):base(message)
        {
        
        }
    }
}
