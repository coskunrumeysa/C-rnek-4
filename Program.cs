using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_Proje_4
{
    internal class Program
    {
        static void Main(string[] args)

        {   // Declaration Variables
            int number1;
            int number2;

            // Function of Number1 and Number2 get of value
            Console.Write("1.Sayıyı Giriniz:");
            number1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("2.Sayıyı Giriniz:");
            number2 = Convert.ToInt32(Console.ReadLine());

            // Desicion Block
            if(number1>number2)
            {
                Console.Write("Büyük Sayı İlk sayıdır : " + number1);
            }

            else if(number1 < number2)
            {
                Console.Write("Büyük Sayı İkinci sayıdır : " + number2);

            }

            else
            {
                Console.Write(number1 +" " + "ve" + " " + number2 + " " + "İlk sayı ve ikinci sayı birbilerine eşittir.");
            }

            Console.ReadKey();

        }
    }
}
