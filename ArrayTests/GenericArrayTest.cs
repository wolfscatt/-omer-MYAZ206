using DataStructures.Array.Generic;
using System.Collections.Generic;
using Xunit;

namespace ArrayTests
{
    public class GenericArrayTest
    {
        private Array<char> _array;
        public GenericArrayTest()
        {
            // arrange
            _array = new Array<char>(new List<char> {'s','a','m','u'});
        }
        [Theory]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        public void DefaultSize_Test(int defaultSize)
        {
            //Act
            var arr=new Array<char>(defaultSize);

            //Assert
            Assert.Equal(arr.Lenght,defaultSize);
        }

        [Fact]
        public void Params_Test()
        {
            //act
            var arr = new Array<int>(1, 2, 3,4);

            //Assert
            Assert.Equal(4,arr.Lenght);
        }

        [Fact]
        public void GetValue_Test()
        {
            //act
            var c = _array.GetValue(0);

            //assert
            Assert.Equal('s',c);
            Assert.IsType<char>(c);
            Assert.True(c is char);
        }

        [Fact]
        public void SetValue_Test()
        {
            //act
             _array.SetValue(0, 'S');

            //Assert
            Assert.Equal('S',_array.GetValue(0));
        }
    }
}
