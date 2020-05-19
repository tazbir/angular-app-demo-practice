﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular_JS.Data.Models;
using Angular_JS.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angular_JS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        //Create/add a new book
        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody] Book book)
        {
            _bookService.AddBook(book);
            return Ok("Added");
        }

        //Read all books
        [HttpGet("[action]")]
        public IActionResult GetBooks()
        {
            var allBooks = _bookService.GetAllBooks();
            return Ok(allBooks);
        }

        //Read all books
        [HttpGet("singleBook/{id}")]
        public IActionResult GetBookById(int id)
        {
            var singleBook = _bookService.GetBookById(id);
            return Ok(singleBook);
        }

        //update an existing book
        [HttpPut("UpdateBook/{id}")]
        public IActionResult UpdateBook(int id, [FromBody]Book bookObj)
        {
            _bookService.UpdateBook(id,bookObj);
            return Ok(bookObj);
        }

        //delete a book
        [HttpDelete("DeleteBook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _bookService.DeleteBook(id);
            return Ok();
        }
    }
}