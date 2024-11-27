using CL48;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Cl48.Tests
{
    [TestClass]
    public class UseTwoRecordsTests
    {
        [TestMethod]
        public void ShouldSumTwoInts()
        {
            UseTwoRecords sut = new UseTwoRecords(1, 2);
            int actual = sut.RecordSum();
            actual.Should().Be(3);
            }
    }
}
