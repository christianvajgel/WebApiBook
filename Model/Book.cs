using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    public class Book
    {
        public static List<Book> Books { get; set; }

        public int Id { get; set; }
        public String Author { get; set; }
        public String Title { get; set; }
        public Decimal Price { get; set; }

        static Book() 
        {
            Books = new List<Book>() {
                new Book() { Id = 1, Author = "Erick Evans", Title = "Domain Driven Design", Price = 29.99M },
                new Book() { Id = 2, Author = "Robert C. Martin", Title = "Code Clean", Price = 19.99M },
                new Book() { Id = 3, Author = "Martin Fowler", Title = "Refactoring", Price = 59.99M }
            };
        }

        public static List<Book> GetBooks() 
        {
            return Books;
        }
    }
}
