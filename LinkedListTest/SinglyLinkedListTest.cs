using Xunit;
using DataStructures.LinkedList.SinglyLinkedList;
using System;

namespace LinkedListTest
{
    public class SinglyLinkedListTest
    {
        private SinglyLinkedList<int> _list;
        public SinglyLinkedListTest()
        {
            //Arrange
            _list = new SinglyLinkedList<int>(new int[] { 5, 3 });
        }
        [Fact]
        public void Count_Test()
        {
            //act
            int count = _list.Count;

            //Assert
            Assert.Equal(2, count);
        }

        [Theory]
        [InlineData(53)]
        [InlineData(13)]
        [InlineData(9)]
        [InlineData(11)]
        public void AddFirst_Test(int value)
        {
            //act
            _list.AddFirst(value);

            //assert
            Assert.Equal(value, _list.Head.Value);

            Assert.Collection(_list,
                item => Assert.Equal(item, value),
                item => Assert.Equal(item, 3),
                item => Assert.Equal(item, 5)
                );


        }

        [Fact]
        public void GetEnumerator_Test()
        {
            //assert
            Assert.Collection(_list,
                item => Assert.Equal(item, 3),
                item => Assert.Equal(item, 5)
                );
        }

        [Theory]
        [InlineData(13)]
        [InlineData(9)]
        [InlineData(1)]
        public void AddLast_Test(int value)
        {
            //act
            _list.AddLast(value);

            //Assert
            Assert.Collection(_list,
                item => Assert.Equal(3, item),
                item => Assert.Equal(5, item),
                item => Assert.Equal(value, item)
            );
        }
        [Theory]
        [InlineData(13)]
        [InlineData(9)]
        [InlineData(1)]
        public void AddBefore_Test(int value)
        {
            //act
            _list.AddBefore(_list.Head.Next, value);

            //assert
            Assert.Collection(_list,
               item => Assert.Equal(3, item),
               item => Assert.Equal(value, item),
               item => Assert.Equal(5, item));

        }

        [Fact]
        public void AddBefore_ArgumentException_Test()
        {
            //act
            var Node = new SinglyLinkedListNode<int>(53);

            //assert
            Assert.Throws<ArgumentException>(() => _list.AddBefore(Node, 55));

        }

        [Theory]
        [InlineData(13)]
        [InlineData(9)]
        [InlineData(1)]
        public void AddAfter_Test(int value)
        {
            //act
            _list.AddAfter(_list.Head, value);

            //assert
            Assert.Collection(_list,
               item => Assert.Equal(3, item),
               item => Assert.Equal(value, item),
               item => Assert.Equal(5, item));

        }

        [Fact]
        public void AddAfter_ArgumentException_Test()
        {
            //act
            var Node = new SinglyLinkedListNode<int>(53);

            //assert
            Assert.Throws<ArgumentException>(() => _list.AddAfter(Node, 55));

        }

        [Fact]
        public void RemoveFirst_Test()
        {
            // 3  5
            //act
            _list.RemoveFirst();

            //assert
            Assert.Collection(_list, item => Assert.Equal(5, item));
        }
        [Fact]
        public void RemoveFirst_Exception_Test()
        {
            // 3  5
            //act
            _list.RemoveFirst();
            _list.RemoveFirst();


            //assert
            Assert.Throws<Exception>(() => _list.RemoveFirst());
        }

        [Fact]
        public void RemoveLast_Test()
        {
            // 3  5
            //act
            var result = _list.RemoveLast();

            //assert
            Assert.Collection(_list, item => Assert.Equal(3, item));

            Assert.Equal(5, result);
        }

        [Theory]
        [InlineData(3)]
        public void Remove_Test(int value)
        {
            // 3  5  
            //act
            _list.AddFirst(13); //13 3 5
            _list.Remove(value);

            //assert
            Assert.Collection(_list, 
                item => Assert.Equal(13, item),
                item => Assert.Equal(5, item)

                );
        }

    }
}