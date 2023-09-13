﻿using System;
using System.Collections.Generic;
using ConsoleApp10.Data.Common;
using ConsoleApp10.Data.Common;
using ConsoleApp10.Data.Models;

namespace ConsoleApp10.Data.Models
{
    public class Classroom : BaseModel
    {
        private static int id = 0;

        public Classroom()
        {
            Id = id;
            id++;
        }

        public string Name { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public List<Student> Students { get; set; } = new();
    }
}