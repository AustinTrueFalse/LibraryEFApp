using LibraryEFApp.BLL.Exceptions;
using LibraryEFApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.UserView
{
    public class GetBookUserView
    {
        private IUserRepository userRepository;

        public GetBookUserView(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public void Show()
        {
            try
            {
                Console.WriteLine("Введите Id пользователя");

                var userId = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите Id книги");

                var bookId = int.Parse(Console.ReadLine());

                userRepository.GetBookFromLibrary(userId, bookId);
            }
            catch (UserNotFoundException)
            {
                Console.WriteLine("Ошибка! Пользователь с таким id отсутствует в базе");
            }
            catch (BookNotFoundException)
            {
                Console.WriteLine("Ошибка! Книга с таким id отсутствует в базе");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
