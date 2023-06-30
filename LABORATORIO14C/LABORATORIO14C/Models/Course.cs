﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LABORATORIO14C.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Credit { get; set; }
        public DateTime CreditStartDate { get; set; }

    }
}
