
using LibraryEFApp.BLL.Services;
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
        UserService userService;
        public UserUpdateView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show()
        {
           
            Console.WriteLine("Введите Id:");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Введите новое имя:");
            string name = Console.ReadLine();

            try
            {
                userService.UpdateById(id, name);

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
