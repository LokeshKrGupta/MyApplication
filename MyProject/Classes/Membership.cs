using MyProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Classes
{
    class Membership : IPayment, IEmail
    {
        public string ExecuteRule()
        {
            return "Membership Rule";
        }

        public string SendMail()
        {
            return "Membership Email";
        }
    }
}
