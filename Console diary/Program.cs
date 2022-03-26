using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Разработать ежедневник.
            /// В ежедневнике реализовать возможность 
            /// - создания записей
            /// - удаления записей
            /// - редактирования записей
            /// 
            /// В отдельной записи должно быть не менее пяти полей
            /// 
            /// Реализовать возможность 
            /// - Загрузки даннах из файла
            /// - Выгрузки даннах в файл
            /// - Добавления данных в текущий ежедневник из выбранного файла
            /// - Импорт записей по выбранному диапазону дат
            /// - Упорядочивания записей ежедневника по выбранному полю

            string path = @"dates.csv";
            string path2 = @"dates1.csv";

            Repository1 rep = new Repository1(path);
            Repository1 rep1 = new Repository1(path2);

            
            rep.PrintToConsole();
            Console.ReadKey();

            rep.Change(3, new DailyPlanner(new DateTime(1700, 3, 1), "Kkk", "ddddd", 88888, "ddddd"));
            rep.PrintToConsole();
            Console.ReadKey();

            rep.Add(new DailyPlanner(new DateTime(1700, 2, 19), "Иван", "Иванов", 8_945_999_99_99, "Вот так"));
            rep.PrintToConsole();
            rep.Sort_by_Date();
            rep.PrintToConsole();

            Console.ReadKey();

            rep.Diapazon(new DateTime(2000, 1, 1), new DateTime(2020, 1, 1));
            rep.Upload_Files(rep1);
            Console.ReadKey();


        }
    }
}
