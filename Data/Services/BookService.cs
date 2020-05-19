﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular_JS.Data.Models;

namespace Angular_JS.Data.Services
{
    public class BookService:IBookService
    {
        public List<Book> GetAllBooks()
        {
           return Data.Books;
        }

        public Book GetBookById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(int id, Book newBookObj)
        {
            var oldBook = Data.Books.FirstOrDefault(n => n.Id == id);
            if (oldBook != null)
            {
                oldBook = newBookObj;
            }

        }

        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public void AddBook(Book newBook)
        {
            Data.Books.Add(newBook);
        }
    }
}
