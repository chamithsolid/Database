using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Utility
{
    public class ObjectNotFoundException : Exception
    {
        public ObjectNotFoundException(string message = "object is not found") : base(message) { }
    }
}
