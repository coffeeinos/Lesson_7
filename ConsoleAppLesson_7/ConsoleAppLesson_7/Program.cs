using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // зубчатый или ступенчатый массив

            int[][] array = new int[3][];

            array[0] = new int[5];
            array[1] = new int[3];
            array[2] = new int[4];

            // вначале мы обьевляем одномерный массив, который содержит в каждом свое элементе отдельный одномерный массив
            // после, для всех "подмассивов", так же выделяем память

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = random.Next(50);
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
            }

            Console.WriteLine("");
        }
    }
}
