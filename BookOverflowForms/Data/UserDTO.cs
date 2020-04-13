using BookOverflowForms.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOverflowForms.Data
{
    struct UserDTO
    {
        public int      Id          { get; set; }
        public Image    Image       { get; set; }
        public string   Email       { get; set; }
        public string   FirstName   { get; set; }
        public string   Insertion   { get; set; }
        public string   LastName    { get; set; }

        // TODO: Fix Enum
        //public PermissionType Permission { get; set; }

        public string   ZipCode     { get; set; }
        public DateTime CreatedAt   { get; set; }
        public DateTime DeletedAt   { get; set; }
        public User     CreatedBy   { get; set; }
    }
}
