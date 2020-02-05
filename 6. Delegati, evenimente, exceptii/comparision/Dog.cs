using System;
namespace comparision
{
    public class Dog
    {
        private int weight;

        public Dog(int weight)
        {
            this.weight = weight;
        }

        // ordinea este data de greutate
        public static Comparision WhichDogComesFirst(Object o1, Object o2)
        {
            Dog d1 = o1 as Dog;
            Dog d2 = o2 as Dog;
            return d1.weight > d2.weight ? Comparision.TheSecondComesFirst : Comparision.TheFirstComesFirst;
        }

        // pentru afisarea greutatii uni caine
        public override string ToString()
        {
            return weight.ToString();
        }
    }
}
