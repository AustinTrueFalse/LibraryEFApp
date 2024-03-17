using LibraryEFApp.DAL.Repositories;
using LibraryEFApp.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.UserView
{
    public class UserDeleteView
    {
        private IUserRepository userRepository;
        public UserDeleteView(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Show()
        {

            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();

            Console.Write("Введите почтовый адрес:");
            string email = Console.ReadLine();

            try
            {
                userRepository.Delete(name, email);

                SuccessMessage.Show("Данные удалены.");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение.");
            }

            catch (Exception)
            {
                AlertMessage.Show("Пользователь не найден");
            }
        }

    }
}
