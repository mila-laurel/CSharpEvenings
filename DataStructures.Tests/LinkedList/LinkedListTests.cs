using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.Tests.LinkedList
{
    [TestFixture]
    class LinkedListTests
    {
        //F.I.R.S.T
        // fast
        // independent
        // repeatable
        // self-validating
        // timely
        // TDD test driven development
        DataStructures.LinkedList.LinkedList<int> _linkedList;

        [SetUp]
        public void Setup()
        {
            _linkedList = new DataStructures.LinkedList.LinkedList<int>();
        }

        [Test]
        public void TestAdd_ShouldAddElements()
        {
            //arrange
            //var linkedList = new DataStructures.LinkedList.LinkedList<int>(); //create SUT
            //act
            _linkedList.Add(1);
            _linkedList.Add(2);
            _linkedList.Add(3);
            //assert
            var result = _linkedList.ToArray();
            result.Should().BeEquivalentTo(new [] {3, 2, 1});
        }
    }
}
