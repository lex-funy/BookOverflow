using System;
using BookOverflowForms.Logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOverflowForms.Data
{
    class ImageDTO
    {
        public int Id;
        public User user;
        public string ImagePath;
        public DateTime CreatedAt;
        public DateTime DeletedAt;
        public User DeletedBy;
    }
}
