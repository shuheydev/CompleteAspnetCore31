﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompleteAspnetCore31.Models
{
    public class DetailsLeaveTypeVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }

    public class CreateLeaveTypeVM
    {
        [Required]
        public string Name { get; set; }
    }
}
