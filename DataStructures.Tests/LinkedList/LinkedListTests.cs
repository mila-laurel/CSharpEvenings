using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructures.LinkedList;
using FluentAssertions;
using FluentAssertions.Extensions;
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
            _linkedList = new DataStructures.LinkedList.LinkedList<int>(568);
            ListNode<int> nextNode = _linkedList.Head;
            nextNode = nextNode.Next = new ListNode<int>(666);
            nextNode = nextNode.Next = new ListNode<int>(0);
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
            result.Should().BeEquivalentTo(new[] { 3, 2, 1, 568, 666, 0 });
        }

        [Test]
        public void TestAddTail_ShouldAddElementsAtTheEnd()
        {
            //act
            _linkedList.AddTail(1);
            _linkedList.AddTail(2);
            _linkedList.AddTail(3);
            //assert
            var result = _linkedList.ToArray();
            result.Should().BeEquivalentTo(new[] { 568, 666, 0, 1, 2, 3 });
        }

        [TestCase(666,new int[] { 568, 0 })]
        [TestCase(-3, new int[] { 568, 666, 0 })]
        public void TestRemove_ShouldRemoveElementIfExists(int element, int[] expectedResult)
        {
            _linkedList.Remove(element);

            var result = _linkedList.ToArray();
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void GetEnumerator_ShouldReturnLinkedListEnumerator()
        {
            var result = _linkedList.ToArray();
            result.Should().BeEquivalentTo(new int[] { 568, 666, 0 });
        }

        [Test]
        public void GetEnumerator_()
        {
            var enumerable = _linkedList as IEnumerable;
            var result = new List<object>();
            foreach (var item in enumerable)
            {
                result.Add(item);
            }
            result.ToArray().Should().BeEquivalentTo(new int[] { 568, 666, 0 });
        }

        [Test]
        public void GetByIndex_ShouldReturnNode()
        {
            var result = _linkedList[1];
            result.Should().Be(666);
        }

        [TestCase(-1)]
        [TestCase(5)]
        public void Get(int index)
        {
            Assert.That(() =>_linkedList[index], Throws.Exception.TypeOf<IndexOutOfRangeException>());
        }

        [Test]
        public void SetByIndex_ShouldSetValueForNode()
        {
            _linkedList[0] = 14;
            var result = _linkedList.ToArray();
            result.Should().BeEquivalentTo(new int[] { 14, 666, 0 });
        }
    }
}
