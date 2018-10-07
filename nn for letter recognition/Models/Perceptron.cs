using nn_for_letter_recognition.Data;
using System;
using System.Collections.Generic;
using System.IO;
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
            /* for (int s = 0; s < 1000; s++)
             {

                 for (int d = 0; d < TrainData.Count; d++)
                 {
                    /* List<int> outputs = new List<int>();
                     while (!outputs.SequenceEqual(Desires[d]))
                     {

                        // outputs = new List<int>();
                         for (int i = 0; i < neurons.Count; i++)
                         {
                             for (int j = 0; j < neurons.Count; j++)
                             {
                                 neurons[i].Calcutale(TrainData[j]);
                                 neurons[i].CalculateEroor(Desires[d][j]);
                                 if (neurons[i].Error != 0)
                                 {
                                     neurons[i].Correction();
                                 }
                             }
                         }
                         for (int i = 0; i < neurons.Count; i++)
                         {
                             neurons[i].Calcutale(TrainData[d]);
                             outputs.Add(neurons[i].Output);
                         }

                     }
                 }*/

            for (int j = 0; j < 100000; j++)
            {
                for (int t = 0; t < TrainData.Count; t++)
                {
                    for (int i = 0; i < neurons.Count; i++)
                    {
                        neurons[i].Calcutale(TrainData[t]);
                        neurons[i].CalculateEroor(Desires[t][i]);
                        neurons[i].Correction();
                    }
                }
            }
            
        }

        public string Evaluate(List <int> inputs)
        {
            string letterOut = "";
            List<int> outputs = new List<int>();
            char letter;
            for (int i = 0; i < neurons.Count; i++)
            {
                neurons[i].Calcutale(inputs);
                outputs.Add(neurons[i].Output);
                if(neurons[i].Output == 1)
                {
                    letter =Convert.ToChar(97 + i);
                    letterOut += letter;
                }
                //letterOut += $"{outputs[i]} ";
            }
            
                return letterOut;
        }

        public string WrightWeight()
        {
            try
            {
                string writePath = @"ath.txt";
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    foreach (var neuron in neurons)
                    {
                        foreach(var weight in neuron.Weights)
                        {
                            sw.WriteLine(weight);
                        }
                    }
                    return ("success");
                }
            }
            catch (Exception ex)
            {
                return ("error");
            }
        }
        public string ReadWeight()
        {
            try
            {
                string readPath = @"ath.txt";
                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    string line;
                    for (int i = 0; i < neurons.Count; i++)
                    {
                        for(int j = 0; j<neurons[i].Weights.Count; j++)
                        {
                            line = sr.ReadLine();
                            neurons[i].Weights[j] = Convert.ToDouble(line);
                        }
                        

                    }
                }
                return ("success");
            }
            catch (Exception ex)
            {
                return ("error");
            }
        }
    }
}
