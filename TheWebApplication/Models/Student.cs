﻿using System;
using System.Collections.Generic;

namespace TheWebApplication.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}