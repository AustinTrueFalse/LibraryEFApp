using LibraryEFApp.BLL.Exceptions;
using LibraryEFApp.DAL.Repositories;
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
        private IUserRepository userRepository;
        public UserInfoView(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public void Show()
        {
            Console.WriteLine("Введите Id для поиска");

            int userToFind = int.Parse(Console.ReadLine());

            

            try
            {
                var user = userRepository.FindById(userToFind);

                SuccessMessage.Show("Пользователь найден!");
                Console.WriteLine();
                Console.WriteLine("Информация о пользователе");
                Console.WriteLine("Идентификатор: {0}", user.Id);
                Console.WriteLine("Имя: {0}", user.Name);
                Console.WriteLine("Почтовый адрес: {0}", user.Email);
            }
            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка поиска");
            }
         

            

        }
    }
}
