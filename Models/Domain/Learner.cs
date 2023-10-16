using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ctutrainingsolutions.Models.Domain
{
    public class Learner
    {
        public Guid LearnerId { get; set; }

        public string  LearnerName { get; set; }
        public string LearnerSurname { get; set; }

        public string LearnerCellPhoneNumber { get; set; }

        //Link table
        public Guid ParentId { get; set; }

        //Navigation property

        public Parent Parent { get; set; }
       



    }
}