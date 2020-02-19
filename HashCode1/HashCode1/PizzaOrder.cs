using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace HashCode1
{
    public class PizzaOrder
    {

        int pizzaMax = 0;
        int pizzaTypes = 0;
        List<int> pizzas = new List<int>();
        string outputPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"data\output.in");

        public PizzaOrder()
        {
            GetInput();
        }

        void GetInput()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"data\d_quite_big.in");

            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = File.ReadAllLines(path);

            string[] dataline1 = lines[0].ToString().Split(null);
            pizzaMax = int.Parse(dataline1[0]);
            pizzaTypes = int.Parse(dataline1[1]);
            string[] dataline2 = lines[1].ToString().Split(null);
            for (int i = 0; i < dataline2.Length; i++)
            {
                var picka = int.Parse(dataline2[i]);
                pizzas.Add(picka);
            }

            showData();
            GetBest();
            MakeOutput();
        }

        void showData()
        {
            Console.WriteLine($"Max ilość kawałków: {pizzaMax} \n ilość typów: {pizzaTypes}");
            //Console.WriteLine($"All pizzas: {string.Join(" ", pizzas)}");
        }

        void GetBest()
        {
            var bestScore = 0;
            int[] bestIndexes = new int[pizzaTypes];
            for (int i = 0; i < pizzas.Count; i++)
            {
                var bigScore = pizzas[i];
                for (int j = 1; j < pizzaTypes - 1; j++)
                {
                    for (int k = 0; k < pizzas.Count; k++)
                    {
                        var currScore = pizzas[k] + bigScore;
                        if (currScore > bigScore && currScore < pizzaMax)
                        {
                            bigScore = currScore;
                        }
                    }
                }
                if (bigScore > bestScore)
                {
                    bestScore = bigScore;
                }
            }
            Console.Write($"Best score: {bestScore}");
        }



        void MakeOutput()
        {
            string[] lines = { $"{pizzaMax} {pizzaTypes}", string.Join(" ", pizzas) };

            File.WriteAllLines(outputPath, lines);
        }


    }
}
