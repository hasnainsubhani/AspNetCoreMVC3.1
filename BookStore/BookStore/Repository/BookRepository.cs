using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
	public class BookRepository
	{
		public List<BookModel> GetAllBook()
		{
			return DataSource();
		}

		public BookModel GetBookById(int id)
		{
			return DataSource().Where(x => x.id == id).FirstOrDefault();
		}

		public List<BookModel> SearchBook(string Name, string Author)
		{
			return DataSource().Where(x => x.title.Contains(Name) && x.author.Contains(Author)).ToList();
		}

		private List<BookModel> DataSource()
		{
			return new List<BookModel>() {
				new BookModel(){id=1,title="Net Core",author="Hasnain"},
				new BookModel(){id=2,title="Java",author="Hasnain"},
				new BookModel(){id=3,title="Php",author="Venket"},
				new BookModel(){id=4,title="MVC Net Core",author="Ammaar"},
				new BookModel(){id=5,title="C#",author="Aqdus"}
			};
		}

	}
}
