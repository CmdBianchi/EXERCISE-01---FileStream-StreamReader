using System;
using System.IO;
namespace EXERCISE_01___FILE__FILEINFO__IOexception {
    //-----> START
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch(IOException e) {
                Console.WriteLine("An error aciirred");
                Console.WriteLine(e.Message);
                
            }
            finally {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}
