using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2_Labovkin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            bool b = true; /*вводим булевую переменную*/
            str = str.ToLower(); /*без разницы с большой или маленькой буквы будут вводиться слова*/
            str = str.Replace(" ", ""); /*возвращает новую пустую строку*/
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                    b = false;
            }
            Console.WriteLine(((b) ? "является" : "не является") + " палиндромом");
            //краткая форма if else: if(b) {является} else {нет}
            Console.ReadKey();
        }
    }
}
