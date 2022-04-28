using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rum say sistemində yazılmış iki natural A və B ədədlərinin cəmini hesablayın. Cavabı da Rum say sistemində yazın.

           // M = 1000, D = 500, C = 100, L = 50, X = 10, V = 5, I = 1(Bütün ədədlər 2000 - ni aşmır).

           // Giriş verilənləri
            //III + IV

            //Çıxış verilənləri
               //VII
            Console.WriteLine("Rum reqemini daxil edin: ");
            string rum = Console.ReadLine();
            string rum2 = Console.ReadLine();
            int number = 0;
            int number2 = 0;

            Dictionary<char, int> dict = new Dictionary<char, int>();

            dict.Add('I', 1);
            dict.Add('V', 5);
            dict.Add('X', 10);
            dict.Add('L', 50);
            dict.Add('C', 100);
            dict.Add('D', 500);
            dict.Add('M', 1000);

            Dictionary<char, int> dict2 = new Dictionary<char, int>();

            dict2.Add('I', 1);
            dict2.Add('V', 5);
            dict2.Add('X', 10);
            dict2.Add('L', 50);
            dict2.Add('C', 100);
            dict2.Add('D', 500);
            dict2.Add('M', 1000);

            for (int i = 0; i < rum.Length; i++)
            {
                if (i != rum.Length - 1)
                {
                    if (dict[rum[i]] >= dict[rum[i + 1]])
                    {

                        number += dict[rum[i]];
                       
                    }
                    else
                    {
                        number -= dict[rum[i]];
                       
                    }

                }
                else
                {
                    number += dict[rum[i]];
                   
                }
            }
            for (int j = 0; j < rum2.Length; j++)
            {
                if (j != rum2.Length - 1)
                {
                    if (dict2[rum2[j]] >= dict2[rum2[j + 1]])
                    {

                       
                        number2 += dict2[rum2[j]];
                    }
                    else
                    {
                       
                        number2 -= dict2[rum2[j]];
                    }

                }
                else
                {
                   
                    number2 += dict2[rum2[j]];
                }
            }
           
          

            int sum = 0;

            for (int k = 0; k < 2000; k++)
            {
                sum = number + number2;
            }
            Console.WriteLine(" Rum reqeminin qarsiligi: ");
            Console.WriteLine(number);
            Console.WriteLine(number2);
            Console.WriteLine("Reqemlerin cemi: ");
            Console.WriteLine(sum);

          
          
        }
    }
}
