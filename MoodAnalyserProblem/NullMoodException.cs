using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class NullMoodException : Exception
    {
        public NullMoodException(string message) : base(message)
        {

        }
    }
    
}
