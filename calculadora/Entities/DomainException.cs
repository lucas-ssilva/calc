using System;
using System.Collections.Generic;
using System.Text;

namespace calculadora.Entities
{
    class DomainException : Exception
    {
        public DomainException(string message) : base(message) { }
    }
}
