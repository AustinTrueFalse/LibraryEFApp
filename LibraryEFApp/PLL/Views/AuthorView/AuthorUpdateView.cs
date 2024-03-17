using LibraryEFApp.DAL.Repositories;
using LibraryEFApp.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.AuthorView
{
    public class AuthorUpdateView
    {
        private IAuthorRepository authorRepository;
        public AuthorUpdateView(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public void Show()
        {
           
            Console.WriteLine("Введите Id:");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Введите обновленный год выпуска:");
            string firstname = Console.ReadLine();

            Console.Write("Введите обновленный год выпуска:");
            string lastname = Console.ReadLine();

            try
            {
                authorRepository.UpdateById(id, firstname, lastname);

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
