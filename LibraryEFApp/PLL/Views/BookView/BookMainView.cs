using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.BookView
{
    public class BookMainView
    {
        public void Show()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Добавить книгу (нажмите 1)");
                Console.WriteLine("Вывести список всех книг (нажмите 2)");
                Console.WriteLine("Вывести список всех книг в алфавитном порядке (нажмите 3)");
                Console.WriteLine("Вывести список всех книг в порядке убывания выпуска (нажмите 4)");
                Console.WriteLine("Найти книгу по Id (нажмите 5)");
                Console.WriteLine("Удалить книгу (нажмите 6)");
                Console.WriteLine("Обновить год выпуска по Id (нажмите 7)");
                Console.WriteLine("Найти книгу по жанру и в промежутке лет (нажмите 8)");
                Console.WriteLine("Кол-во книг по жанру (нажмите 9)");
                Console.WriteLine("Кол-во книг по автору (нажмите 10)");
                Console.WriteLine("Флаг о том, что есть книги по автору и названию (нажмите 11)");
                Console.WriteLine("Флаг о том, что есть книга есть у пользователя (нажмите 12)");
                Console.WriteLine("Найти книгу с последнюю вышедшею книгу (нажмите 13)");
                Console.WriteLine("Выйти из программы (нажмите 14)");

                string keyValue = Console.ReadLine();

                if (keyValue == "14") break;

                switch (keyValue)
                {
                    case "1":
                        {
                            Program.addBookView.Show();
                            break;
                        }
                    case "2":
                        {
                            Program.booksListView.Show();
                            break;
                        }
                    case "3":
                        {
                            Program.booksListOrderByName.Show();
                            break;
                        }
                    case "4":
                        {
                            Program.booksListOrderByYear.Show();
                            break;
                        }
                    case "5":
                        {
                            Program.bookInfoView.Show();
                            break;
                        }
                    case "6":
                        {
                            Program.bookDeleteView.Show();
                            break;
                        }
                    case "7":
                        {
                            Program.bookUpdateView.Show();
                            break;
                        }
                    case "8":
                        {
                            Program.getBookListByGenreByYearView.Show();
                            break;
                        }
                    case "9":
                        {
                            Program.getCountBooksByGenre.Show();
                            break;
                        }
                    case "10":
                        {
                            Program.getCountBooksByAuthor.Show();
                            break;
                        }
                    case "11":
                        {
                            Program.getFlagHasBooksByAuthorByName.Show();
                            break;
                        }
                    case "12":
                        {
                            Program.getFlagHasBooksByUserByName.Show();
                            break;
                        }
                    case "13":
                        {
                            Program.getNewestBook.Show();
                            break;
                        }
                }
            }

        }
    }
}
