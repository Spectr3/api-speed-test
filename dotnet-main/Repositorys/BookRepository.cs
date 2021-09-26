using System.Collections.Generic;
using dotnet_main.Models;

namespace dotnet_main.Repositorys
{
    public class BookRepository
    {
        private List<Book> _books { get; set; }

        public BookRepository()
        {
            _books = new List<Book>();
            _books.Add(new Book("9780141187761", "1984", 8.99, new Author("George", "Orwell")));
            _books.Add(new Book("9781528718820", "Animal Farm", 9.99, new Author("George", "Orwell")));
            _books.Add(new Book("0571191479", "Lord of the Flies", 8.99, new Author("William", "Golding")));
            _books.Add(new Book("9780099549482", "To Kill and Mockingbird", 6.99, new Author("Harper", "Lee")));
            _books.Add(new Book("0007635745", "The Code Book", 7.99, new Author("Simon", "Singh")));
        }

        public List<Book> GetBooks()
        {
            return _books;
        }
    }
}