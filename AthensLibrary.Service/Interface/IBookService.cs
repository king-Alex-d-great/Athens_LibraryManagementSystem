﻿using AthensLibrary.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthensLibrary.Service.Interface
{
    public interface IBookService
    {
         Task<Book> BorrowBook();
         Task<Book> CreateBook();
         Task<IEnumerable<Book>> GetAllBooks();
         Task<IEnumerable<Book>> GetAllBooksByAnAuthor();
         Task<IEnumerable<Book>> GetAllBooksByCategory();
         Task<IEnumerable<Book>> GetAllBooksByIsbn();
         Task<IEnumerable<Book>> GetAllBooksByYear();
         Task<Book> UpdateBook();
         Task<Book> ReturnBook();

    }
}
