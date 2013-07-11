using QuizNightScorer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for ScorerTest and is intended
    ///to contain all ScorerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ScorerTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for AdultScore
        ///</summary>
        [TestMethod()]
        public void AdultScoreTest()
        {
            Scorer target = new Scorer(); // TODO: Initialize to an appropriate value
            int x = 1; // TODO: Initialize to an appropriate value
            int y = 1; // TODO: Initialize to an appropriate value
            int expected = 9; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.AdultScore(x, y);
            Assert.AreEqual(expected, actual);
           
        }

        /// <summary>
        ///A test for ChildScore
        ///</summary>
        [TestMethod()]
        public void ChildScoreTest()
        {
            Scorer target = new Scorer(); // TODO: Initialize to an appropriate value
            int x = 0; // TODO: Initialize to an appropriate value
            int y = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.ChildScore(x, y);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
