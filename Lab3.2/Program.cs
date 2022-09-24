namespace Lab3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Title title = new Title();
            Author author = new Author();
            Content content = new Content();

            Console.Write("Book:");
            book.SetBook(Console.ReadLine());
            Console.Write("Title:");
            title.SetTitle(Console.ReadLine());
            Console.Write("Author:");
            author.SetAuthor(Console.ReadLine());
            Console.Write("Content:");
            content.SetContent(Console.ReadLine());
            Console.WriteLine("");

            book.Show();
            title.Show();
            author.Show();
            content.Show();
        }
    }
}