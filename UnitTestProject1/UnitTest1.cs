using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProject.Interface;
using MyProject.Factory;
using static MyProject.Enum.Enums;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        IPayment payment;
        ICommission commission;
        IEmail email;
        string returnMsg;

        [TestMethod]
        public void TestPhysicalRule()
        {
            payment = PaymentFactory.GetPayment(PaymentTypeEnum.Physical);
            returnMsg = payment.ExecuteRule();
            Assert.AreEqual(returnMsg, "Physical Rule");
        }

        [TestMethod]
        public void TestPhysicalCommission()
        {
            payment = PaymentFactory.GetPayment(PaymentTypeEnum.Physical);
            commission = payment as ICommission;
            returnMsg = commission.GenerateCommission();
            Assert.AreEqual(returnMsg, "Physical Commission");
        }

        [TestMethod]
        public void TestBookRule()
        {
            payment = PaymentFactory.GetPayment(PaymentTypeEnum.Book);
            returnMsg = payment.ExecuteRule();
            Assert.AreEqual(returnMsg, "Book Rule");
        }

        [TestMethod]
        public void TestBookCommission()
        {
            payment = PaymentFactory.GetPayment(PaymentTypeEnum.Book);
            commission = payment as ICommission;
            returnMsg = commission.GenerateCommission();
            Assert.AreEqual(returnMsg, "Book Commission");
        }

        [TestMethod]
        public void TestMembershipRule()
        {
            payment = PaymentFactory.GetPayment(PaymentTypeEnum.Membership);
            returnMsg = payment.ExecuteRule();
            Assert.AreEqual(returnMsg, "Membership Rule");
        }

        [TestMethod]
        public void TestMembershipEmail()
        {
            payment = PaymentFactory.GetPayment(PaymentTypeEnum.Membership);
            email = payment as IEmail;
            returnMsg = email.SendMail();
            Assert.AreEqual(returnMsg, "Membership Email");
        }

        [TestMethod]
        public void TestUpgradeRule()
        {
            payment = PaymentFactory.GetPayment(PaymentTypeEnum.Upgrade);
            returnMsg = payment.ExecuteRule();
            Assert.AreEqual(returnMsg, "Upgrade Rule");
        }

        [TestMethod]
        public void TestUpgradeEmail()
        {
            payment = PaymentFactory.GetPayment(PaymentTypeEnum.Upgrade);
            email = payment as IEmail;
            returnMsg = email.SendMail();
            Assert.AreEqual(returnMsg, "Upgrade Email");
        }

        [TestMethod]
        public void TestLearnToSkiRule()
        {
            payment = PaymentFactory.GetPayment(PaymentTypeEnum.LearningToSki);
            returnMsg = payment.ExecuteRule();
            Assert.AreEqual(returnMsg, "LearningToSki Rule");
        }

    }
}
