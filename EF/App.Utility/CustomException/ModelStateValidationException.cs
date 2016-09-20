using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Utility.CustomException
{
    public class ModelStateValidateException : Exception
    {
        public ModelStateValidateException(string message = "model state validation error") : base(message) { }
    }

     
}
