using System;
using System.Collections.Generic;
using BookOverflowForms.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOverflowForms.Logic
{
    class Order
    {
        public int Id;
        public User Buyer;
        public User Seller;
        public DateTime CreatedAt;
        public DateTime DeletedAt;
        public User DeletedBy;
        public List<Book> Books;

        public Order(OrderDTO orderDTO)
        {
            this.Books = new List<Book>();
         
            // TODO: Make order from orderDTO
        }

        public bool Update()
        {
            // TODO: Fill

            return false;
        }
    }
}
