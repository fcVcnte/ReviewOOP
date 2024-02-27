using ReviewOOP.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewOOP.SubscriptionContext
{
    public class Student : Entity
    {
        public User User { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

        public Student()
        {
            Subscriptions = new List<Subscription>();
        }

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new NotificationContext
                    .Notification("Premium", "The student is already subscribed"));
                return;
            }
            Subscriptions.Add(subscription);
        }
    }
}
