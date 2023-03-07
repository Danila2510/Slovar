using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> name = new SortedDictionary<string, string>();
            name.Add("Англия", "England");
            name.Add("Бразилия", "Brazil");
            name.Add("Япония", "Japan");
            name.Add("Болгария", "Balguar");
            name.Add("Китай", "China");
            Console.WriteLine("1-Показать (Show)\n2-Поиск (Search)");
            Console.Write("Введите слово для перевода (Enter a word to translate)");
            string Slovo = Console.ReadLine();
            if (name.ContainsKey(Slovo))
            {
                Console.WriteLine(Slovo + ":" + name[Slovo]);
            }
            else if (name.ContainsValue(Slovo))
            {
                Console.WriteLine(Slovo + ":" + name.First(x => x.Value == Slovo).Key);
            }
            else
            {
                Console.WriteLine("Данного слова нет (This word does not exist)");
                    }
        }
    }   
}