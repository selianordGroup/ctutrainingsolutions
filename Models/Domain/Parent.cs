using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ctutrainingsolutions.Models.Domain
{
    public class Parent
    {
        public Guid ParentId { get; set; }
        public string ParentName { get; set; }
        public string ParentSurname { get; set; }
        public string Email { get; set; }
        public string CellphoneNumber { get; set; }
        public string? ParentImage { get; set; }

        //Links tables
        public Guid LearnerId { get; set; }

        //Navigation table
        public Learner Learner { get; set; }
    }
}