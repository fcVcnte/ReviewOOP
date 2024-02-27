using ReviewOOP.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewOOP.ContentContext
{
    public class CareerItem : Entity
    {
        public CareerItem(int order, string title, string description, Course course)
        {
            if (course == null)
                throw new Exception("The course can't be null");
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Course Course { get; set; }
    }
}
