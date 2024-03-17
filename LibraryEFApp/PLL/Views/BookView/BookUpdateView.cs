using LibraryEFApp.BLL.Services;
using LibraryEFApp.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.BookView
{
    public class BookUpdateView
    {
        BookService bookService;
        public BookUpdateView(BookService bookService)
        {
            this.bookService = bookService;
        }

        public void Show()
        {
           
            Console.WriteLine("Введите Id:");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Введите обновленный год выпуска:");
            int yearOfRelease = int.Parse(Console.ReadLine());

            try
            {
                bookService.UpdateById(id, yearOfRelease);

                SuccessMessage.Show("Данные обновлены.");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение.");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка удаления.");
            }
        }

    }
}
