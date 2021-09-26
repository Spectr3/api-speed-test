using System.Collections.Generic;
using dotnet_main.Models;
using dotnet_main.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_main.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly BookRepository _bookRepository;
        
        public BooksController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public IList<Book> Get()
        {
            return _bookRepository.GetBooks();
        }
    }
}