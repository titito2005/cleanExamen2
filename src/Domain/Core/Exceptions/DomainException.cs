using System;
namespace Examen2.Domain.Core.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException(string? message) : base(message)
        {
        }
    }
}
