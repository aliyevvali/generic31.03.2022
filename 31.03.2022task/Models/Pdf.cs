using System;
using System.Collections.Generic;
using System.Text;

namespace _31._03._2022task.Models
{
    class Pdf : IPrintableFile
    {
        public string FUllName { get; set; }
        public int PageCount { get; set; }
        public Pdf(string fullNAme, int pageCount)
        {
            PageCount = pageCount;FUllName = fullNAme;
        }

        public void Print()
        {
            Console.WriteLine($"{FUllName} --> Pdf printed....   PageCount : {PageCount}");
        }
    }
}
