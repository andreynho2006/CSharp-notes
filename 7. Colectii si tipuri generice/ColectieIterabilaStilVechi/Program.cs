using System;
using System.Collections;

namespace ColectieIterabilaStilVechi
{
    class MyCollection : IEnumerable
    {
        private int[] continut = { 1, 2, 3 };
        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(this);
        }

        private class MyEnumerator : IEnumerator
        {
            private MyCollection mc;
            private int index = -1;

            public MyEnumerator(MyCollection mc)
            {
                this.mc = mc;
            }

            public object Current
            {
                get
                {
                    if (index < 0 || index >= mc.continut.Length)
                    {
                        return null;
                    }
                    else return mc.continut[index];
                }
            }
            public bool MoveNext()
            {
                index++;
                return index < mc.continut.Length;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
