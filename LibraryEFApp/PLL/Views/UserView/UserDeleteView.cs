using LibraryEFApp.BLL.Services;
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
        UserService userService;
        public UserDeleteView(UserService userService)
        {
            this.userService = userService;
        }


        public void Show()
        {

            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();

            Console.Write("Введите почтовый адрес:");
            string email = Console.ReadLine();

            try
            {
                userService.Delete(name, email);

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
