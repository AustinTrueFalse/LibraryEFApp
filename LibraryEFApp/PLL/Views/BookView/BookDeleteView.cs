using LibraryEFApp.BLL.Services;
using LibraryEFApp.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.BookView
{
    public class BookDeleteView
    {
        BookService bookService;
        public BookDeleteView(BookService bookService)
        {
            this.bookService = bookService;
        }


        public void Show()
        {

            Console.WriteLine("Введите название:");
            string name = Console.ReadLine();

            Console.Write("Введите год выпуска:");
            int yearOfRelease = int.Parse(Console.ReadLine());

            try
            {
                bookService.Delete(name, yearOfRelease);

                SuccessMessage.Show("Данные удалены.");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение.");
            }

            catch (Exception)
            {
                AlertMessage.Show("Книга не найдена");
            }
        }

    }
}
