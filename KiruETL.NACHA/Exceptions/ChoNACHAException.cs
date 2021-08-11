using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Kiru
{
    [Serializable]
    public class ChoNACHAException : ApplicationException
    {
        public ChoNACHAException()
            : base()
        {
        }

        public ChoNACHAException(string message)
            : base(message)
        {
        }

        public ChoNACHAException(string message, Exception e)
            : base(message, e)
        {
        }

        protected ChoNACHAException(SerializationInfo si, StreamingContext sc)
            : base(si, sc)
        {
        }
    }
}
