using System;
using System.Collections.Generic;
using System.Text;
using MyProject.Interface;
using static MyProject.Enum.Enums;

namespace MyProject.Factory
{
    public class PaymentFactory
    {
        public static IPayment GetPayment(PaymentTypeEnum paymentType)
        {
            IPayment payment = null;
            return payment;
        }
    }
}
