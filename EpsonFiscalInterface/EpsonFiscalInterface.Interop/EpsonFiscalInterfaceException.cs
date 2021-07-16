using System;

namespace EpsonFiscalInterface.Interop
{
    public class EpsonFiscalInterfaceException : Exception
    {
        public EpsonFiscalInterfaceException(string message) : base(message) { }

        public EpsonFiscalInterfaceException(string message, Exception innerException) : base(message, innerException) { }

        public EpsonFiscalInterfaceException(string message, int errorNumber) : base(message) { ErrorNumber = errorNumber; }

        public override string ToString()
        {
            string baseMessage = base.ToString();

            if (ErrorNumber != 0)
            {
                return baseMessage.Insert(baseMessage.IndexOf(':'), string.Format(" (0x{0})", Convert.ToString(ErrorNumber, 0x10)));
            }

            return baseMessage;
        }

        public int ErrorNumber { get; private set; }
    }
}
