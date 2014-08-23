using WinFormEx;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace TestWinFormEx
{
    
    
    /// <summary>
    ///This is a test class for DataGridViewExTest and is intended
    ///to contain all DataGridViewExTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DataGridViewExTest
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
        ///A test for DataGridViewEx Constructor
        ///</summary>
        [TestMethod()]
        public void DataGridViewExConstructorTest()
        {
            DataGridView dgv = null; // TODO: Initialize to an appropriate value
            DataGridViewEx target = new DataGridViewEx(dgv);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CellEndEdit
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WinFormEx.exe")]
        public void CellEndEditTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            DataGridViewEx_Accessor target = new DataGridViewEx_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DataGridViewCellEventArgs e = null; // TODO: Initialize to an appropriate value
            target.CellEndEdit(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for IsSimpleType
        ///</summary>
        [TestMethod()]
        public void IsSimpleTypeTest()
        {
            DataGridView dgv = null; // TODO: Initialize to an appropriate value
            DataGridViewEx target = new DataGridViewEx(dgv); // TODO: Initialize to an appropriate value
            Type t = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsSimpleType(t);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetObj
        ///</summary>
        [TestMethod()]
        public void SetObjTest()
        {
            DataGridView dgv = null; // TODO: Initialize to an appropriate value
            DataGridViewEx target = new DataGridViewEx(dgv); // TODO: Initialize to an appropriate value
            object obj = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.SetObj(obj);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
