using System;
namespace comparision
{
    public class Student
    {
        private string name;

        public Student(string name)
        {
            this.name = name;
        }

        // studentii sunt ordonati alfabetic
        public static Comparision WhichStudentComesFirst(Object o1, Object o2)
        {
            Student s1 = o1 as Student;
            Student s2 = o2 as Student;
            return (String.Compare(s1.name, s2.name) < 0 ? Comparision.TheFirstComesFirst : Comparision.TheSecondComesFirst);
        }

        // pentru afisarea numelui uni student
        public override string ToString()
        {
            return name;
        }
    }
}
