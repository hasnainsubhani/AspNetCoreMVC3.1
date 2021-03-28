using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
	public class BookController : Controller
	{
		private readonly BookRepository _bookRepository = null;
		public BookController()
		{
			_bookRepository = new BookRepository();
		}
		public List<BookModel> GetAllBook()
		{
			return _bookRepository.GetAllBook();
		}

		public BookModel GetBook(int id)
		{
			return _bookRepository.GetBookById(id);
		}

		public List<BookModel> SearchBook(string Name,string Author)
		{
			return _bookRepository.SearchBook(Name,Author);
		}
	}
}
