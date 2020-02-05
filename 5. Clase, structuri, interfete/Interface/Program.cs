using System;

namespace Interface
{
   interface ISavable
    {
        void Read();
        void Write();
    }

    public class TextFile : ISavable
    {
        public virtual void Read()
        {
            Console.WriteLine("TextFile.Read()");
        }
        public void Write()
        {
            Console.WriteLine("TextFile.Write()");
        }
    }

    public class CSVFile : TextFile
    {
        public override void Read()
        {
            Console.WriteLine("CSV.Read()");
        }
        public new void Write()
        {
            Console.WriteLine("CSV.Write()");
        }
    }

    public class Demo
    {
        static void Main()
        {
            Console.WriteLine("\nTextFile reference to CSVFile");
            TextFile textRef = new CSVFile();
            textRef.Read();
            textRef.Write();
            Console.WriteLine("\nISavable reference to CSVFile");
            ISavable savableRef = textRef as ISavable; // as ISavable este redundant dar permite verificarea de la pasul urmator
            if(savableRef != null)
            {
                savableRef.Read();
                savableRef.Write();
            }
            Console.WriteLine("\nCSVFile reference to CSVFile");
            CSVFile csvRef = textRef as CSVFile;
            if(csvRef != null)
            {
                csvRef.Read();
                csvRef.Write();
            }
        }
    }
}
