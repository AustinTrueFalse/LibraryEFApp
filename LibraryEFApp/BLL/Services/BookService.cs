using LibraryEFApp.BLL.Exceptions;
using LibraryEFApp.DAL.Entities;
using LibraryEFApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.BLL.Services
{
    public class BookService
    {
        IBookRepository bookRepository;

        public BookService()
        {
            bookRepository = new BookRepository();
            
        }

        public void Register(BookEntity book, int userId)
        {
            if (String.IsNullOrEmpty(book.Name))
                throw new ArgumentNullException();

            if (String.IsNullOrEmpty(book.YearOfRelease.ToString()))
                throw new ArgumentNullException();

            if (String.IsNullOrEmpty(book.Author))
                throw new ArgumentNullException();

            if (String.IsNullOrEmpty(book.Genre))
                throw new ArgumentNullException();

            var bookEntity = new BookEntity()
            {
                Name = book.Name,
                YearOfRelease = book.YearOfRelease,
                Author = book.Author,
                Genre = book.Genre,
                UserId = userId
            };

            try
            {

                bookRepository.AddBook(bookEntity, userId);
            }
            catch (Exception ex) { throw new Exception(); };

        }

        public List<BookEntity> FindAll()
        {
            try
            {
                var books = bookRepository.FindAll();
                return books;
            }
            catch (Exception ex) { throw new Exception(); };

        }

        public BookEntity FindBookById(int id)
        {
            var findBookEntity = bookRepository.FindById(id);
            if (findBookEntity is null) throw new BookNotFoundException();

            return findBookEntity;
        }

        public void Delete(string name, int yearOfRelease)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException();

            if (String.IsNullOrEmpty(yearOfRelease.ToString()))
                throw new ArgumentNullException();

            try
            {
                bookRepository.Delete(name, yearOfRelease);
            }
            catch (Exception ex) { throw new Exception(); };

        }
        public void UpdateById(int id, int yearOfRelease)
        {
            if (String.IsNullOrEmpty(yearOfRelease.ToString()))
                throw new ArgumentNullException();

            try
            {
                bookRepository.UpdateById(id, yearOfRelease);
            }
            catch (Exception ex) { throw new Exception(); };

        }

    }
}
