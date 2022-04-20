using FisherSite.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherSite.Management.Application.DTOs
{
    public class ApartmentDTO
    {
        public int Id { get; set; }
        public int BlockId { get; set; }
        public int ApartmentStateId { get; set; }
        public int ApartmentTypeId { get; set; }
        public Floor ApartmentFloor { get; set; }

        public int Dues { get; set; }
        public int? PersonId { get; set; }
    }
}
