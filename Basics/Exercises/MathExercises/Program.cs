using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathExercises.Logic;
namespace MathExercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Ejecuta obtener Numeros Impares
            //OddNumbers od = new OddNumbers();
            //int[] oddNumbers = od.GetOddNumber(1, 100);

            //for (int i = 0; i < oddNumbers.Length; i++)
            //{
            //    Console.WriteLine("Los numero impares " + oddNumbers[i].ToString());
            //}

            //Console.ReadKey();


            //Ejecuta obtener Numeros Pares
            //EvenNumber even = new EvenNumber();
            //int[] evenNumber = even.GetEvenNumber(1, 100);

            //int i = 0;
            //while (i < evenNumber.Length)
            //{
            //    Console.WriteLine("Los números pares" + evenNumber[i].ToString());
            //    i++;
            //}

            //Console.ReadKey();

            //Refactorizacion para Numeros Pares e Impares
            //Number number = new Number();
            //int[] numbers = number.GetNumber(1, 100, false);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Los numero son: " + numbers[i].ToString());
            //}

            //Console.ReadKey();

            
            PrimeNumbers prime = new PrimeNumbers();
            List<int> numbers = prime.GetPrimeNumbers(1, 100);

            foreach(int number in numbers)
            {
                Console.WriteLine("Los números primos son: " + number.ToString());
            }

            Console.ReadKey();



        }
    }
}
