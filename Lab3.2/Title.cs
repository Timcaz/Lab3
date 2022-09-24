using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2
{
    internal class Title
    {
        private string title = "";
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Book:{title}");
        }
    }
}
