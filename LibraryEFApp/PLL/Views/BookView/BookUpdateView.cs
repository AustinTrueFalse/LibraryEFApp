
using LibraryEFApp.DAL.Repositories;
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
        private IBookRepository bookRepository;
        public BookUpdateView(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public void Show()
        {
           
            Console.WriteLine("Введите Id:");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Введите обновленный год выпуска:");
            int yearOfRelease = int.Parse(Console.ReadLine());

            try
            {
                bookRepository.UpdateById(id, yearOfRelease);

                SuccessMessage.Show("Данные обновлены");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка удаления");
            }
        }

    }
}
