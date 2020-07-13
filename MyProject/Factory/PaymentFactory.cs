using System;
using System.Collections.Generic;
using System.Text;
using MyProject.Classes;
using MyProject.Interface;
using static MyProject.Enum.Enums;

namespace MyProject.Factory
{
    public class PaymentFactory
    {
        public static IPayment GetPayment(PaymentTypeEnum paymentType)
        {
            IPayment payment = null;
            switch (paymentType)
            {
                case PaymentTypeEnum.Physical:
                    payment = new Physical();
                    break;
                case PaymentTypeEnum.Book:
                    payment = new Book();
                    break;
                case PaymentTypeEnum.Membership:
                    payment = new Membership();
                    break;
                case PaymentTypeEnum.Upgrade:
                    payment = new Upgrade();
                    break;
                case PaymentTypeEnum.LearningToSki:
                    payment = new LearningToSki();
                    break;
            }
            return payment;
        }
    }
}
