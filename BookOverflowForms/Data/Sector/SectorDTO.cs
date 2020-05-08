using BookOverflowForms.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOverflowForms.Data
{
    class SectorDTO
    {
        public int Id;
        public string Name;
        public DateTime CreatedAt;
        public DateTime DeletedAt;
        public User DeletedBy;
    }
}
