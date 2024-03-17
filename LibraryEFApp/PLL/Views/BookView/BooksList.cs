using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryEFApp.DAL.Entities;
using LibraryEFApp.DAL.Repositories;

namespace LibraryEFApp.PLL.Views.BookView
{
    public class BooksListView
    {
        private IBookRepository bookRepository;
        public BooksListView(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public void Show()
        {
            Console.WriteLine("Книги");

            var books = bookRepository.FindAll();

            if (books.Count() == 0)
            {
                Console.WriteLine("Книг нет");
                return;
            }

            books.ToList().ForEach(book =>
            {
                Console.WriteLine("Название: {0} Год релиза: {1}", book.Name, book.YearOfRelease);
            });
        }
    }
}
