using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions
{
    public class ComplementaryDNA
    {
        public static string Execute()
        {
            string dna = "GTAT";
            string result = "";
            foreach (var item in dna)
            {
                switch (item)
                {
                    case 'A':
                        result += "T";
                        continue;
                    case 'T':
                        result += "A";
                        continue;
                    case 'C':
                        result += "G";
                        continue;
                    case 'G':
                        result += "C";
                        continue;
                    default:
                        break;
                }
            }

            return result;

        }
    }
}
