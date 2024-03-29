﻿using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title == title && x.Author == authorName).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title = "MVC", Author="saint"},
                new BookModel(){Id = 2, Title = "dot net core", Author="ola"},
                new BookModel(){Id = 3, Title = "C#", Author="elkay"},
                new BookModel(){Id = 4, Title = "Javascrip", Author="qbasic"},
                new BookModel(){Id = 4, Title = "MVC", Author="faitha"},
            };
        }
    }
}
