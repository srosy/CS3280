using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BookNameEmptyException : Exception
    {
        public BookNameEmptyException() { }
        public BookNameEmptyException(string message) : base(message) { }
        public BookNameEmptyException(string message, Exception inner) : base(message, inner) { }
    }
}
