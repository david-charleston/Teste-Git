using System;

namespace TryCatchPersonalizado.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base (message)
        {

        }
    }
}
