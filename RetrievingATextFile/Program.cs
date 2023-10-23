using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingATextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ans = File.Exists(@"C:\\Users\\tabib\\source\\file2.txt");
            if (ans)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(@"C:\\Users\\tabib\\source\\file2.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr = null;
                    try
                    {
                        sr = new StreamReader(fs);
                        string data = sr.ReadToEnd();
                        Console.WriteLine(data);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        sr.Close();
                        fs.Close();
                        sr.Dispose();
                        fs.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}

