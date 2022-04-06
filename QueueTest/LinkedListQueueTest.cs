using DataStructures.Queue;
using Xunit;

namespace QueueTest
{
    public class LinkedListQueueTest
    {
        private readonly LinkedListQueue<int> _queue;
        public LinkedListQueueTest()
        {
            _queue = new LinkedListQueue<int>(new int[] { 13, 53, 34 });
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
        [InlineData(10)]
        [InlineData(9)]
        [InlineData(53)]
        [InlineData(11)]
        [InlineData(34)]
        public void EnQueue_Test(int value)
        {
            //13 53 34 [value]
            //act
            _queue.EnQueue(value);

            //assert
            Assert.Equal(4, _queue.Count);

            Assert.Collection(_queue,
                item => Assert.Equal(13, item),
                item => Assert.Equal(53, item),
                item => Assert.Equal(34, item),
                item => Assert.Equal(value, item));
        }

        [Fact]
        public void DeQueue_Test()
        {
            //act
            var result = _queue.DeQueue();

            //assert
            Assert.Equal(13, result);
        }

        [Fact]
        public void Peek_Test()
        {
            //act
            var peek = _queue.Peek();

            //assert
            Assert.Equal(13, peek);
            Assert.Equal(3, _queue.Count);
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