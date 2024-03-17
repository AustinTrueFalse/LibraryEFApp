using LibraryEFApp.DAL.Repositories;
using LibraryEFApp.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.BookView
{
    public class GetNewestBook
    {
        private IBookRepository bookRepository;
        public GetNewestBook(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public void Show()
        {



            try
            {
                var book = bookRepository.GetNewestBook();

                SuccessMessage.Show("Книга найдена!");

                Console.WriteLine("Информация о книге");
                Console.WriteLine("Идентификатор: {0}", book.Id);
                Console.WriteLine("Имя: {0}", book.Name);
                Console.WriteLine("Год выпуска: {0}", book.YearOfRelease);
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка поиска");
            }

            

        }
    }
}
