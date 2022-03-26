using ValueAndReferanceType;
using Xunit;

namespace ValueAndReferanceTypesTests
{
    public class ValueAndRefTypeTest
    {
        [Fact]
        public void RefTypeTest()
        {
            //Arrange - Düzenleme ifadesi
            var p1 = new RefType
            {
                X = 10,
                Y = 20
            };
            var p2 = p1;

            // Action - Eylem ifadesi

            p1.X = 13;

            //Assert - Eylemin gerçekleþmesi ifadesi

            Assert.Equal(p1.X, p2.X);


        }

        [Fact]
        public void ValueTypeTest()
        {
            //Arrange - Düzenleme ifadesi
            var p1 = new ValueType
            {
                X = 10,
                Y = 20
            };
            var p2 = p1;

            // Action - Eylem ifadesi

            p1.X = 13;

            //Assert - Eylemin gerçekleþmesi ifadesi

            Assert.NotEqual(p1.X, p2.X);


        }

        [Fact]
        public void RecordTypeTest()
        {
            //Arrange
            var p1 = new RecordType(3, 5);

            //Act-Action
            var p2 = new RecordType(3, 5);

            //assert
            Assert.Equal(p1, p2);
        }

        [Fact]
        public void SwapByVal()
        {
            //Arrange
            int a = 13, b = 9;
            var valType = new ValueType();

            //Act
            valType.Swap(a, b);

            //Assert

            //Deðer tipli olduðu için swap iþlemi baþarýsýz oluyor
            /*
            Assert.Equal(9, a);
            Assert.Equal(13, b);
            */

            Assert.Equal(9, b);
            Assert.Equal(13, a);

        }

        [Fact]
        public void SwapByRef()
        {
            //Arrange
            int a = 13, b = 9;
            var refType = new RefType();

            //Act
            refType.Swap(ref a, ref b);

            //Assert           
            Assert.Equal(9, a);
            Assert.Equal(13, b);          

        }

        [Fact]
        public void CheckOutKeyword()
        {
            //Arrange
            var refType=new RefType();
            int b = 100;

            //Act
            refType.CheckOut(out b);

            //Assert
            Assert.Equal(53,b);
        }
    }
}