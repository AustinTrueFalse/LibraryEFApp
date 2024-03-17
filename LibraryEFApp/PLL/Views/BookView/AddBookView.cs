using LibraryEFApp.BLL.Services;
using LibraryEFApp.PLL.Helpers;
using LibraryEFApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.BookView
{
    public class AddBookView
    {
        BookService bookService;
        public AddBookView(BookService bookService)
        {
            this.bookService = bookService;
        }

        public void Show()
        {
            var book = new BookEntity();

            Console.WriteLine("Введите название книги:");
            book.Name = Console.ReadLine();

            Console.Write("Год выпуска:");
            book.YearOfRelease = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите автора книги:");
            book.Author = Console.ReadLine();

            Console.WriteLine("Введите жанр книги:");
            book.Genre = Console.ReadLine();

            Console.WriteLine("Введите Id пользователя книги:");
            book.UserId = int.Parse(Console.ReadLine());

            try
            {
                this.bookService.Register(book, book.UserId);

                SuccessMessage.Show("Данные записаны.");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение.");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка добавления.");
            }
        }
 
    }
}
