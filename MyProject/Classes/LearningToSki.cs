using MyProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Classes
{
    class LearningToSki : IPayment
    {
        public string ExecuteRule()
        {
            return "LearningToSki Rule";
        }
    }
}
