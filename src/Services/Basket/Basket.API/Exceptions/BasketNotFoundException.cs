using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Basket.API.Exceptions;
public class BasketNotFoundException : NotfoundException
{
    public BasketNotFoundException(string userName) : base("Basket", userName)
    {

    }
}