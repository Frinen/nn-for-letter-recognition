using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nn_for_letter_recognition.Data
{
    public class Desires
    {
        public static Dictionary<int, List<int>> DesiresDictionary;

        static Desires()
        {
            DesiresDictionary = new Dictionary<int, List<int>>
            {
                {0, new List<int>{
                    1,0,0
                }},
                {1, new List<int>{
                    0,1,0
                }},
                {2, new List<int>{
                    0,0,1
                }},
            };
        }

        public static Dictionary<int, List<int>> GetDictionary()
        {
            return DesiresDictionary;
        }
    }
}
