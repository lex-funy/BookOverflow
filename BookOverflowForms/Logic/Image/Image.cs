using System;
using BookOverflowForms.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOverflowForms.Logic
{
    class Image
    {
        public int Id;
        public User user;
        public string ImagePath;
        public DateTime CreatedAt;
        public DateTime DeletedAt;
        public User DeletedBy;

        public Image(ImageDTO imageDTO)
        {
            // TODO: Make image from imageDTO
        }

        public bool Update()
        {
            // TODO: Fill

            return false;
        }

    }
}
