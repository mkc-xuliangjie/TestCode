using System;

namespace GeTui.Module.Domain.Exceptions
{
    internal class TemplateTypeException : Exception
    {
        public TemplateTypeException()
        {
        }

        public TemplateTypeException(string message) : base(message)
        {
        }
    }
}