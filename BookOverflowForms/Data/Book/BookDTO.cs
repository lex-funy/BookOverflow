using System;
using BookOverflowForms.Logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOverflowForms.Data
{
    class BookDTO
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
    }
}
