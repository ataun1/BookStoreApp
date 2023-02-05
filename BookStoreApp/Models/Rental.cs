using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStoreApp.Models
{
    public class Rental
    {
        public Rental()
        {
            RentalStatus = Status.Available;
        }
        public int Id { get; set; }
        public string BookId { get; set; }
        public Status RentalStatus { get; set; }
        public string BookingNumber { get; set; }
        
    }
    public enum Status
    {
        Available,
        Reserved
    }

    public class RentalDBContext : DbContext
    {
        public DbSet<Rental> Rentals { get; set; }
    }
}