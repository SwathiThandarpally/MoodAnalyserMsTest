using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public  class InvalidCustomException: Exception
    {
        public enum ExceptionType
        {
            EMPTY_MOOD,
            NULL_MOOD,
        }

        public ExceptionType exceptionType;
        public InvalidCustomException(string message) : base(message)
        {
            message = string.Empty;

        }
    }
}
