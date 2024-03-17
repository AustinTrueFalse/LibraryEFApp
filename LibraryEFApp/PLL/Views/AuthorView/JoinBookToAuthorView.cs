using LibraryEFApp.BLL.Exceptions;
using LibraryEFApp.DAL.Repositories;
using LibraryEFApp.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.AuthorView
{
    public class JoinBookToAuthorView
    {
        private IAuthorRepository authorRepository;
        public JoinBookToAuthorView(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public void Show()
        {
            try
            {
                Console.WriteLine("Введите Id автора");

                var userId = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите Id книги");

                var bookId = int.Parse(Console.ReadLine());

                authorRepository.JoinBookToAuthor(userId, bookId);

                SuccessMessage.Show("Данные записаны");
            }
            catch (UserNotFoundException)
            {
                Console.WriteLine("Ошибка! Автор с таким id отсутствует в базе");
            }
            catch (BookNotFoundException)
            {
                Console.WriteLine("Ошибка! Книга с таким id отсутствует в базе");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

