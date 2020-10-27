using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1Var1
{
    // Определить класс Student, который имеет 
    public class Student : Person
    {
        // закрытое поле типа Education для информации о форме обучения;
        private Education education;
   
        // закрытое поле типа int для номера группы;
        private int groupNumber;

        // закрытое поле типа Exam *+ для информации об экзаменах, которые сдал студент.
        private Exam[] passedExams;

        //  В классе Student определить свойства c методами get и set:

        //  свойство типа Education для доступа к полю с формой обучения;
        public Education StudentEducation
        {
            get
            {
                return education;
            }
        }

        //  свойство типа int для доступа к полю с номером группы;
        public int GroupNumber
        {
            get
            {
                return groupNumber;
            }
        }

        //  свойство типа Exam[] для доступа к полю со списком экзаменов.
        public Exam[] Exams
        {
            get
            {
                return passedExams;
            }
        }

        // свойство типа double (только с методом get), в котором вычисляется
        // средний балл как среднее значение оценок в списке сданных экзаменов;
        public double AverageMark
        {
            get
            {
                int average = 0;
                for (int mark = 0; mark < passedExams.Length; mark++)
                {
                    average += Exams[mark].Grade;
                }

                if (Exams.Length == 0)
                    return 0;

                return average/Exams.Length;
            }
        }


        // конструктор c параметрами типа Person, Education, int для инициализации
        // соответствующих полей класса;
        public Student(
            string name, 
            string surname, 
            DateTime dateOfBirth, 
            Education education, 
            int groupNumber, 
            Exam[] passedExams) : base(name, surname, dateOfBirth)
        {
            this.education = education;
            this.groupNumber = groupNumber;
            this.passedExams = passedExams;
        }

        //конструктор без параметров, инициализирующий поля класса значениями по умолчанию.
        public Student() : base("Иван", "Иванов", DateTime.Now)
        {
            education = Education.Bachelor;
            groupNumber = 0;
            passedExams = new Exam[0];
        }

        // метод void Add Exams(params Exam[] ) для добавления элементов в
        // список экзаменов
        public void AddExams(Exam exam)
        {
            Exam[] newPassedExams = new Exam[passedExams.Length + 1];

            for (int passedExam = 0; passedExam < passedExams.Length; passedExam++)
            {
                newPassedExams[passedExam] = passedExams[passedExam];
            }

            newPassedExams[newPassedExams.Length - 1] = exam;
            passedExams = newPassedExams;
        }

        // перегруженную версию виртуального метода string ToString() для
        // формирования строки со значениями всех полей класса, включая список
        // экзаменов;
        public override string ToString()
        {
            string info = base.ToString();

            info += $"\r\nСтепень: {education}, номер группы: {groupNumber} \r\n";

            for (int exam = 0; exam < passedExams.Length; exam++)
            {
                info += "Экзамен: " + passedExams[exam].ToString() + "\r\n";
            }

            info += $" Средняя оценка: {AverageMark}";

            return info;
        }

        // виртуальный метод string ToShortString(), который формирует строку со
        // значениями всех полей класса без списка экзаменов, но со значением
        // среднего балла
        public override string ToShortString()
        {
            string info = base.ToString();

            info += $"Степень: {education}, номер группы: {groupNumber}";

            info += $"Средняя оценка: {AverageMark}";

            return info;
        }
    }
}
