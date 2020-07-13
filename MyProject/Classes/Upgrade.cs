using MyProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Classes
{
    class Upgrade : IPayment, IEmail
    {
        public string ExecuteRule()
        {
            return "Upgrade Rule";
        }

        public string SendMail()
        {
            return "Upgrade Email";
        }
    }
}
