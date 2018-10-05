using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace nn_for_letter_recognition.Data
{
    class TrainData
    {
        public static Dictionary<int, List<int>> TrainDictionary;

        static TrainData()
        {
            TrainDictionary = new Dictionary<int, List<int>>
            {
                {0, new List<int>{1,
                    0,1,1,0,0,
                    1,0,0,1,0,
                    1,1,1,1,0,
                    1,0,0,1,0,
                    1,0,0,1,0
                }},
                {1, new List<int>{1,
                    1,1,1,0,0,
                    1,0,0,1,0,
                    1,1,1,0,0,
                    1,0,0,1,0,
                    1,1,1,0,0
                }},
            };
        }

        public static Dictionary<int, List<int>> GetDictionary()
        {
            return TrainDictionary;
        }
    }
}