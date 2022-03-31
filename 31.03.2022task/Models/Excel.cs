using System;
using System.Collections.Generic;
using System.Text;

namespace _31._03._2022task.Models
{
    class Excel : IPrintableFile
    {
        public int ColumnCount { get; set; }
        public int RowCount { get; set; }
        public string FUllName { get; set; }
        public Excel(string fullName,int columnCount , int rowCount)
        {
            ColumnCount = columnCount;RowCount = rowCount; FUllName = fullName;
        }

        public void Print()
        {
            Console.WriteLine($"{FUllName} -->Excel printed , RowCount : {RowCount} , ColmnCount : {ColumnCount} ");
        }
    }
}
