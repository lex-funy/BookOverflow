using System;
using BookOverflowForms.Logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOverflowForms.Data
{
    class OrderDTO
    {
        public int Id;
        public User Buyer;
        public User Seller;
        public DateTime CreatedAt;
        public DateTime DeletedAt;
        public User DeletedBy;
        public List<Book> Books;
    }
}
