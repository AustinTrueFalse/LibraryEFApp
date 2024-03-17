using LibraryEFApp.DAL.Entities;
using LibraryEFApp.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryEFApp.DAL.Repositories;

namespace LibraryEFApp.PLL.Views.UserView
{
    public class AddUserView
    {
        private IUserRepository userRepository;
        public AddUserView(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Show()
        {
            var user = new UserEntity();

            Console.WriteLine("Введите ваше имя:");
            user.Name = Console.ReadLine();

            Console.Write("Почтовый адрес:");
            user.Email = Console.ReadLine();

            try
            {
                this.userRepository.AddUser(user);

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
