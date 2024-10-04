using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildingBlocks.Exceptions;

namespace Ordering.Application.Exceptions
{
    public class OrderNotFoundException : NotfoundException
    {
        public OrderNotFoundException(Guid id) : base("Order", id)
        {

        }
    }
}