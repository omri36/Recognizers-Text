﻿using Microsoft.Recognizers.Text.DataDrivenTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Recognizers.Text.Number.Tests
{
    [TestClass]
    public class TestNumber_Swedish : TestBase
    {
        /*
        [NetCoreTestDataSource]
        [TestMethod]
        public void OrdinalModelSuppressExtendedTypes(TestModel testSpec)
        {
            TestNumber(testSpec);
        }
        */

        [NetCoreTestDataSource]
        [TestMethod]
        public void NumberModel(TestModel testSpec)
        {
            TestNumber(testSpec);
        }

        /*
        [NetCoreTestDataSource]
        [TestMethod]
        public void NumberModelPercentMode(TestModel testSpec)
        {
            TestNumber(testSpec);
        }
        */

        /*
        [NetCoreTestDataSource]
        [TestMethod]
        public void NumberModelExperimentalMode(TestModel testSpec)
        {
            TestNumber(testSpec);
        }
        */

        [NetCoreTestDataSource]
        [TestMethod]
        public void OrdinalModel(TestModel testSpec)
        {
            TestNumber(testSpec);
        }

        [NetCoreTestDataSource]
        [TestMethod]
        public void PercentModel(TestModel testSpec)
        {
            TestNumber(testSpec);
        }

        /*
        [NetCoreTestDataSource]
        [TestMethod]
        public void PercentModelPercentMode(TestModel testSpec)
        {
            TestNumber(testSpec);
        }
        */

        /*
        [NetCoreTestDataSource]
        [TestMethod]
        public void NumberRangeModel(TestModel testSpec)
        {
            TestNumber(testSpec);
        }
        */

        /*
        [NetCoreTestDataSource]
        [TestMethod]
        public void NumberRangeModelExperimentalMode(TestModel testSpec)
        {
            TestNumber(testSpec);
        }
        */
    }
}