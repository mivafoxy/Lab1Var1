using System;

namespace Lab1Var1
{
    class Program
    {
        /*
         * Создать один объект типа Student, преобразовать данные в текстовый
вид с помощью метода ToShortString() и вывести данные.
7. Присвоить значения всем определенным в типе Student свойствам,
преобразовать данные в текстовый вид с помощью метода ToString() и
вывести данные.
8. C помощью метода AddExams( params Exam*+ ) добавить элементы в
список экзаменов и вывести данные объекта Student, используя метод
ToString().
9. Сравнить время выполнения операций с элементами одномерного,
двумерного прямоугольного и двумерного ступенчатого массивов с
одинаковым числом элементов типа Exam.

         * */
        static void Main(string[] args)
        {
            Student firstStudent = new Student();
            Console.WriteLine(firstStudent.ToShortString());

            string name = "Петр";
            string surname = "Петров";
            DateTime yearOfBirth = new DateTime(1996, 03, 26);
            Education education = Education.SecondEducation;
            int groupNumber = 35;

            Exam math = new Exam("Матекматика", 5, DateTime.Now);
            Exam programming = new Exam("Программирование", 5, DateTime.Now);
            Exam philosophy = new Exam("Философия", 5, DateTime.Now);
            Exam russian = new Exam("Русский язык", 5, DateTime.Now);
            Exam english = new Exam("Английский язык", 5, DateTime.Now);

            Exam[] exam = new Exam[] { math, programming, philosophy, russian, english };

            Student secondStudent = new Student(name, surname, yearOfBirth, education, groupNumber, exam);
            Console.WriteLine(secondStudent.ToString());

            Exam terver = new Exam("Теория вероятности", 5, new DateTime(2019, 5, 25));
            secondStudent.AddExams(terver);

            Console.WriteLine(secondStudent.ToString());
        }

    }
}
