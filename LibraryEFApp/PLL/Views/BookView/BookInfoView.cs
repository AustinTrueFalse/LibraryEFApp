
using LibraryEFApp.BLL.Exceptions;
using LibraryEFApp.DAL.Repositories;
using LibraryEFApp.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.BookView
{
    public class BookInfoView
    {
        private IBookRepository bookRepository;
        public BookInfoView(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public void Show()
        {
            Console.WriteLine("Введите Id для поиска");

            int bookToFind = int.Parse(Console.ReadLine());



            try
            {
                var book = bookRepository.FindById(bookToFind);

                SuccessMessage.Show("Книга найдена!");
                Console.WriteLine();
                Console.WriteLine("Информация о книге");
                Console.WriteLine("Идентификатор: {0}", book.Id);
                Console.WriteLine("Имя: {0}", book.Name);
                Console.WriteLine("Год выпуска: {0}", book.YearOfRelease);

                
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение");
            }
            catch (BookNotFoundException)
            {
                AlertMessage.Show("Книга не найдена");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка поиска");
            }

            

            

        }
    }
}
