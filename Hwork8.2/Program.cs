using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hwork8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программно создайте текстовый файл и запишите в него 10 случайных чисел. Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
            string path = @"D:\!ОБУЧЕНИЕ\Проекты\Задание 8. Работа с файловой системой\Hwork8\Hwork8.2\CaseText.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            Random random = new Random();
            StreamWriter numbers = new StreamWriter(path, false);
            for (int i = 0; i < 10; i++)
            {
                int n = random.Next(-5, 5);// для себя задал параметры
                numbers.Write($"{n} ");
            }
            numbers.Close();
            StreamReader Num = new StreamReader(path);
            string S = Num.ReadLine();
            S = S.Trim();
            Console.WriteLine($"Числа:\n{S}");
            string[] P = S.Split(' ');
            int Sum = 0;
            for (int i = 0; i < P.Length; i++)
            {
                Sum += Convert.ToInt32(P[i]);
            }
            Console.WriteLine($"Сумма чисел:\n{Sum}");
            Console.ReadKey();
        }
    }
}
