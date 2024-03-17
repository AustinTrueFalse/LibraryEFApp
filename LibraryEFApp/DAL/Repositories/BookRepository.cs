using LibraryEFApp.BLL.Exceptions;
using LibraryEFApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using System.Xml.Linq;


namespace LibraryEFApp.DAL.Repositories
{
    public class BookRepository : AppContextEF, IBookRepository
    {
        public void AddBook(BookEntity bookEntity)
        {
            using (var db = new AppContextEF())
            {
                
                // Добавление книги
                db.Books.Add(bookEntity);

                db.SaveChanges();
            }

        }
        public List<BookEntity> FindAll(BookSortParams bookSortParams = BookSortParams.none, SortType sortType = SortType.asc)
        {

            List<BookEntity> allBooks;
            using (var db = new AppContextEF())
            {

                switch (bookSortParams)
                {
                    case BookSortParams.bookName:
                        if (sortType == SortType.asc)
                            allBooks = db.Books.OrderBy(b => b.Name).ToList();
                        else
                            allBooks = db.Books.OrderByDescending(b => b.Name).ToList();
                        break;
                    case BookSortParams.bookYear:
                        if (sortType == SortType.asc)
                            allBooks = db.Books.OrderBy(b => b.YearOfRelease).ToList();
                        else
                            allBooks = db.Books.OrderByDescending(b => b.YearOfRelease).ToList();
                        break;
                    default:
                        allBooks = db.Books.ToList();
                        break;
                }

            }
            return allBooks;

        }
        public BookEntity FindById(int id)
        {
            using (var db = new AppContextEF())
            {

                var book = db.Books.Where(b => b.Id == id).FirstOrDefault();
               

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
               
                var book = db.Books.Where(b => b.Name == name && b.YearOfRelease == yearOfRelease).ToList().FirstOrDefault();

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

        public List<BookEntity> FindByGenreYear(string genre, int yearfrom, int yearto)
        {
            using (var db = new AppContextEF())
            {

                    return db.Books.Where(b => b.Genre == genre && b.YearOfRelease >= yearfrom && b.YearOfRelease <= yearto).ToList();           
               
            }

        }

        public int GetCountBooksByGenre(string genre)
        {
            using (var db = new AppContextEF())
            {

                return db.Books.Where(b => b.Genre == genre).ToList().Count();

            }

        }
        public int GetCountBooksByAuthor(AuthorEntity author)
        {
            using (var db = new AppContextEF())
            {

                return db.Books.Where(b => b.Authors.Contains(author)).ToList().Count();

            }

        }
        public bool GetFlagHasBooksByAuthorByName(AuthorEntity author, string name)
        {
            using (var db = new AppContextEF())
            {
                int count = db.Books.Where(b => b.Authors.Contains(author) && b.Name == name).ToList().Count();
                return count > 0;

            }

        }
        public bool GetFlagHasBooksByUserByName(UserEntity user, string name)
        {
            using (var db = new AppContextEF())
            {
                int count = db.Books.Where(b => b.Users.Contains(user) && b.Name == name).ToList().Count();
                return count > 0;

            }

        }

        public BookEntity GetNewestBook()
        {
            using (var db = new AppContextEF())
            {

                return db.Books.OrderByDescending(b => b.YearOfRelease).FirstOrDefault();

            }

        }



    }

    public interface IBookRepository
    {
        void AddBook(BookEntity bookEntity);
        List<BookEntity> FindAll(BookSortParams bookSortParams = BookSortParams.none, SortType sortType = SortType.asc);
        BookEntity FindById(int id);
        void Delete(string name, int yearOfRelease);
        void UpdateById(int id, int yearOfRelease);
        List<BookEntity> FindByGenreYear(string genre, int yearfrom, int yearto);
        int GetCountBooksByGenre(string genre);
        int GetCountBooksByAuthor(AuthorEntity author);
        bool GetFlagHasBooksByAuthorByName(AuthorEntity author, string name);
        bool GetFlagHasBooksByUserByName(UserEntity user, string name);
        BookEntity GetNewestBook();

    }
}
