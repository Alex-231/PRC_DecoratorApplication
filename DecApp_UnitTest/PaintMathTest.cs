using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecApp_UnitTest
{
    [TestClass]
    public class PaintMathTest
    {
        [TestMethod]
        public void CalculateTotal_ShouldHandleErrors_ShouldReturnCorrectDecimal()
        //public string CalculateTotal(string subTotal, string vat, string discount) //Learning...
        {
            //I'd like to add a new method to the invoice class!
            //And I feel like testing!

            //Arrange

            string subTotal = "2";
            string vat = "4";
            string discount = "2.5";

            //As you can see, I have a lot of strings that look like they should be decimals.
            //This really doesn't matter, because the user does not have enough control to make them anything other than parsable.
            //However, I should really try parse them anyway, its good practice.
            //Or even store them as decimals and convert those to strings.
            //Anyway...

            //Act

            //Assert
            //Assert.AreEqual("3.5", Total);
        }
    }
}
