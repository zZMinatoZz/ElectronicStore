using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Ordering.Domain.Events
{
    public record OrderCreatedEvent(Order order) : IDomainEvent;
}