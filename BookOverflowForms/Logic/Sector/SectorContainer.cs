using BookOverflowForms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOverflowForms.Logic
{
    class SectorContainer
    {
        private readonly SectorDAL _sectorDAL;

        public SectorContainer()
        {
            _sectorDAL = new SectorDAL();
        }

        public List<Sector> GetAllSectors()
        {
            var sectors = new List<Sector>();
            var sectorDTOs = _sectorDAL.GetAll();

            foreach (var sectorDTO in sectorDTOs)
            {
                sectors.Add(new Sector(sectorDTO));
            }

            return sectors;
        }

        public Sector GetSectorById(int id)
        {
            return new Sector(_sectorDAL.GetById(id));
        }
    }
}
