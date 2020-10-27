using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1Var1
{
    // Определить класс Person, который имеет
    public class Person
    {
        // закрытое поле типа string, в котором хранится имя;
        private string name;

        // закрытое поле типа string, в котором хранится фамилия;
        private string surname;

        // закрытое поле типа System.DateTime для даты рождения.
        private DateTime dateOfBirth;

        //  свойство типа string для доступа к полю с именем; 
        public string Name 
        { 
            get 
            {
                return name;
            } 
        }

        //  свойство типа string для доступа к полю с фамилией;
        public string Surname
        {
            get
            {
                return surname;
            }
        }

        //  свойство типа DateTime для доступа к полю с датой рождения;
        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
        }

        public int YearOfBirth
        {
            get
            {
                return dateOfBirth.Year;
            }
            set
            {
                dateOfBirth = 
                    new DateTime(
                        value, 
                        dateOfBirth.Month, 
                        dateOfBirth.Day);
            }
        }

        // В классе Person определить конструкторы:

        // конструктор c тремя параметрами типа string, string, DateTime для
        // инициализации всех полей класса;
        public Person(string name, string surname, DateTime dateOfBirth)
        {
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
        }

        // конструктор без параметров, инициализирующий все поля класса
        // некоторыми значениями по умолчанию.
        public Person()
        {
            name = "Иван";
            surname = "Иванов";
            dateOfBirth = DateTime.Now;
        }

        // В классе Person определить

        //перегруженную(override) версию виртуального метода string ToString() для
        //формирования строки со значениями всех полей класса;
        public override string ToString()
        {
            return $"Имя: {name}, Фамилия: {surname}, год рождения: {dateOfBirth.ToString()}";
        }

        // виртуальный метод string ToShortString(), который возвращает строку,
        // содержащую только имя и фамилию.
        public virtual string ToShortString()
        {
            return $"Имя: {name}, фамилия: {surname}";
        }
    }
}
