using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    /// <summary>
    /// Ежедневник
    /// </summary>
    struct DailyPlanner
    {
        #region Поля

        /// <summary>
        /// "Дата"
        /// </summary>
        public DateTime date;

        /// <summary>
        /// "Имя"
        /// </summary>
        public string firstName;

        /// <summary>
        /// "Фамилия"
        /// </summary>
        public string lastName;

        /// <summary>
        /// "Номер"
        /// </summary>
        public ulong number;

        /// <summary>
        /// "Цель встречи"
        /// </summary>
        public string plans;

        #endregion

        #region Свойства

        ///// <summary>
        ///// Дата
        ///// </summary>
        //public DateTime Date { get; set; }

        ///// <summary>
        ///// Имя человека, с которым встреча
        ///// </summary>
        //public string FirstName { get; set; }

        ///// <summary>
        ///// Фамилия
        ///// </summary>
        //public string LastName { get; set; }

        ///// <summary>
        ///// Номер
        ///// </summary>
        //public uint Number { get; set; }

        ///// <summary>
        ///// Цель встречи
        ///// </summary>
        //public string Plans { get; set; }

        #endregion

        #region Методы

        /// <summary>
        /// Вывод данных на экран
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"Дата: {date.ToShortDateString(),14} Имя: {firstName,15} Фамилия: {lastName,11} Номер: {number,13} Цель встречи: {plans,6}";
        }

        /// <summary>
        /// Запись в файл
        /// </summary>
        /// <returns></returns>
        public string PrintToFile()
        {
            return $"{date.ToShortDateString()},{firstName},{lastName},{number},{plans}";
        }

        #endregion

        #region Конструкторы

        /// <summary>
        /// Конструктор для записи данных
        /// </summary>
        /// <param name="Date">Дата</param>
        /// <param name="FirstName">Имя человека, с которым встреча</param>
        /// <param name="LastName">Фамилия</param>
        /// <param name="Number">Номер</param>
        /// <param name="Plans">Цель Встречи</param>
        public DailyPlanner(DateTime Date, string FirstName, string LastName, ulong Number, string Plans)
        {
            this.date = Date;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.number = Number;
            this.plans = Plans;
        }

        /// <summary>
        /// Конструктор для записи данных с 4-мя параметрами
        /// </summary>
        /// <param name="FirstName">Имя</param>
        /// <param name="LastName">Фамилия</param>
        /// <param name="Number">Номер</param>
        /// <param name="Plans">Цель встречи</param>
        public DailyPlanner(string FirstName, string LastName, ulong Number, string Plans) :
            this(new DateTime(1999, 1, 1), FirstName, LastName, Number, Plans)
        { }

        #endregion
    }
}
