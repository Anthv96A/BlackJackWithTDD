using BlackJack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJack_Tests
{
    [TestClass]
    public class DetermineIsBust_Tests
    {
        [TestMethod]
        public void Given_I_have_a_total_of_10_I_expect_to_be_false()
        {
            // Given I have a total of 10
            var total = 10;

            // When I call the bust method
            IBust bust = new Bust();
            bool result = bust.IsBust(total);

            // Then I expect to get back false
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_I_have_a_total_of_20_I_expect_to_be_false()
        {
            // Given I have a total of 20
            var total = 20;

            // When I call the bust method
            IBust bust = new Bust();
            bool result = bust.IsBust(total);

            // Then I expect to get back false
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_I_have_a_total_of_21_I_expect_to_be_false()
        {
            // Given I have a total of 21
            var total = 21;

            // When I call the bust method
            IBust bust = new Bust();
            bool result = bust.IsBust(total);

            // Then I expect to get back false
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_I_have_a_total_of_22_I_expect_to_be_true()
        {
            // Given I have a total of 22
            var total = 22;

            // When I call the bust method
            IBust bust = new Bust();
            bool result = bust.IsBust(total);

            // Then I expect to get back true
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Given_I_have_a_total_of_24_I_expect_to_be_true()
        {
            // Given I have a total of 24
            var total = 24;

            // When I call the bust method
            IBust bust = new Bust();
            bool result = bust.IsBust(total);

            // Then I expect to get back true
            Assert.IsTrue(result);
        }
    }
}
