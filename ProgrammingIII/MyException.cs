using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingIII
{
    public class MyException : Exception
    {
        private string message;
        public MyException(string message)
        {
            this.message = message;
        }
        public string toString()
        {
            return string.Format("Error {0} ", message);
        }
    }
}
