﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Students_Groups_LINQ_
{
    public class GroupWithStudents
    {
        public string Name { get; set; }
        public double AvgRating { get; set; }
        public IEnumerable<string> Students { get; set; }
    }
}