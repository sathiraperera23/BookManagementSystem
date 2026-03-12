using BookManagement.Application.Interfaces;
using BookManagement.Domain.Entities;
using Npgsql;

namespace BookManagement.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly string _connectionString;

        public BookRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Book> GetAll()
        {
            var books = new List<Book>();
            using var conn = new NpgsqlConnection(_connectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT id, title, author, isbn, publication_date FROM books", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                books.Add(new Book
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Author = reader.GetString(2),
                    Isbn = reader.GetString(3),
                    PublicationDate = reader.GetDateTime(4)
                });
            }
            return books;
        }

        public Book? GetById(int id)
        {
            using var conn = new NpgsqlConnection(_connectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT id, title, author, isbn, publication_date FROM books WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Book
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Author = reader.GetString(2),
                    Isbn = reader.GetString(3),
                    PublicationDate = reader.GetDateTime(4)
                };
            }
            return null;
        }

        public void Add(Book book)
        {
            using var conn = new NpgsqlConnection(_connectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "INSERT INTO books (title, author, isbn, publication_date) VALUES (@title, @author, @isbn, @publicationDate)", conn);
            cmd.Parameters.AddWithValue("@title", book.Title);
            cmd.Parameters.AddWithValue("@author", book.Author);
            cmd.Parameters.AddWithValue("@isbn", book.Isbn);
            cmd.Parameters.AddWithValue("@publicationDate", book.PublicationDate);
            cmd.ExecuteNonQuery();
        }

        public void Update(Book book)
        {
            using var conn = new NpgsqlConnection(_connectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "UPDATE books SET title=@title, author=@author, isbn=@isbn, publication_date=@publicationDate WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("@title", book.Title);
            cmd.Parameters.AddWithValue("@author", book.Author);
            cmd.Parameters.AddWithValue("@isbn", book.Isbn);
            cmd.Parameters.AddWithValue("@publicationDate", book.PublicationDate);
            cmd.Parameters.AddWithValue("@id", book.Id);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = new NpgsqlConnection(_connectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand("DELETE FROM books WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}