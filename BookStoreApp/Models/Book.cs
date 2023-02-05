using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Xml.Linq;

namespace BookStoreApp.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        [Display(Name = "Published Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTimeOffset PublishedDate { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string BookID { get; set; }

    }
    public class BookDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}