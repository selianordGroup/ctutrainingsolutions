using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ctutrainingsolutions.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double LenghtInKm { get; set; }

        public string? WalkImageUrl { get; set; }

        //Navigation properties

        public Difficulty Difficulty { get; set; }
        public Region Region { get; set; }
    }
}