using NUnit.Framework;
using Testing_the_Return_Type_of_Method3_4.Fundamentals;
using Assert = NUnit.Framework.Assert;

namespace CustomerControllerUnitTest3_4
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);

            // NotFound
            Assert.That(result, Is.TypeOf<NotFound>());

            // NotFound or one of its derivativer
            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnNotOk()
        {

        }

    }
}
