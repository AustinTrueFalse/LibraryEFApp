using LibraryEFApp.PLL.Helpers;
using LibraryEFApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryEFApp.DAL.Repositories;

namespace LibraryEFApp.PLL.Views.BookView
{
    public class AddBookView
    {
        private IBookRepository bookRepository;
        public AddBookView(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public void Show()
        {
            Console.WriteLine("Введите название");
            var name = Console.ReadLine();
            Console.WriteLine("Введите год издания");
            var year = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите Id автора книги");
            var authorId = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите жанр книги через запятую");

            var genre = Console.ReadLine();


            var book = new BookEntity { Name = name, YearOfRelease = year, Users = new List<UserEntity>(), AuthorId = authorId, Genre = genre };

            try
            {
                this.bookRepository.AddBook(book);

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
