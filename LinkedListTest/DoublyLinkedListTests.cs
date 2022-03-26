using DataStructures.LinkedList.DoublyLinkedList;
using System;
using Xunit;

namespace LinkedListTest
{
    public class DoublyLinkedListTests
    {
        private DoublyLinkedList<char> _list;
        // arrange
        public DoublyLinkedListTests()
        {
            // z  a
            _list = new DoublyLinkedList<char>(new char[] { 'a', 'z' });
        }

        [Theory]
        [InlineData('b')]
        [InlineData('ö')]
        [InlineData('c')]
        public void AddFirst_Test(char value)
        {
            // act
            _list.AddFirst(value);

            //assert
            Assert.Equal(value, _list.Head.Value);
        }

        [Fact]
        public void Count_Test()
        {
            //act
            var count = _list.Count;

            //assert
            Assert.Equal(2, count);
        }

        [Theory]
        [InlineData('B')]
        [InlineData('Ö')]
        [InlineData('k')]
        public void AddLast_Test(char value)
        {
            // a  z [value]
            // act
            _list.AddLast(value);
            var listTailValue = _list.Tail.Value;

            //assert
            Assert.Equal(value, listTailValue);
            Assert.Collection(_list,
                item => Assert.Equal('a', item),
                item => Assert.Equal('z', item),
                item => Assert.Equal(value, item));
        }
        [Theory]
        [InlineData('B')]
        [InlineData('Ö')]
        [InlineData('k')]
        public void AddBefore_Test(char value)
        {
            // _list : a [value] z 
            // act
            _list.AddBefore(_list.Head.Next, value);

            // Assert
            Assert.Equal(value, _list.Head.Next.Value);

            Assert.Collection(_list,
                item => Assert.Equal('a', item),
                item => Assert.Equal(value, item),
                item => Assert.Equal('z', item));
        }

        [Fact]
        public void AddBefore_ArgumentException_Test()
        {
            DbNode<char> node = new DbNode<char>('l');

            //Assert
            Assert.Throws<ArgumentException>(() =>
            _list.AddBefore(node, node.Value));
        }

        [Theory]
        [InlineData('B')]
        [InlineData('Ö')]
        [InlineData('k')]
        public void AddAfter_Test(char value)
        {
            // _list : a [value] z 
            // act
            _list.AddAfter(_list.Head, value);

            // Assert
            Assert.Equal(value, _list.Head.Next.Value);

            Assert.Collection(_list,
                item => Assert.Equal(_list.Head.Value, item),
                item => Assert.Equal(value, item),
                item => Assert.Equal(_list.Tail.Value, item));
        }

        [Fact]
        public void RemoveFirst_Test()
        {
            // a  z
            //act 
            _list.RemoveFirst();

            //assert
            Assert.Equal('z', _list.Head.Value);
        }

        [Fact]
        public void RemoveLast_Test()
        {
            //act
            _list.RemoveLast();

            //assert
            Assert.Equal('a', _list.Tail.Value);
        }

        [Fact]
        public void Remove_Test()
        {
            //act
            _list.Remove('a');

            //assert
            Assert.Equal('z', _list.Head.Value);
        }

        [Fact]
        public void ToList_Test()
        {
            //act 
            var list = _list.ToList();

            //assert
            Assert.Collection(list,
                item => Assert.Equal(_list.Head.Value, item),
                item => Assert.Equal(_list.Head.Next.Value, item));
        }
    }
}
