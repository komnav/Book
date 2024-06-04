using BusinessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccess
{
    public class BookRepository(OrmBookDbContext dbContext) : IBookRepository
    {
        private readonly OrmBookDbContext _db = dbContext;
        public void Create(Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var bookToDelete = _db.Books.FirstOrDefault(x => x.Id == id);
            if (bookToDelete != null)
            {
                _db.Books.Remove(bookToDelete);
                _db.SaveChanges();
            }
        }

        public IEnumerable<Book> GetAll()
        {
            return _db.Books.AsNoTracking().ToList(); 
        }

        public Book GetById(int id)
        {
            return _db.Books.FirstOrDefault(i => i.Id == id);
        }

        public void Update(int id, Book book)
        {
            var update = _db.Books.FirstOrDefault(x => x.Id == id);
            if (update != null)
            {
                update.Author = book.Author;
                update.Title = book.Title;
                update.Price = book.Price;
                update.Category = book.Category;
                update.Image = book.Image;
                update.Id = book.Id;
                update.AuthorId = book.AuthorId;
                update.CategoryId = book.CategoryId;

                _db.SaveChanges();
            }

        }

    }
}
