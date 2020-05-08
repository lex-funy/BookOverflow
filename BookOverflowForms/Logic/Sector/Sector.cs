using BookOverflowForms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOverflowForms.Logic
{
    class Sector
    {
        public int Id;
        public string Name;
        public DateTime CreatedAt;
        public DateTime DeletedAt;
        public User DeletedBy;

        public Sector()
        {

        }

        public Sector(SectorDTO sectorDTO)
        {
            Id = sectorDTO.Id;
            Name = sectorDTO.Name;
            CreatedAt = sectorDTO.CreatedAt;
            DeletedAt = sectorDTO.DeletedAt;
            DeletedBy = sectorDTO.DeletedBy;
        }

        public void Upadate()
        {
            throw new NotImplementedException();
        }
    }
}
