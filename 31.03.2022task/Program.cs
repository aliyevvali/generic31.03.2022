using _31._03._2022task.Models;
using System;

namespace _31._03._2022task
{
    class Program
    {
        static void Main(string[] args)
        {
            Word a = new Word("Redme.txt", 100);

            PrintFile<IPrintableFile> print = new PrintFile<IPrintableFile>();
            print.Print(a);


        }
    }
}
