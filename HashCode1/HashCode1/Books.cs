using System;
using System.IO;
using System.Reflection;

namespace HashCode1
{
    public class Books
    {

        int numberOfBooks = 0;
        int numberOfLibraries = 0;
        int numberOfDays = 0;
        int[] bookScores;
        Library[] libraries;

        string outputPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"data\output.in");

        public Books()
        {
            GetInput();
        }

        void GetInput()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"data\a_example.txt");

            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = File.ReadAllLines(path);

            string[] dataline1 = lines[0].ToString().Split(null);
            numberOfBooks = int.Parse(dataline1[0]);
            numberOfLibraries = int.Parse(dataline1[1]);
            numberOfDays = int.Parse(dataline1[2]);

            bookScores = new int[numberOfBooks];

            string[] dataline2 = lines[1].ToString().Split(null);

            for (int i = 0; i < bookScores.Length; i++)
            {
                bookScores[i] = int.Parse(dataline2[i]);
            }

            //zarejstruj biblioteki
            libraries = new Library[numberOfLibraries];
            string[] dataline;
            int[] bookids;
            int id = 0;
            for (int i = 0; i < numberOfLibraries * 2; i += 2)
            {
                dataline = lines[i].ToString().Split(null);
                bookids = Array.ConvertAll(lines[i + 1].ToString().Split(null), s => int.Parse(s));
                libraries[id] = new Library(id, int.Parse(dataline[0]), int.Parse(dataline[1]), int.Parse(dataline[2]), bookids, bookScores);
                id++;
            }

            showData();
            //GetBest();
            //MakeOutput();
        }

        void showData()
        {
            Console.WriteLine($"Liczba książek: {numberOfBooks} \n liczba bibliotek : {numberOfLibraries} \n Dni na skanowanie: {numberOfDays} ");

        }

        void GetBest()
        {
            //var bestScore = 0;
            //int[] bestIndexes = new int[pizzaTypes];
            //for (int i = 0; i < pizzas.Count; i++)
            //{
            //    var bigScore = pizzas[i];
            //    for (int j = 1; j < pizzaTypes - 1; j++)
            //    {
            //        for (int k = i; k < pizzas.Count; k++)
            //        {
            //            var currScore = pizzas[k] + bigScore;
            //            if (currScore > bigScore && currScore <= pizzaMax)
            //            {
            //                bigScore = currScore;
            //            }
            //        }
            //    }
            //    if (bigScore > bestScore)
            //    {
            //        bestScore = bigScore;
            //        Console.WriteLine($"Best score: {bestScore}");
            //    }
            //}
            Console.WriteLine("FINISHED");
            Console.Beep(37, 200);
        }



        void MakeOutput()
        {
            //string[] lines = { $"{pizzaMax} {pizzaTypes}", string.Join(" ", pizzas) };

            //File.WriteAllLines(outputPath, lines);
        }


    }
}
