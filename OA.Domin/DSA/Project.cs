using OA.Domin.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }

        public string OwnerName { get; set; }

        public string Papers { get; set; }

        public int WorkerCount { get; set; }

        public string TimePlan { get; set; }

        public decimal EstimatedCost { get; set; }

        public string Location { get; set; }

        public string Info { get; set; }

        public string SupervisorName { get; set; }

        public string SupervisorPhone { get; set; }

        public string SupervisorEmail { get; set; }

        [PropFlag("IGNORE")]
        public string CreatedUserType { get; set; }

        [PropFlag("IGNORE")]
        public string CreatedUserId { get; set; }

    }
}
