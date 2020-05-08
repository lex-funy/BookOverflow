using System;
using BookOverflowForms.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOverflowForms.Logic
{
    class User
    {
        public int      Id          { get; set; }
        public Image    Image       { get; set; }
        public string   Email       { get; set; }
        public string Password { get; set; }
        public string   FirstName   { get; set; }
        public string   Insertion   { get; set; }
        public string   LastName    { get; set; }
        public PermissionType Permission { get; set; }
        public string   ZipCode     { get; set; }
        public DateTime CreatedAt   { get; set; }
        public DateTime DeletedAt   { get; set; }
        public User     DeletedBy   { get; set; }

        public User(UserDTO userDTO)
        {
            this.Id = userDTO.Id;

            // TODO: Add image;

            this.Email = userDTO.Email;
            this.Password = userDTO.Password;
            this.FirstName = userDTO.FirstName;
            this.Insertion = userDTO.Insertion;
            this.LastName = userDTO.LastName;
            this.Permission = (PermissionType)userDTO.Permission;
            this.ZipCode = userDTO.ZipCode;
            this.CreatedAt = userDTO.CreatedAt;
            this.DeletedAt = userDTO.DeletedAt;

            // TODO: Add deletedBy user;
        }

        public bool Update()
        {
            // TODO: Fill

            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{this.LastName}, {this.FirstName} {this.Insertion}";
        }
    }
}
