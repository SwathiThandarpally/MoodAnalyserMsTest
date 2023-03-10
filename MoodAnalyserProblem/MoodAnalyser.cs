using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public  class MoodAnalyser
    {
        public string message;

        public MoodAnalyser()
        {
            Console.WriteLine();
        }

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            if (message.ToLower().Contains("Happy"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
       
      
        public string AnalyseMoodWithoutConstructor(string message)
        {
            if (message.ToLower().Contains("sad"))
                return "SAD";

            else return "HAPPY";

        }
      
    }
}


