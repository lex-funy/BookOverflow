using BookOverflowForms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOverflowForms.Logic
{
    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public User DeletedBy { get; set; }

        public Course()
        {

        }

        public Course(CourseDTO courseDTO)
        {
            this.Id = courseDTO.Id;
            this.Name = courseDTO.Name;
            this.CreatedAt = courseDTO.DeletedAt;
            this.DeletedAt = courseDTO.DeletedAt;
            this.DeletedBy = courseDTO.DeletedBy;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
