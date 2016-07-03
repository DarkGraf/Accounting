using System;

namespace AccountingWebMvc.Bll.Infrastructure
{
    public class ValidationException : Exception
    {
        public ValidationException(string message, string property) : base(message)
        {
            Property = property;
        }

        public string Property { get; protected set; }
    }
}
