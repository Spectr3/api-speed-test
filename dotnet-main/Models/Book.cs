namespace dotnet_main.Models
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public Author Author { get; set; }

        public Book(string iSBN, string title, double price, Author author)
        {
            ISBN = iSBN;
            Title = title;
            Price = price;
            Author = author;
        }
    }
}