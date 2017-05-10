using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandOnZanzibar
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            
            int[] outputs = new int[t];

            for (int i = 0; i < t; i++)
            {
                string[] inputs = Console.ReadLine().Split();

                int numberOfTurtles = 1;

                foreach (var input in inputs)
                {
                    int newTotal = int.Parse(input);

                    if (newTotal == 0)
                    {
                        break;
                    }
                    else if (newTotal == 1)
                    {
                        continue;
                    }
                    else if (newTotal > numberOfTurtles * 2)
                    {
                        outputs[i] += newTotal - numberOfTurtles * 2;
                        numberOfTurtles = newTotal;
                    }
                    else
                    {
                        numberOfTurtles = newTotal;
                    }

                }
                
            }

            foreach (var output in outputs)
            {
                Console.WriteLine(output);
            }
        }
    }
}
