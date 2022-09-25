using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class AnalyzeMood
    {
        public string message;

       
        public AnalyzeMood(string message)
        {
            this.message = message;
        }

        
        public string Analyser() //check msg passing into the constructor 
        {
            try
            {
                if (this.message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "no mood";
                }
            }
            catch
            {
                return "happy";
            }
        }
    }

}
