using LibraryEFApp.DAL.Entities;
using LibraryEFApp.BLL.Services;
using LibraryEFApp.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.UserView
{
    public class AddUserView
    {
        UserService userService;
        public AddUserView(UserService userService)
        {
            this.userService = userService;
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
                this.userService.Register(user);

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
