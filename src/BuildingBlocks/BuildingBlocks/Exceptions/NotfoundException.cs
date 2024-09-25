using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingBlocks.Exceptions;
public class NotfoundException : Exception
{
    public NotfoundException(string message) : base(message) { }
    public NotfoundException(string name, object key) : base($"Entity \"{name}\" ({key}) was not found") { }

}