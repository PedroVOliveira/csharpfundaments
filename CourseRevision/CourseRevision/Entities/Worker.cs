using System;
using System.Collections.Generic;
using CourseRevision.Entities.Enums;

namespace CourseRevision.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkLevel Level { get; set; }
        public double baseSalary  { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();




    }
}
