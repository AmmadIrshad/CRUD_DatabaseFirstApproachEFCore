﻿using System;
using System.Collections.Generic;

namespace CRUD_DatabaseFirstApproachEFCore.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string? StudentName { get; set; }
        public string? StudentGender { get; set; }
        public int Age { get; set; }
        public string? Standard { get; set; }
    }
}
