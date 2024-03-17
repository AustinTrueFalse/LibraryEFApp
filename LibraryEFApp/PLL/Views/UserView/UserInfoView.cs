using LibraryEFApp.BLL.Services;
using LibraryEFApp.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.UserView
{
    public class UserInfoView
    {
        UserService userService;
        public UserInfoView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show()
        {
            Console.WriteLine("Введите Id для поиска");

            int userToFind = int.Parse(Console.ReadLine());

            var user = userService.FindUserById(userToFind);

            try
            {
                
                SuccessMessage.Show("Пользователь найден!.");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение.");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка поиска.");
            }

            

            Console.WriteLine("Информация о пользователе");
            Console.WriteLine("Идентификатор: {0}", user.Id);
            Console.WriteLine("Имя: {0}", user.Name);
            Console.WriteLine("Почтовый адрес: {0}", user.Email);

        }
    }
}
