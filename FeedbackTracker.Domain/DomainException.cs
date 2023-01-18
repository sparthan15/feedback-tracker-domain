using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackTracker.Domain
{
    public class DomainException : Exception
    {
        public DomainException(string message)
            :base(message) { 
            
        }

        protected DomainException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }
}
