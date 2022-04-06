using DataStructures.Stack;
using DataStructures.Stack.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace StackTest
{
    public class LinkedListStackTest
    {
        private readonly IStack<char> _stack;
        public LinkedListStackTest()
        {
            _stack = new LinkedListStack<char>(new char[] { 's', 'e', 'l', 'a', 'm' });

        }
        [Fact]
        public void Count_Test()
        {
            //act
            var count = _stack.Count;

            //assert
            Assert.Equal(5, count);

        }

        [Fact]
        public void Pop_Test()
        {
            //act
            var pop = _stack.Pop();

            //Assert
            Assert.Equal('m', pop);
            
            Assert.Collection(_stack,
                item =>Assert.Equal('a',item),
                item => Assert.Equal('l', item),
                item => Assert.Equal('e', item),
                item => Assert.Equal('s', item));
            
        }

        [Theory]
        [InlineData('m')]
        [InlineData('e')]
        [InlineData('r')]
        [InlineData('h')]
        [InlineData('a')]
        [InlineData('b')]
        [InlineData('a')]
        public void Push_Test(char item)
        {
            //act
            _stack.Push(item);

            //assert
            Assert.Equal(item, _stack.Peek());
        }
    }
}
