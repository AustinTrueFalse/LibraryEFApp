using LibraryEFApp.BLL.Exceptions;
using LibraryEFApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.DAL.Repositories
{
    public class BookRepository : AppContextEF, IBookRepository
    {
        public void AddBook(BookEntity bookEntity, int userId)
        {
            using (var db = new AppContextEF())
            {

                var user = db.Users.FirstOrDefault(u => u.Id == userId);

                bookEntity.UserEntity = user;
                // Добавление книги
                db.Books.Add(bookEntity);

                db.SaveChanges();
            }

        }
        public List<BookEntity> FindAll()
        {

            List<BookEntity> allBooks;
            using (var db = new AppContextEF())
            {

                allBooks = db.Books.ToList();

            }
            return allBooks;

        }
        public BookEntity FindById(int id)
        {
            using (var db = new AppContextEF())
            {

                var book = db.Books.FirstOrDefault(u => u.Id == id);
                if (book == null)
                {
                    throw new BookNotFoundException();
                }
                    
                return book;

            }     

        }
        public void Delete(string name, int yearOfRelease)
        {
            using (var db = new AppContextEF())
            {
                var book = db.Books.FirstOrDefault(u => u.Name == name && u.YearOfRelease == yearOfRelease);

                if (book == null)
                {
                    throw new BookNotFoundException();
                }

                db.Books.Remove(book);

                db.SaveChanges();
            }

        }
        public void UpdateById(int id, int yearOfRelease)
        {
            using (var db = new AppContextEF())
            {
                var book = db.Books.FirstOrDefault(u => u.Id == id);
                book.YearOfRelease = yearOfRelease;

                db.SaveChanges();
            }

        }
    }

    public interface IBookRepository
    {
        void AddBook(BookEntity bookEntity, int userId);
        public List<BookEntity> FindAll();
        BookEntity FindById(int id);
        void Delete(string name, int yearOfRelease);
        void UpdateById(int id, int yearOfRelease);

    }
}
