using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherSite.Domain
{
    public class Apartment
    {
        public int Id { get; set; }
        public int BlockId { get; set; }
        public int ApartmentStateId { get; set; }
        public int ApartmentTypeId { get; set; }
        public Floor ApartmentFloor { get; set; }
        public int PersonId { get; set; }

        public Block Block { get; set; }
        public ApartmentState ApartmentState { get; set; }
        public ApartmentType ApartmentType { get; set; }
        public Person Person { get; set; }
    }
}
