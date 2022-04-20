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
        public int? PersonId { get; set; }
        public int Dues
        {
            get
            {
                if (ApartmentStateId != 1)
                {
                    if (ApartmentTypeId == 1)
                    {
                        return 100;
                    }
                    else if (ApartmentTypeId == 2)
                    {
                        return 200;
                    }
                    else
                    {
                        return ApartmentTypeId == 3 ? 300 : 400;
                    }
                }
                else
                {
                    return 0;
                }
            }
        }

        public Block Block { get; set; }
        public ApartmentState ApartmentState { get; set; }
        public ApartmentType ApartmentType { get; set; }
        public Person Person { get; set; }
    }
}
