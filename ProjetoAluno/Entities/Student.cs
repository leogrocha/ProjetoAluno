using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAluno.Entities
{
    class Student
    {
        public  int Code { get; set; }
        public  string Name { get; set; }
        public  string Matter { get; set; }
        public double Note1 { get; set; }
        public double Note2 { get; set; }
        public double Note3 { get; set; }
        public double Note4 { get; set; }

        public Student()
        {

        }

        public Student(int code, string name, string matter, double note1, double note2, double note3, double note4)
        {
            Code = code;
            Name = name;
            Matter = matter;
            Note1 = note1;
            Note2 = note2;
            Note3 = note3;
            Note4 = note4;
        }

        public double Average()
        {
            return (Note1 + Note2 + Note3 + Note4) / 4;
        }

        public void Recuperacao(double finalGrade)
        {
            if (finalGrade >= 6.00)
                Console.WriteLine("Approved!");
            else
                Console.WriteLine("Disapproved!");
        }
    }
}
