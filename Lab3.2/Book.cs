using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2
{
    internal class Book
    {
        private string book = "";
        public void SetBook(string book)
        {
            this.book = book;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Book:{book}");
        }
    }
}
