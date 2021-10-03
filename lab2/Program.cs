using System;

namespace lab2
{
    class Program
    {
        static void lab2F1(string str1, string str2)
        {
            string str = RemoveDuplicateChars(str1);
            int count = 0;
            for (int i = 0; i < str2.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (str2[i] == str[j])
                        count++;
                }
            }
            if (count == str2.Length)
                Console.WriteLine($"рядок {str1} містить всі символи {str2}");
            else Console.WriteLine($"рядок {str1} не містить всі символи {str2}");
        }
        static void lab2F2(string str1, string str2)
        {
            char[] char1 = str1.ToCharArray();
            for (int i = 0; i < str2.Length; i++)
            {
                for (int j = 0; j < str1.Length; j++)
                {
                    if (str2[i] == str1[j])
                        char1[j] = '#';
                }
            }
            str1 = new string(char1);
            Console.WriteLine($"Замінивши всі символи в Str1 рівні символам з Str2 на символ # отримали: {str1}");

        }
        static string RemoveDuplicateChars(string str)
        {
            string result = "";
            foreach (char value in str)
                if (result.IndexOf(value) == -1)
                    result += value;
            return result;
        }

        static void lab2F3(string str1, string str2)
        {
            int count = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
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
            lab2F1(str1, str2);
            lab2F2(str1, str2);
            lab2F3(str1, str2);
        }
    }
}
