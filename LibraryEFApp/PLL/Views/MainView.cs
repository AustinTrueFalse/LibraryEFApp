using LibraryEFApp.PLL.Views.UserView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryEFApp.BLL.Exceptions;

namespace LibraryEFApp.PLL.Views
{
    public class MainView
    {
        enum Tables
        {
            users,
            books,
            authors
        }

        public void Show()
        {
           

            Console.Write("Выберите таблицу для работы: ");

            var table = Console.ReadLine();
            Console.WriteLine();
            switch (table)
            {
                case nameof(Tables.users):
                    Program.userMainView.Show();
                    break;
                case nameof(Tables.books):
                    Program.bookMainView.Show();
                    break;
                case nameof(Tables.authors):
                    Program.authorMainView.Show();
                    break;
                default:
                    throw new EnteredTableException();

            }


        }
    }
}
