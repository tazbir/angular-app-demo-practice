using System.Collections.Generic;
using Angular_JS.Data.Models;

namespace Angular_JS.Data.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        void UpdateBook(int id, Book newBookObj);
        void DeleteBook(int id);
        void AddBook(Book newBook);
    }
}
