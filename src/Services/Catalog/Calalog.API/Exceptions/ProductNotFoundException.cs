using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calalog.API.Exceptions;

public class ProductNotFoundException : NotfoundException
{
    public ProductNotFoundException(Guid Id) : base("Product", Id)
    {

    }
}