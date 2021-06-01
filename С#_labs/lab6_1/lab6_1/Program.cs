using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab6_1
{
    class Program    //ого этот буллшит не нагуглился, посмотримс че у нас тут...
    {
        static char[] vowels = { 'а', 'и', 'е', 'ё', 'о', 'у', 'ы', 'э', 'ю', 'я' };
        static char[] consonants = { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ъ' };

        static int consonants_cnt;
        static int vowels_cnt;
        static void Main(string[] args)
        {
            char[] chars;
            var lines = File.ReadAllLines("input.txt");

            for (int row = 0; row <= lines.Length - 1; row += 1)    //foreach это не writtable дерьмоцикл как оказалось, поэтому тут for, чтобы записать chars
            {
                chars = lines[row].ToLower().ToCharArray();
                foreach (char ch in chars)
                {
                    foreach (char ch_c in consonants)
                        if (ch == ch_c)
                            consonants_cnt++;
                }
                foreach (char ch in chars)
                {
                    foreach (char ch_v in vowels)
                        if (ch == ch_v)
                            vowels_cnt++;   //-вечер, всем спасибо за просмотр
                }
            }
            Console.WriteLine("Согласных в файле: {0}\nГласных в файле: {1}", consonants_cnt, vowels_cnt);
            Console.ReadKey();
        }
    }
}