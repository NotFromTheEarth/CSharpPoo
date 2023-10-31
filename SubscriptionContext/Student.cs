using System.Collections.Generic;
using SubscriptionContext;
using Tigrao.SharedContext;
using System;
using System.Linq;
using Tigrao.NotificationContext;

namespace Tigrao.SubscriptionContext;

public class Student : Base
{
    public Student()
    {
        Subscriptions = new List<Subscription>();
    }
    
    public string Name { get; set; }
    public string Email { get; set; }
    public User User { get; set; }
    public List<Subscription> Subscriptions { get; set; }
    public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

    public void CreateSubscription(Subscription subscription)
    {
        if(IsPremium)
        {
            AddNotification(new Notification("Premium", "O aluno já tem uma assinatura ativa."));
            return;
        }

        Subscriptions.Add(subscription);
    }
}