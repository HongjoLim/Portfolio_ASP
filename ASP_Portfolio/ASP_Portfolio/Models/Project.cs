﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Portfolio.Models
{
    public class Project : BaseModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
