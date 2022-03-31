using System;
using System.Collections.Generic;
using System.Text;

namespace _31._03._2022task.Models
{
    class Word : IPrintableFile
    {
        public int WordCount { get; set; }
        public string FUllName { get; set; }
        public Word(string fullNAme,int wordCount)
        {
            WordCount = wordCount;FUllName = fullNAme;
        }

        public void Print()
        {
            Console.WriteLine($"{FUllName} --> Word  printed , WordCount : {WordCount}");
        }
    }
}
