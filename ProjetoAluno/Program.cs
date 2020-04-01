using System;
using System.Globalization;
using ProjetoAluno.Entities;

namespace ProjetoAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter student data");
            Console.Write("Code: ");
            int code = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Matter: ");
            string matter = Console.ReadLine();
            Console.Write("Note 1: ");
            double note1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Note 2: ");
            double note2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Note 3: ");
            double note3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Note 4: ");
            double note4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Student s1 = new Student(code, name, matter, note1, note2, note3, note4);

            if (s1.Average() >= 6.00)
                Console.WriteLine("Approved!");
            else if (s1.Average() < 6.00 && s1.Average() >= 4.50)
            {
                Console.WriteLine();
                Console.WriteLine("Final Evaluation!");
                Console.WriteLine();
                Console.Write("Enter Final Grade: ");
                double finalGrade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                s1.Recuperacao(finalGrade);
            }
            else
                Console.WriteLine("Disapproved");

            
            

        }
    }
}
