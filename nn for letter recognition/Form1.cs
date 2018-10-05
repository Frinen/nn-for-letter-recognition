using nn_for_letter_recognition.Data;
using nn_for_letter_recognition.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nn_for_letter_recognition
{
    public partial class Form1 : Form
    {
        List<int> sensors;
        
        Perceptron perceptron;
        public Form1()
        {
            InitializeComponent();
            sensors = new List<int>();
            for (int i = 0; i < 26; i++)
            {
                sensors.Add(0);

            }
            sensors[0] = 1;
            List<Neuron> neurons = new List<Neuron>();
            for (int i = 0; i < Desires.GetDictionary().Count; i++)
            {
                neurons.Add(new Neuron());
            }
            perceptron = new Perceptron(neurons);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (sensors[1]  == 0)
            {
                button1.BackColor = Color.DarkBlue;
                sensors[1]  = 1;
            }
            else
            {
                button1.BackColor = Color.White;
                sensors[1]  = 0;
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (sensors[2]  == 0)
            {
                button2.BackColor = Color.DarkBlue;
                sensors[2]  = 1;
            }
            else
            {
                button2.BackColor = Color.White;
                sensors[2]  = 0;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (sensors[3]  == 0)
            {
                button3.BackColor = Color.DarkBlue;
                sensors[3]  = 1;
            }
            else
            {
                button3.BackColor = Color.White;
                sensors[3]  = 0;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (sensors[4]  == 0)
            {
                button4.BackColor = Color.DarkBlue;
                sensors[4]  = 1;
            }
            else
            {
                button4.BackColor = Color.White;
                sensors[4]  = 0;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (sensors[5]  == 0)
            {
                button5.BackColor = Color.DarkBlue;
                sensors[5]  = 1;
            }
            else
            {
                button5.BackColor = Color.White;
                sensors[5]  = 0;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (sensors[6]  == 0)
            {
                button6.BackColor = Color.DarkBlue;
                sensors[6]  = 1;
            }
            else
            {
                button6.BackColor = Color.White;
                sensors[6]  = 0;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (sensors[7]  == 0)
            {
                button7.BackColor = Color.DarkBlue;
                sensors[7]  = 1;
            }
            else
            {
                button7.BackColor = Color.White;
                sensors[7]  = 0;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (sensors[8]  == 0)
            {
                button8.BackColor = Color.DarkBlue;
                sensors[8]  = 1;
            }
            else
            {
                button8.BackColor = Color.White;
                sensors[8]  = 0;
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (sensors[9]  == 0)
            {
                button9.BackColor = Color.DarkBlue;
                sensors[9]  = 1;
            }
            else
            {
                button9.BackColor = Color.White;
                sensors[9]  = 0;
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (sensors[10]  == 0)
            {
                button10.BackColor = Color.DarkBlue;
                sensors[10]  = 1;
            }
            else
            {
                button10.BackColor = Color.White;
                sensors[10]  = 0;
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (sensors[11]  == 0)
            {
                button11.BackColor = Color.DarkBlue;
                sensors[11]  = 1;
            }
            else
            {
                button11.BackColor = Color.White;
                sensors[11]  = 0;
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (sensors[12]  == 0)
            {
                button12.BackColor = Color.DarkBlue;
                sensors[12]  = 1;
            }
            else
            {
                button12.BackColor = Color.White;
                sensors[12]  = 0;
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (sensors[13]  == 0)
            {
                button13.BackColor = Color.DarkBlue;
                sensors[13]  = 1;
            }
            else
            {
                button13.BackColor = Color.White;
                sensors[13]  = 0;
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            if (sensors[14]  == 0)
            {
                button14.BackColor = Color.DarkBlue;
                sensors[14]  = 1;
            }
            else
            {
                button14.BackColor = Color.White;
                sensors[14]  = 0;
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (sensors[15]  == 0)
            {
                button15.BackColor = Color.DarkBlue;
                sensors[15]  = 1;
            }
            else
            {
                button15.BackColor = Color.White;
                sensors[15]  = 0;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (sensors[16]  == 0)
            {
                button16.BackColor = Color.DarkBlue;
                sensors[16]  = 1;
            }
            else
            {
                button16.BackColor = Color.White;
                sensors[16]  = 0;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (sensors[17]  == 0)
            {
                button17.BackColor = Color.DarkBlue;
                sensors[17]  = 1;
            }
            else
            {
                button17.BackColor = Color.White;
                sensors[17]  = 0;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (sensors[18]  == 0)
            {
                button18.BackColor = Color.DarkBlue;
                sensors[18]  = 1;
            }
            else
            {
                button18.BackColor = Color.White;
                sensors[18]  = 0;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (sensors[19]  == 0)
            {
                button19.BackColor = Color.DarkBlue;
                sensors[19]  = 1;
            }
            else
            {
                button19.BackColor = Color.White;
                sensors[19]  = 0;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (sensors[20]  == 0)
            {
                button20.BackColor = Color.DarkBlue;
                sensors[20]  = 1;
            }
            else
            {
                button20.BackColor = Color.White;
                sensors[20]  = 0;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (sensors[21]  == 0)
            {
                button21.BackColor = Color.DarkBlue;
                sensors[21]  = 1;
            }
            else
            {
                button21.BackColor = Color.White;
                sensors[21]  = 0;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (sensors[22]  == 0)
            {
                button22.BackColor = Color.DarkBlue;
                sensors[22]  = 1;
            }
            else
            {
                button22.BackColor = Color.White;
                sensors[22]  = 0;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (sensors[23]  == 0)
            {
                button23.BackColor = Color.DarkBlue;
                sensors[23]  = 1;
            }
            else
            {
                button23.BackColor = Color.White;
                sensors[23]  = 0;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (sensors[24]  == 0)
            {
                button24.BackColor = Color.DarkBlue;
                sensors[24]  = 1;
            }
            else
            {
                button24.BackColor = Color.White;
                sensors[24]  = 0;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (sensors[25]  == 0)
            {
                button25.BackColor = Color.DarkBlue;
                sensors[25]  = 1;
            }
            else
            {
                button25.BackColor = Color.White;
                sensors[25]  = 0;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            
            perceptron.Train(TrainData.GetDictionary(), Desires.GetDictionary());
        }

        private void button27_Click(object sender, EventArgs e)
        {
            MessageBox.Show(perceptron.Evaluate(sensors));
        }
    }
}
