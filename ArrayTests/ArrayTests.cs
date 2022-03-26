using DataStructures.Array;
using Xunit;

namespace ArrayTests
{
    public class ArrayTests
    {
        [Theory]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        public void Check_Array_Constructor(int defaultSize)
        {
            //Arrange  |  Act  (Hem düzenleme hem de eylem ifadesi var parametre verdiðimiz için)
            var arr = new Array(defaultSize);

            //Assert
            Assert.Equal(defaultSize, arr.Lenght);
        }

        [Fact]
        public void Check_Array_Constructor_with_Params()
        {
            //Arrange  |  Act
            var arr = new Array(1,2,3);

            //Assert
            Assert.Equal(3, arr.Lenght);

        }

        [Fact]
        public void Get_and_Set_Values_in_Array()
        {
            //Arrange
            var arr = new Array();

            //Act
            arr.SetValue(0, 9);
            arr.SetValue(1, 13);

            //Assert
            Assert.Equal(9,arr.GetValue(0));
            Assert.Equal(13, arr.GetValue(1));
            Assert.Null(arr.GetValue(2));

        }

        [Fact]
        public void Array_Clone_Test()
        {
            //Arrange
            var arr=new Array(1,2,3);

            //Act
            var clonedArray = arr.Clone() as DataStructures.Array.Array;

            //Assert
            Assert.NotNull(clonedArray);
            Assert.Equal(arr.Lenght, clonedArray.Lenght);
            Assert.NotEqual(arr.GetHashCode(), clonedArray.GetHashCode());
        }

        [Fact]
        public void Array_GetEnumerator_Test()
        {
            // Arrange
            var arr=new Array(10,20,30);

            //Act
            string s = "";
            foreach (var item in arr)
            {
                s += item;
            }

            //Assert
            Assert.Equal("102030", s);
        }

        [Fact]
        public void Array_Custom_GetEnumerator_Test()
        {
            // Arrange
            var arr = new Array(10, 20, 30);

            //Act
            string s = "";
            foreach (var item in arr)
            {
                s += item;
            }

            //Assert
            Assert.Equal("102030", s);
        }

        [Theory]
        [InlineData(5)]
        public void Deneme_Test(int prm)
        {
            var arr = new Array(1, 3, 5, 7);

            var result = arr.IndexOf(prm);

            Assert.Equal(arr.GetValue(2),arr.GetValue(result));
        }
       
    }
}