using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    /// <summary>
    /// Репозиторий
    /// </summary>
    struct Repository1
    {
        int index;
        string[] title;
        private string path;

        /// <summary>
        /// База данных дней
        /// </summary>
        private DailyPlanner[] Dates;

        public Repository1(string Path)
        {
            this.path = Path;
            this.index = 0;
            this.title = new string[0];
            this.Dates = new DailyPlanner[1];

            this.Download();
        }

        /// <summary>
        /// Получение и печать дня
        /// </summary>
        /// <param name="index">Список дней</param>
        /// <returns></returns>
        public string this[int index]
        {
            get { return this.Dates[index].Print(); }
        }

        /// <summary>
        /// Увеличение списка в 2 раза
        /// </summary>
        /// <param name="Flag">Показатель, хвататет ли места</param>
        private void Resize(bool Flag)
        {
            if (Flag)
            {
                Array.Resize(ref this.Dates, this.Dates.Length * 2);
            }
        }

        /// <summary>
        /// Добавление записи
        /// </summary>
        /// <param name="ConcreteDate">День</param>
        public void Add(DailyPlanner ConcreteDate)
        {
            this.Resize(index >= this.Dates.Length);
            this.Dates[index] = ConcreteDate;
            this.index++;
        }

        /// <summary>
        /// Изменение даты 
        /// </summary>
        /// <param name="a">Номер записи в книге</param>
        /// <param name="ConcerateDate">Исправленная информация</param>
        public void Change(int a, DailyPlanner ConcerateDate)
        {
            a -= 1;
            this.Dates[a] = ConcerateDate; 
        }

        /// <summary>
        /// Удаление записи
        /// </summary>
        /// <param name="a">Номер записи в книге</param>
        public void Delete(int a)
        {
            a -= 1;
            for (int i = a; i < this.index; i++)
            {
                this.Dates[a] = this.Dates[a + 1]; 
            }

            this.index -= 1;
        }

        /// <summary>
        /// Вывод записей из выбранного диапазона дат
        /// </summary>
        /// <param name="a">От какой даты</param>
        /// <param name="b">До какой даты</param>
        public void Diapazon(DateTime a, DateTime b)
        {
            for (int i = 0; i < index; i++)
            {
                if(this.Dates[i].date >= a && this.Dates[i].date <= b)
                {
                    Console.WriteLine(this.Dates[i].Print());
                }
            }
            Console.WriteLine(Count);
        }

        /// <summary>
        /// Сортировка по дате
        /// </summary>
        public void Sort_by_Date()
        {
            DailyPlanner sort = new DailyPlanner(new DateTime(1111, 11, 11), string.Empty, string.Empty, 0, string.Empty);
            for (int i = 0; i < this.index; i++)
            {
                for (int j = 0; j < this.index; j++)
                {
                    if (this.Dates[j].date > this.Dates[i].date)
                    {
                        sort = this.Dates[i];
                        this.Dates[i] = this.Dates[j];
                        this.Dates[j] = sort;
                        
                    }
                }
            }
        }

        /// <summary>
        /// Сортировка по Имени
        /// </summary>
        public void Sort_by_FirstName()
        {
            DailyPlanner sort = new DailyPlanner(new DateTime(1111, 11, 11), string.Empty, string.Empty, 0, string.Empty);
            for (int i = 0; i < this.index; i++)
            {
                for (int j = 0; j < this.index; j++)
                {
                    int x = 0;
                    while(Convert.ToInt32(this.Dates[j].firstName[x]) == Convert.ToInt32(this.Dates[i].firstName[x]))
                    {
                        x++;
                        if (x >= this.Dates[j].firstName.Length)
                        {
                            x--;
                            break;
                        }
                    }

                    if (Convert.ToInt32(this.Dates[j].firstName[x]) > Convert.ToInt32(this.Dates[i].firstName[x]))
                    {
                        sort = this.Dates[i];
                        this.Dates[i] = this.Dates[j];
                        this.Dates[j] = sort;

                    }
                }
            }
        }

        /// <summary>
        /// Сортировка по фамилии
        /// </summary>
        public void Sort_by_LastName()
        {
            DailyPlanner sort = new DailyPlanner(new DateTime(1111, 11, 11), string.Empty, string.Empty, 0, string.Empty);
            for (int i = 0; i < this.index; i++)
            {
                for (int j = 0; j < this.index; j++)
                {
                    int x = 0;
                    while (Convert.ToInt32(this.Dates[j].lastName[x]) == Convert.ToInt32(this.Dates[i].lastName[x]))
                    {
                        x++;
                        if (x >= this.Dates[j].lastName.Length)
                        {
                            x--;
                            break;
                        }
                    }

                    if (Convert.ToInt32(this.Dates[j].lastName[x]) > Convert.ToInt32(this.Dates[i].lastName[x]))
                    {
                        sort = this.Dates[i];
                        this.Dates[i] = this.Dates[j];
                        this.Dates[j] = sort;

                    }
                }
            }
        }

        /// <summary>
        /// Сортировка по номеру телефона
        /// </summary>
        public void Sort_by_Number()
        {
            DailyPlanner sort = new DailyPlanner(new DateTime(1111, 11, 11), string.Empty, string.Empty, 0, string.Empty);
            for (int i = 0; i < index; i++)
            {
                for (int j = 0; j < index; j++)
                {
                    if(this.Dates[j].number > this.Dates[i].number)
                    {
                        sort = this.Dates[i];
                        this.Dates[i] = this.Dates[j];
                        this.Dates[j] = sort;
                    }
                }
            }
        }

        /// <summary>
        /// Сортировка по цели
        /// </summary>
        public void Sort_by_Aim()
        {
            DailyPlanner sort = new DailyPlanner(new DateTime(1111, 11, 11), string.Empty, string.Empty, 0, string.Empty);
            for (int i = 0; i < this.index; i++)
            {
                for (int j = 0; j < this.index; j++)
                {
                    int x = 0;
                    while (Convert.ToInt32(this.Dates[j].plans[x]) == Convert.ToInt32(this.Dates[i].plans[x]))
                    {
                        x++;
                        if (x >= this.Dates[j].plans.Length)
                        {
                            x--;
                            break;
                        }
                    }

                    if (Convert.ToInt32(this.Dates[j].plans[x]) > Convert.ToInt32(this.Dates[i].plans[x]))
                    {
                        sort = this.Dates[i];
                        this.Dates[i] = this.Dates[j];
                        this.Dates[j] = sort;

                    }
                }
            }
        }

        /// <summary>
        /// Дозапись файла данными из другого файла
        /// </summary>
        /// <param name="rep">Откуда берутся данные</param>
        public void Upload_Files(Repository1 rep)
        {
            using (StreamWriter sw = new StreamWriter(this.path, true))
            {
                for (int i = 0; i < rep.Count; i++)
                {
                    sw.WriteLine($"{rep.Dates[i].date.ToShortDateString()},{rep.Dates[i].firstName},{rep.Dates[i].lastName},{rep.Dates[i].number},{rep.Dates[i].plans}");
                }
            }
        }

        /// <summary>
        /// Считывание данных с файла и передача этих значение в приложение
        /// </summary>
        public void Download()
        {
            using (StreamReader sr = new StreamReader(this.path))
            {
                title = sr.ReadLine().Split(',');

                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split(',');

                    Add(new DailyPlanner(DateTime.Parse(args[0]), Convert.ToString(args[1]), Convert.ToString(args[2]), Convert.ToUInt64(args[3]), Convert.ToString(args[4])));
                }
            }
        }

        /// <summary>
        /// Загрузка данных в файл(Перезаписывание, береёт конечный файл до выполнения метода)
        /// </summary>
        /// <param name="rep"></param>
        public void Upload()
        {
            using (StreamWriter sw = new StreamWriter(this.path, false))
            {
                sw.WriteLine($"{this.title[0]},{this.title[1]},{this.title[2]},{this.title[3]},{this.title[4]}");

                for (int i = 0; i < index; i++)
                {
                    sw.WriteLine(this.Dates[i].PrintToFile());
                }
            }
        }

        /// <summary>
        /// Вывод списка на экран
        /// </summary>
        public void PrintToConsole()
        {
            Console.WriteLine($"{this.title[0],20} {this.title[1],20} {this.title[2],20} {this.title[3],20} {this.title[4],20}");

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(this.Dates[i].Print());
            }
            Console.WriteLine(Count);
        }

        /// <summary>
        /// Количество дней
        /// </summary>
        public int Count { get { return this.index; } }

    }
}
