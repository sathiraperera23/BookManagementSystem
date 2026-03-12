using BookManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement.Application.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAll();

        Book? GetById(int id);

        void Add(Book book);

        void Update(Book book);

        void Delete(int id);
    }
}