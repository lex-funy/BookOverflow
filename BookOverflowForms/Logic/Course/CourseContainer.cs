using BookOverflowForms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOverflowForms.Logic
{
    class CourseContainer
    {
        private readonly CourseDAL _courseDAL;

        public CourseContainer()
        {
            _courseDAL = new CourseDAL();
        }

        public List<Course> GetAllCourses()
        {
            var sectors = new List<Course>();
            var sectorDTOs = _courseDAL.GetAll();

            foreach (var sectorDTO in sectorDTOs)
            {
                sectors.Add(new Course(sectorDTO));
            }

            return sectors;
        }

        public Course GetCourseById(int id)
        {
            return new Course(_courseDAL.GetById(id));
        }
    }
}
