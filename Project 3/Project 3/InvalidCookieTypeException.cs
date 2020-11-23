using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    public class InvalidCookieTypeException : Exception
    {
        private static string msg = "Cookie type is not C, O or S.";

        public InvalidCookieTypeException() : base(msg) { }
    }
}
