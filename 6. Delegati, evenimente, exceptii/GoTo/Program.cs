using System;
using System.IO;

namespace GoTo
{
    class Retry
    {
        public static void Main()
        {
            int attempts = 0;
            int maxAttempts = 3;

        GetFile:
            Console.Write("\n[attempt #{0}] Specify file to oen/read: ", attempts + 1);
            string fileName = Console.ReadLine();
            try
            {
                StreamReader sr = new StreamReader(fileName);
                Console.WriteLine();
                string s;
                while(null != ( s = sr.ReadLine()))
                {
                    Console.WriteLine(s);
                }
                sr.Close();
                attempts = 0;
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                if(++attempts < maxAttempts)
                {
                    Console.Write("Do you want to select another file: ");
                    string response = Console.ReadLine();
                    response = response.ToUpper();
                    if (response == "Y") goto GetFile;
                }
                else
                {
                    Console.Write("You have exceeded the maximum retry limit ({0})", maxAttempts);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
