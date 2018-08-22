using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kapral.WinFormsGenerate
{
    public class WinFormGeneratedException : Exception
    {
        public WinFormGeneratedException(string message) : base(message)
        {

        }

        public WinFormGeneratedException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
