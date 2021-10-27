using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hwork8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\!ОБУЧЕНИЕ\Проекты\Задание 8. Работа с файловой системой\Hwork8";
            if (Directory.Exists(path))
            {
                string[] subdirectories = Directory.GetDirectories(path);
                foreach (string s in subdirectories)
                {
                    Console.WriteLine("Подкаталоги");
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                string[] files = Directory.GetFiles(path);
                foreach (string p in files)
                {
                    Console.WriteLine("Файлы");
                    Console.WriteLine(p);
                }

            }
            Console.ReadKey();
        }
    }
}
