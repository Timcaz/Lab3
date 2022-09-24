using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2
{
    internal class Author
    {
        private string author = "";
        public void SetAuthor(string author)
        {
            this.author = author;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Author:{author}");
        }
    }
}
