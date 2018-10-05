using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nn_for_letter_recognition.Models
{
    class Perceptron
    {
        List<Neuron> neurons;
        

        public Perceptron(List<Neuron> _neurons)
        {
            neurons = _neurons;
        }

        public void Train (Dictionary<int, List<int>> TrainData, Dictionary<int, List<int>> Desires)
        {
            for (int s = 0; s < 1000; s++)
            {
                List<int> outputs = new List<int>();
                for (int d = 0; d < TrainData.Count; d++)
                {
                    List<int> des = Desires[d];
                    while (!outputs.SequenceEqual(des))
                    {
                        
                        outputs = new List<int>();
                        for (int i = 0; i < neurons.Count; i++)
                        {
                            neurons[i].Calcutale(TrainData[i]);
                            neurons[i].CalculateEroor(Desires[d][i]);
                            if (neurons[i].Error != 0)
                            {
                                neurons[i].Correction();
                            }
                        }
                        foreach (var neur in neurons)
                        {
                            outputs.Add(neur.Output);
                        }
                        
                    }
                }
            }
        }

        public string Evaluate(List <int> inputs)
        {
            string outut = "";
            List<int> outputs = new List<int>();
            for (int i = 0; i < neurons.Count; i++)
            {
                neurons[i].Calcutale(inputs);
                outputs.Add(neurons[i].Output);
            }
            outut = $"{outputs[0]} {outputs[1]}";

                return outut;
        }
    }
}
