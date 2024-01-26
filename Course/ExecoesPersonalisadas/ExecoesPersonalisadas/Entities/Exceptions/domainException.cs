using System;

namespace ExecoesPersonalisadas.Entities.Exceptions
{
    internal class domainException : ApplicationException
    {
        public domainException(string message) : base(message)
        {
        }
    }
}
