using Xunit;
using FirstLib;

namespace Tests
{
    public class Test1
    {
        [Fact]
        public void isPrintingHi() {
            var obj = new Addition();
            Assert.Equal(obj.display(), "Hi");
        }

        [Fact]
        public void isAdding() {
            var obj = new Addition();
            Assert.Equal(obj.calculate(1, 3), 4);
        }

        [Fact]
        public void isSubtracting() {
            var obj = new Subtraction();
            Assert.Equal(obj.calculate(1, 3), -2);
        }

        [Fact]
        public void isDividing() {
            var obj = new Divide();
            Assert.Equal(obj.calculate(10, 2), 5);
        }

        // [Fact]
        // public void cannotDividebyZero() {
        //     var obj = new Divide();
        //     var ex = Assert.Throws<>(() => obj.calculate(7, 0));
        //     Assert.IsType<ArithmeticException>(ex); 
        // }
    }
}