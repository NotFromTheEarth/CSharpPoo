using Tigrao.NotificationContext;
using System;

namespace Tigrao.SharedContext;

public abstract class Base : Notifiable
{
    public Base()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
}