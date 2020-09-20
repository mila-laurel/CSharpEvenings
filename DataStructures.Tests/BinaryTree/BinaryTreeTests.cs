using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructures.BinaryTree;
using DataStructures.LinkedList;
using FluentAssertions;
using FluentAssertions.Extensions;
using NUnit.Framework;

namespace DataStructures.Tests.BinaryTree
{
    [TestFixture]
    class BinaryTreeTests
    {
        DataStructures.BinaryTree.BinaryTree<int> _binaryTree;

        [SetUp]
        public void Setup()
        {
            _binaryTree = new DataStructures.BinaryTree.BinaryTree<int>(15);
            TreeNode<int> parent = _binaryTree.Root;
            parent.LeftChild = new TreeNode<int>(1, null, new TreeNode<int>(3, new TreeNode<int>(2), new TreeNode<int>(14)));
            parent.RightChild = new TreeNode<int>(20, new TreeNode<int>(16), new TreeNode<int>(28, new TreeNode<int>(25)));
        }

        [Test]
        public void TestAdd_ShouldAddElements()
        {
            _binaryTree.Add(4);
            _binaryTree.Add(30);

            var result = new int[]{ _binaryTree.Root.LeftChild.RightChild.RightChild.LeftChild.Data, _binaryTree.Root.RightChild.RightChild.RightChild.Data };
            result.Should().BeEquivalentTo(new int[] { 4, 30 });
        }

        [TestCase(3, new int[] { 2, 14 })]
        [TestCase(666, new int[] { 3, 14 })]
        public void TestRemove_ShouldRemoveElementIfExists(int element, int[] expectedResult)
        {
            _binaryTree.Remove(element);
            var result = new int[] { _binaryTree.Root.LeftChild.RightChild.Data, _binaryTree.Root.LeftChild.RightChild.RightChild.Data };
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
