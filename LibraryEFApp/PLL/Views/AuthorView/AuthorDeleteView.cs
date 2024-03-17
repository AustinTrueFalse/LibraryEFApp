using LibraryEFApp.DAL.Repositories;
using LibraryEFApp.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.AuthorView
{
    public class AuthorDeleteView
    {
        private IAuthorRepository authorRepository;
        public AuthorDeleteView(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }


        public void Show()
        {

            Console.WriteLine("Введите имя автора:");
            string firstname = Console.ReadLine();

            Console.Write("Введите фамилию автора:");
            string lastname = Console.ReadLine();

            try
            {
                authorRepository.Delete(firstname, lastname);

                SuccessMessage.Show("Данные удалены");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение");
            }

            catch (Exception)
            {
                AlertMessage.Show("Книга не найдена");
            }
        }

    }
}
