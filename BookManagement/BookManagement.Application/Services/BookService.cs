using BookManagement.Application.Interfaces;
using BookManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement.Application.Services
{
    public class BookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public List<Book> GetBooks()
        {
            return _repository.GetAll();
        }

        public Book? GetBook(int id)
        {
            return _repository.GetById(id);
        }

        public void AddBook(Book book)
        {
            _repository.Add(book);
        }

        public void UpdateBook(Book book)
        {
            _repository.Update(book);
        }

        public void DeleteBook(int id)
        {
            _repository.Delete(id);
        }
    }
}