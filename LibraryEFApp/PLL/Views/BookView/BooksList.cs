using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryEFApp.BLL.Services;
using LibraryEFApp.DAL.Entities;

namespace LibraryEFApp.PLL.Views.BookView
{
    public class BooksListView
    {
        BookService bookService;
        public BooksListView(BookService bookService)
        {
            this.bookService = bookService;
        }
        public void Show()
        {
            Console.WriteLine("Книги");

            var books = bookService.FindAll();

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
