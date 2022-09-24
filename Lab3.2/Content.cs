using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2
{
    internal class Content
    {
        private string content = "";
        public void SetContent(string content)
        {
            this.content = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Book:{content}");
        }
    }
}
