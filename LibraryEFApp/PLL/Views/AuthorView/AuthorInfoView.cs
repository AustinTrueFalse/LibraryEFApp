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

            var author = authorRepository.FindById(authorToFind);

            try
            {
                
                SuccessMessage.Show("Автор найдеа!.");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение.");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка поиска.");
            }

            

            Console.WriteLine("Информация о книге");
            Console.WriteLine("Идентификатор: {0}", author.Id);
            Console.WriteLine("Имя: {0}", author.FirstName);
            Console.WriteLine("Год выпуска: {0}", author.LastName);

        }
    }
}
