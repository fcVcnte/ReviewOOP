using ReviewOOP.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewOOP.SubscriptionContext
{
    public class Plan : Entity
    {
        public string Title { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
