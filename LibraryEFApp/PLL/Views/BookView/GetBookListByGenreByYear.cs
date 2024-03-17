using LibraryEFApp.DAL.Repositories;
using LibraryEFApp.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.BookView
{
    public class GetBookListByGenreByYear
    {
        private IBookRepository bookRepository;
        public GetBookListByGenreByYear(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public void Show()
        {
            Console.WriteLine("Введите жанр");

            var books = bookRepository.FindAll();

            if (books.Count() == 0)
            {
                Console.WriteLine("Книг нет");
                return;
            }

            books.ToList().ForEach(book =>
            {
                Console.WriteLine("Имя: {0}", book.Name);
                Console.WriteLine("Email: {0}", book.YearOfRelease);
            });

        }
    }
}
