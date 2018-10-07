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
        public List<double> Weights;
        public int Output;
        public int Error;
        public double Eta;

        public Neuron()
        {
            Eta = 0.3;
            Inputs = new List<int>();
            Weights = new List<double>();
            Random rnd = new Random();
            for(int i = 0; i <26; i++)
            {
                
                if(i==0)
                {
                    Weights.Add(rnd.Next(10) * -1);
                }
                else
                {
                    Weights.Add(rnd.Next(10));
                }
            }

        }
        private double FindSum()
        {
            double Sum = 0;
            for (int i = 0; i < Inputs.Count; i++)
            {
                Sum += Inputs[i] * Weights[i];
            }
            return Sum;
        }

        public void Calcutale(List<int> list)
        {
            Inputs = list;
            double Sum = FindSum();
            if(Sum < 0)
            {
                Output = 0;
            }
            else
            {
                Output = 1;
            }
            
        }

        public void CalculateEroor(int desire)
        {
            Error = desire - Output;
        }

        public void Correction ()
        {
            for (int i=0;i<26;i++)
            {
                if(i == 0)
                {
                    Weights[i] = Weights[i] + Eta * Error;
                }
                else
                {
                    Weights[i] = Weights[i] + Eta * Error * Inputs[i];
                }
            }
        }
    }

}
