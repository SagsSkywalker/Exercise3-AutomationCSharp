using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise3_AutomationCSharp
{
    [TestClass]
    public class UnitTest1
    {
        //INSTRUCTIONS FOR THIS EXERCISE
        //Create a 2 layer framework - DONE - POM and Base
        //Set Up class with Browser Creation, Element Interaction and Waits implementations
        //Read Config file Class – Implement a method to read XML files
        //Dependency on Framework Project
        //Page Objects for each application functionality
        //Repeat the same flow using Specflow and MSTest
        //Use configuration file for URL and username and password.
        //Use Nuget package manager for download all needed
        [TestMethod]
        public void TestMethod1() {
            //Go to Amazon.com.mx
            //Login with valid credentials
            //Search for product: Samsung Galaxy S9 64GB
            //Select first product and save the price
            //Click on the product
            //Validate first price vs detail price
            //Click on Add to Cart
            //Validate again, first price vs current price
            //Validate that the Shop car has 1 as a number
            //Search for another product: Alienware Aw3418DW
            //Select First product
            //Add to Cart
            //Verify that the cart number is now 2
            //End of test
        }
    }
}
