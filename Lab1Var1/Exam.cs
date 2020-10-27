using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1Var1
{
    /// <summary>
    /// Определить класс Exam, который имеет три открытых автореализуемых 
    /// свойства, доступных для чтения и записи:
    /// </summary>
    public class Exam
    {
        /// <summary>
        /// свойство типа string, в котором хранится название предмета; 
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// свойство типа int, в котором хранится оценка;
        /// </summary>
        public int Grade { get; set; }
        /// <summary>
        /// свойство типа System.DateTime для даты экзамена
        /// </summary>
        public DateTime PassDate { get; set; }

        //
        // В классе Exam определить:
        //

        /// <summary>
        /// конструктор с параметрами типа string, int и DateTime для инициализации всех свойств класса; 
        /// </summary>
        public Exam(string name, int grade, DateTime passDate)
        {
            Name = name;
            Grade = grade;
            PassDate = passDate;
        }

        /// <summary>
        /// конструктор без параметров, инициализирующий все свойства класса некоторыми значениями по умолчанию;
        /// </summary>
        public Exam()
        {
            Name = ".Net";
            Grade = -1;
            PassDate = DateTime.Now;
        }

        /// <summary>
        /// перегруженную(override) версию виртуального метода string ToString() для
        /// формирования строки со значениями всех свойств класса.
        /// </summary>
        public override string ToString()
        {
            return $"Название предмета: {Name}, оценка: {Grade}, дата сдачи: {PassDate.ToShortDateString()}";
        }
    }
}
