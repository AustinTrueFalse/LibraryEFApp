using LibraryEFApp.DAL.Entities;
using LibraryEFApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.BookView
{
    public class BooksListOrderByName
    {
        private IBookRepository bookRepository;
        public BooksListOrderByName(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public void Show()
        {
            Console.WriteLine("Книги");

            var books = bookRepository.FindAll(bookSortParams: BookSortParams.bookName, sortType: SortType.asc);

            if (books.Count() == 0)
            {
                Console.WriteLine("Книг нет");
                return;
            }

            books.ToList().ForEach(book =>
            {
                Console.WriteLine("Название: {0} Год выпуска: {1}", book.Name, book.YearOfRelease);
            });
        }
    }
}
