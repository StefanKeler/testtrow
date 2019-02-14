using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                StreamWriter sr = new StreamWriter("");
                sr.Write("");
                // some exception occurs here 
                File.SetAttributes("", FileAttributes.Hidden);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            Console.WriteLine("Hello World!");
        }
    }
}
