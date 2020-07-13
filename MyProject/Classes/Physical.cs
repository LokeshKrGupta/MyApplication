using MyProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Classes
{
    class Physical : IPayment, ICommission
    {
        public string ExecuteRule()
        {
            return "Physical Rule";
        }

        public string GenerateCommission()
        {
            return "Physical Commission";
        }
    }
}
