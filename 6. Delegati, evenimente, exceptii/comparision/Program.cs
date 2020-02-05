using System;

namespace comparision
{

    // rezultatul unei comparati intre 2 obiecte va fi de tipul Comparision
    //definit de utilizator
    public enum Comparision
    {
        TheFirstComesFirst = 0, // primul obiect este primul in ordinea sortarii
        TheSecondComesFirst = 1 // al doilea obiect din colectie este primul in ordinea sortarii
    }

    // delegatul(tipul de metoda care realizeaza compararea)
    // declarare de delegat
    public delegate Comparision WhichIsFirst(object obj1, object obj2);

    // declarare clasa Pair
    public class Pair
    {
        // tabloul care contine cele 2 obiecte
        private object[] thePair = new object[2];

        // constructorul primeste cele 2 obiecte continute
        public Pair( object firstObject, object secondObject)
        {
            thePair[0] = firstObject;
            thePair[1] = secondObject;
        }

        // metoda publkica pentru ordonarea celor 2 obiecte dupa orice criteriu
        public void Sort( WhichIsFirst theDelegatedMethod )
        {
            if(theDelegatedMethod(thePair[0], thePair[1]) == Comparision.TheSecondComesFirst)
            {
                object tmp = thePair[0];
                thePair[0] = thePair[1];
                thePair[1] = tmp;
            }
        }

        // metoda ce permite tiparirea perechii curente
        // se foloseste de polimorfism
        public override string ToString()
        {
            return thePair[0].ToString() + " , " + thePair[1].ToString();
        }
    }


    class Demo
    {
        public static void Main(string[] args)
        {
            // creeaza cate 2 obiecte de tip student si dog si containerii corespunzatori
            Student Simona = new Student("Simona");
            Student Andrei = new Student("Andrei");
            
            Dog Milo = new Dog(10);
            Dog Fred = new Dog(5);
            Pair studentPair = new Pair(Simona, Andrei);
            Pair dogPair = new Pair(Milo, Fred);

            Console.WriteLine("StudentPair\t: {0}", studentPair);
            Console.WriteLine("Dog\t: {0}", dogPair);

            // sortare folosind metoda delegate
            studentPair.Sort(Student.WhichStudentComesFirst);
            Console.WriteLine("Dupa sortarea pe studentPair\t: {0}", studentPair.ToString());
            dogPair.Sort(Dog.WhichDogComesFirst);
            Console.WriteLine("Dupa sortarea pe dogPair\t: {0}", dogPair.ToString());
        }
    }
}
