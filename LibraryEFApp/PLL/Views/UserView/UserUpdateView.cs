using LibraryEFApp.DAL.Repositories;
using LibraryEFApp.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.UserView
{
    public class UserUpdateView
    {
        private IUserRepository userRepository;
        public UserUpdateView(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Show()
        {
           
            Console.WriteLine("Введите Id:");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Введите новое имя:");
            string name = Console.ReadLine();

            try
            {
                userRepository.UpdateById(id, name);

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
