using System;
using System.Collections.Generic;
using System.Text;

namespace _31._03._2022task.Models
{
    internal class PrintFile<T>
        where T : IPrintableFile
    {
        public void Print(T file)
        {
            if (file is Word word )
            {
                word.Print();
            }
            else if (file is Excel excel)
            {
                excel.Print();
            }
            else if(file is Pdf pdf)
            {
                pdf.Print();
            }

        }


    }
}
