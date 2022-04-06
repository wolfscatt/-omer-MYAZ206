using DataStructures.Stack.Contracts;
using DataStructures.Stack;
using Xunit;

namespace StackTest
{
    public class ArrayStackTest
    {

        private readonly IStack<char> _stack;
        public ArrayStackTest()
        {
            _stack = new ArrayStack<char>(new char[] {'s','e','l','a','m'});
           
        }
        [Fact]
        public void Count_Test()
        {
            //act
            var count = _stack.Count;

            //Assert
            Assert.Equal(5, count);
        }

        [Fact]
        public void Pop_Test()
        {
            //act
            var pop = _stack.Pop();

            //Assert
            Assert.Equal('m',pop );
            /*
            Assert.Collection(_stack,
                item =>Assert.Equal('a',item),
                item => Assert.Equal('l', item),
                item => Assert.Equal('e', item),
                item => Assert.Equal('s', item));
            */
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