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
    public class AuthorInfoView
    {
        private IAuthorRepository authorRepository;
        public AuthorInfoView(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }
        public void Show()
        {
            Console.WriteLine("Введите Id для поиска");

            int authorToFind = int.Parse(Console.ReadLine());



            try
            {
                var author = authorRepository.FindById(authorToFind);

                SuccessMessage.Show("Автор найден!");
                Console.WriteLine();
                Console.WriteLine("Информация об авторе");
                Console.WriteLine("Идентификатор: {0}", author.Id);
                Console.WriteLine("Имя: {0}", author.FirstName);
                Console.WriteLine("Фамилия: {0}", author.LastName);

            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение");
            }
            catch (UserNotFoundException)
            {
                AlertMessage.Show("Автор не найден");
            }
            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка поиска");
            }

            

            

        }
    }
}
