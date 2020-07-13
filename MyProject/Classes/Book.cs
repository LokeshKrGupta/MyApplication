using MyProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Classes
{
    class Book : IPayment, ICommission
    {
        public string ExecuteRule()
        {
            return "Book Rule";
        }

        public string GenerateCommission()
        {
            return "Book Commission";
        }
    }
}
