using System;

namespace DadosBanco.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
