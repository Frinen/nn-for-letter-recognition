using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nn_for_letter_recognition.Models
{
    public class Neuron
    {
        List<int> Inputs;
        List<int> Weights;
        int Output;
        int Error;

        public Neuron()
        {
            Inputs = new List<int>();
            Weights = new List<int>();
            Random rnd = new Random();
            for(int i = 0; i <26; i++)
            {
                if(i==0)
                {
                    Weights[i] = rnd.Next(10) * -1;
                }
                else
                {
                    Weights[i] = rnd.Next(10);
                }
            }

        }
        private int FindSum()
        {
            int Sum = 0;
            for (int i = 0; i < Inputs.Count; i++)
            {
                Sum += Inputs[i] * Weights[i];
            }
            return Sum;
        }
        public int Calcutale(List<int> list)
        {
            Inputs = list;
            int Sum = FindSum();
            if(Sum < 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }


    }
}
