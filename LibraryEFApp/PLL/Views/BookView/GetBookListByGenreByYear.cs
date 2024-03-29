﻿using LibraryEFApp.DAL.Repositories;
using LibraryEFApp.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.BookView
{
    public class GetBookListByGenreByYear
    {
        private IBookRepository bookRepository;
        public GetBookListByGenreByYear(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public void Show()
        {
            Console.WriteLine("Введите жанр");
            string genre = Console.ReadLine();

            Console.WriteLine("Год начала поиска");
            int yearfrom = int.Parse(Console.ReadLine());

            Console.WriteLine("Год конца поиска");
            int yearto = int.Parse(Console.ReadLine());


            var books = bookRepository.FindByGenreYear(genre, yearfrom, yearto);

            if (books.Count() == 0)
            {
                Console.WriteLine("Книг нет");
                return;
            }

            books.ToList().ForEach(book =>
            {
                Console.WriteLine("Название: {0} Год выпуска: {1}", book.Name, book.YearOfRelease);
               
            });

        }
    }
}
