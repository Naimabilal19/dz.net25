using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _28._02._2023HM
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> translator = new Dictionary<string, string>();
            Dictionary<string, string> translator1 = new Dictionary<string, string>();
            translator.Add("Австрия", "Austria");
            translator.Add("Украина", "Ukraine");
            translator.Add("Канада", "Canada");
            translator.Add("Франция", "France");


            translator1.Add("Австрия", "Austria");
            translator1.Add("Украина", "Ukraine");
            translator1.Add("Канада", "Canada");
            translator1.Add("Франция", "France");


            Console.WriteLine("1)Перевести на английский\t2)Перевести на русский");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите название страны:");
            string country = Console.ReadLine();
            if (choice == 1)
            {
                if (translator.ContainsKey(country))
                {
                    Console.WriteLine(country + "переводится как: " + translator[country]);
                }
                else
                {
                    Console.WriteLine("Такой страны нет в списке");
                }
            }
            if (choice == 2)
            {
                if (translator1.ContainsKey(country))
                {
                    Console.WriteLine(country + "переводится как: " + translator1[country]);
                }
                else
                {
                    Console.WriteLine("Такой страны нет в списке");
                }
            }


        }
    }
}
