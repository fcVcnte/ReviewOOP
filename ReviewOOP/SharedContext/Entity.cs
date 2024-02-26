﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewOOP.SharedContext
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;

        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
