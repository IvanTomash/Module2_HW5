using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_5
{
    [Serializable]
    internal class BusinessException : Exception
    {
        public string MyInfo { get; set; }
        
        public BusinessException() 
        {
        }

        public BusinessException(string message) 
            : base(message)
        {
        }

        public BusinessException(string message, Exception inner)
            : base(message, inner) 
        {
        }

        protected BusinessException(SerializationInfo info, StreamingContext context)
            : base(info, context) 
        {
        }
    }
}
