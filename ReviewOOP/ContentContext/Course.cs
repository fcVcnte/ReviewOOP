﻿using ReviewOOP.ContentContext.Enums;
using ReviewOOP.SharedContext;

namespace ReviewOOP.ContentContext
{
    public class Course : Entity
    {
        public string Tag { get; set; } = string.Empty;
        public ICollection<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
        public Course(string title, string url)
            : base(title, url)
        {
            Modules = new List<Module>();
        }
    }
}
