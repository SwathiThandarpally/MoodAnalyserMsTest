using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public  class MoodChangeRefactory
    {
        public MoodChangeRefactory()
        {
            Console.WriteLine("Change Refactory");
        }

        public MoodChangeRefactory(string Happy)
        {


            if (Happy == null)
            {
                try
                {
                    Console.WriteLine("Happy");
                }
                catch
                {
                    Console.WriteLine("Sad");
                }
            }

        }
    }
}
