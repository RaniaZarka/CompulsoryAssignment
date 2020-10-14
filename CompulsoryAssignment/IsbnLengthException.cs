using System;
using System.Collections.Generic;
using System.Text;

namespace CompulsoryAssignment
{
    public class IsbnLengthException: Exception
    {
        public IsbnLengthException() : base ("Should be 13 charachters") { }

        public IsbnLengthException(string message): base( message) { }
        public IsbnLengthException(string message, Exception inner) : base ( message, inner) { }

    }
}
