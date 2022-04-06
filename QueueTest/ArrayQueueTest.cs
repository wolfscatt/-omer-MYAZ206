using DataStructures.Queue;
using Xunit;

namespace QueueTest
{
    public class ArrayQueueTest
    {
        private readonly ArrayQueue<int> _queue;
        public ArrayQueueTest()
        {
            _queue = new ArrayQueue<int>(new int[] { 10, 20, 30 });
        }
        [Fact]
        public void Count_Test()
        {
            //act
            var count = _queue.Count;

            //assert
            Assert.Equal(3, count);
        }

        [Theory]
        [InlineData(13)]
        [InlineData(9)]
        [InlineData(53)]
        [InlineData(11)]
        [InlineData(34)]
        public void EnQueue_Test(int value)
        {
            //10 20 30 [value]
            //act
            _queue.EnQueue(value);

            //assert
            Assert.Equal(4, _queue.Count);

            Assert.Collection(_queue,
                item => Assert.Equal(10, item),
                item => Assert.Equal(20, item),
                item => Assert.Equal(30, item),
                item => Assert.Equal(value, item));
        }

        [Fact]
        public void DeQueue_Test()
        {
            //act
            var result = _queue.DeQueue();

            //assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void Peek_Test()
        {
            //act
            var peek = _queue.Peek();

            //assert
            Assert.Equal(10, peek);
            Assert.Equal(3,_queue.Count);
        }

        [Fact]
        public void DeQueue_EmptyQueueException_Test()
        {
            //act
            _queue.DeQueue();
            _queue.DeQueue();
            _queue.DeQueue();

            //assert
            Assert.Throws<EmptyQueueException>(() => _queue.DeQueue());
        }
    }
}