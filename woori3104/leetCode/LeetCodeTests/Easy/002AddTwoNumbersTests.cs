using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.Tests
{
    [TestClass()]
    public class AddTwoNumbersTests
    {
        public void InsertNode(int data, ref ListNode results)
        {
            ListNode newNode = new ListNode();    // 새로운 노드 생성
            newNode.val = data;
            if (results == null) {
                // head 노드가 null인 경우 새로운 노드를 참조하도록 함
                results = newNode;
            }
            else {

                // head 노드가 null이 아닌 경우 temp 노드가 head를 참조.
                // tempNode는 마지막 노드를 찾아서 참조하기 위해 사용.
                ListNode tempNode = results;
                // temp 노드의 link가 null이 아닐 때까지 다음 노드를 참조.
                // tempNode.link는 다음 노드를 참조하고 있으므로,
                // tempNode = tempNode.link는 tempNode에 다음 노드를 참조하도록 하는 것.
                // while문이 모두 실행되면 tempNode는 가장 마지막 노드를 참조하게 됨.
                while (tempNode.next != null) {
                    tempNode = tempNode.next;    // 다음 노드를 참조

                }
                // tempNode(마지막 노드)의 link가 다음 노드를 참조하도록 함. 
                tempNode.next = newNode;
            }
        }

        [TestMethod()]
        public void AddTwoNumbersTest01()
        {
            ListNode l1 = null;
            ListNode l2 = null;
            var c = new AddTwoNumbersClass();

            int[] l1array = { 2, 4, 3 };
            int[] l2array = { 5, 6, 4 };
            for (var i = 0; i < l1array.Length; i++)
                InsertNode(l1array[i], ref l1);
            for (var i = 0; i < l2array.Length; i++)
                InsertNode(l2array[i], ref l2);

            // example1
            var result = c.AddTwoNumbers(l1, l2);

            int[] expected = { 7, 0, 8 };

            for (var i = 0; i < expected.Length; i++) {
                Assert.AreEqual(expected[i], result.val);
                result = result.next;
            }
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void AddTwoNumbersTest02()
        {
            ListNode l1 = null;
            ListNode l2 = null;
            var c = new AddTwoNumbersClass();

            int[] l1array = { 0 };
            int[] l2array = { 0 };
            for (var i = 0; i < l1array.Length; i++)
                InsertNode(l1array[i], ref l1);
            for (var i = 0; i < l2array.Length; i++)
                InsertNode(l2array[i], ref l2);

            // example1
            var result = c.AddTwoNumbers(l1, l2);

            int[] expected = { 0 };

            for (var i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result.val);
                result = result.next;
            }
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void AddTwoNumbersTest03()
        {
            ListNode l1 = null;
            ListNode l2 = null;
            var c = new AddTwoNumbersClass();

            int[] l1array = { 9, 9, 9, 9, 9, 9, 9 };
            int[] l2array = { 9, 9, 9, 9 };
            for (var i = 0; i < l1array.Length; i++)
                InsertNode(l1array[i], ref l1);
            for (var i = 0; i < l2array.Length; i++)
                InsertNode(l2array[i], ref l2);

            // example1
            var result = c.AddTwoNumbers(l1, l2);

            int[] expected = { 8, 9, 9, 9, 0, 0, 0, 1 };

            for (var i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result.val);
                result = result.next;
            }
            Assert.IsNull(result);
        }
    }
}