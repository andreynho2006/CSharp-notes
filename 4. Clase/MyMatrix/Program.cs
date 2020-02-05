using System;

namespace MyMatrix
{
    class MyMatrix
    {
        double[,] matrix;
        public MyMatrix( int rows, int cols)
        {
            matrix = new double[rows, cols];
        }

        public double this[int i, int j]
        {
            get
            {
                return matrix[i, j];
            }
            set
            {
                matrix[i, j] = value;
            }
        }

        public int RowsNo
        {
            get
            {
                return matrix.GetLength(0);
            }
        }

        public int ColsNo
        {
            get
            {
                return matrix.GetLength(1);
            }
        }
    }



    class MainClass
    {
        public static void Main(string[] args)
        {
            MyMatrix m = new MyMatrix(12, 12);
            Console.WriteLine("Lines: {0}", m.RowsNo.ToString());
            Console.WriteLine("Columns: {0}", m.ColsNo.ToString());
            for(int i=0; i<m.RowsNo; i++)
            {
                for(int j = 0; j<m.ColsNo; j++)
                {
                    m[i, j] = i + j;
                }
            }
            for(int i=0; i<m.RowsNo; i++)
            {
                for(int j=0; j<m.ColsNo; j++)
                {
                    Console.Write(m[i, j].ToString() + "\t");
                }
                Console.WriteLine("\t");
            }
        }
    }
}
