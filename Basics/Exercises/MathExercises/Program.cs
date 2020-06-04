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
            //OddNumbers od = new OddNumbers();
            //int[] oddNumbers = od.GetOddNumber(1, 100);

            //for (int i = 0; i < oddNumbers.Length; i++)
            //{
            //    Console.WriteLine("Los numero impares " + oddNumbers[i].ToString());
            //}

            //Console.ReadKey();



            EvenNumber even = new EvenNumber();
            int[] evenNumber = even.GetEvenNumber(1, 100);

            int i = 0;
            while (i < evenNumber.Length)
            {
                Console.WriteLine("Los números pares" + evenNumber[i].ToString());
                i++;
            }

            Console.ReadKey();
        }
    }
}
