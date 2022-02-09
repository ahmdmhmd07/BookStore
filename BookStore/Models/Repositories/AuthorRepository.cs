using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repositories
{
    public class AuthorRepository : IBookstoreRepository<Author>
    {
        IList<Author> authors;
        public AuthorRepository()
        {
            authors = new List<Author>
            {
                new Author {Id=1 , FullName="ahmd mhmd" },
                new Author {Id=2 , FullName="amir" },
                new Author {Id=3 , FullName="hussein" }
            };
        }
        public void Add(Author entity)
        {
            authors.Add(entity);
        }

        public void Delete(int id)
        {
            var author = authors.SingleOrDefault(a => a.Id == id);
            authors.Remove(author);
        }

        public Author find(int id)
        {
            var author = authors.SingleOrDefault(a=>a.Id==id);
            return author;
        }

        public IList<Author> List()
        {
            return authors;
        }

        public List<Author> Search(string term)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Author NewAuthor)
        {
            var author = authors.SingleOrDefault(a => a.Id == id);
            author.FullName = NewAuthor.FullName;
        }
    }
}
