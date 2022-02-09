using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repositories
{
    

    public class BookRepository : IBookstoreRepository<Book> 
    {
        List<Book> books;
        public BookRepository()
        {
            books = new List<Book>
                {
                    new Book
                    {
                    Id=1 , Title="c# programing" , Description="no description", ImageUrl="shrp.jpg", Author = new Author()
                    },
                    new Book
                    {
                    Id=2 , Title="java programing" , Description="nothing", ImageUrl="java.jpg", Author = new Author()
                    },
                    new Book
                    {
                    Id=3 , Title="c++ programing" , Description="no data", ImageUrl="bls.jpg" ,Author = new Author()
                    }
                };
        }
        public void Add(Book entity)
        {
            entity.Id = books.Max(b => b.Id) + 1;
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = books.SingleOrDefault(b => b.Id == id);
             books.Remove (book) ;
        }

        public Book find(int id)
        {
            var book = books.SingleOrDefault(b => b.Id == id);
            return book;
        }

        public IList<Book> List()
        {
           return books;
        }

        public List<Book> Search(string term)
        {
            throw new NotImplementedException();
        }

        public void Update(int id , Book NewBook)
        {
            var book = books.SingleOrDefault(b => b.Id == id);
            book.Title = NewBook.Title;
            book.Description = NewBook.Description;
            book.Author = NewBook.Author;
            book.ImageUrl = NewBook.ImageUrl;
        }
    }
}
