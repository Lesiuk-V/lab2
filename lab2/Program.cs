using System;

namespace lab2
{
    class Program
    {
        static int CountSymbolOfStr(string Strs)
        {
            int count = 0;
            foreach (char n in Strs)
            {
                count++;
            }
            return count;
        }
        //Фунцкія для перевірки чи містить стр1 всі символи стр2
        static void CheckSymbols(string str1, string str2, int countStr1, int countStr2)
        {
            string str = RemoveDuplicateChars(str1);
            int count = 0;
            for (int i = 0; i < countStr2; i++)
            {
                for (int j = 0; j < countStr1; j++)
                {
                    if (str2[i] == str[j])
                        count++;
                }
            }
            if (count == countStr2)
                Console.WriteLine($"рядок {str1} містить всі символи {str2}");
            else Console.WriteLine($"рядок {str1} не містить всі символи {str2}");
        }
        // функція яка заміняє всі символи стр1 рівні символам стр2 на #
        static void ChangeSameSymbols(string str1, string str2, int countStr1, int countStr2)
        {
            char[] char1 = str1.ToCharArray();
            for (int i = 0; i < countStr2; i++)
            {
                for (int j = 0; j < countStr1; j++)
                {
                    if (str2[i] == str1[j])
                        char1[j] = '#';
                }
            }
            str1 = new string(char1);
            Console.WriteLine($"Замінивши всі символи в Str1 рівні символам з Str2 на символ # отримали: {str1}");

        }
        //функція яка видаляє одинакові символи
        static string RemoveDuplicateChars(string str)
        {
            string result = "";
            foreach (char value in str)
                if (result.IndexOf(value) == -1)
                    result += value;
            return result;
        }
        // функція для перевірки скільки разів символи с стр2 зустрічаються в стр1
        static void CountOfSameSymbols(string str1, string str2, int countStr1, int countStr2)
        {
            int count = 0;
            for (int i = 0; i < countStr1; i++)
            {
                for (int j = 0; j < countStr2; j++)
                {
                    if (str1[i] == str2[j])
                        count++;
                }
            }
            Console.WriteLine($"Cимволи з Str2 зустрічаються в Str1 {count} рвзів");
        }

        static void Main(string[] args)
        {
            string str1, str2;
            
            Console.WriteLine("Введіть перший рядок:");
            str1 = Console.ReadLine();
            Console.WriteLine("Введіть другий рядок:");
            str2 = Console.ReadLine();
            int countStr1 = CountSymbolOfStr(str1);
            int countStr2 = CountSymbolOfStr(str2);
            CheckSymbols(str1, str2, countStr1, countStr2);
            ChangeSameSymbols(str1, str2, countStr1, countStr2);
            CountOfSameSymbols(str1, str2, countStr1, countStr2);
        }
    }
}
