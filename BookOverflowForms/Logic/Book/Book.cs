using System;
using BookOverflowForms.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOverflowForms.Logic
{
    class Book
    {
        public int Id;
        public Course Course;
        public User User;
        public Sector Sector;
        public string Name;
        public int QualityRating;
        public double price;
        public DateTime CreatedAt;
        public DateTime DeletedAt;
        public User DeletedBy;

        public Book(BookDTO bookDTO)
        {
            // TODO: Make book from bookdto
        }

        public bool Update()
        {
            // TODO: Fill

            return false;
        }
    }
}
