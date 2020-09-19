using System;
using Xunit;
using FluentAssertions;
using FirstLib;

namespace Tests
{
    public class Test1
    {
        [Fact]
        public void isAdding() {
            var obj = new Addition(1.0, 3.0);
            obj.calculate();
            Assert.Equal(obj.result(), 4.0);
        }

        [Fact]
        public void isSubtracting() {
            var obj = new Subtraction(1.0, 3.0);
            obj.calculate();
            Assert.Equal(obj.result(), -2);
        }

        [Fact]
        public void isDividing() {
            var obj = new Division(10.0, 2.0);
            obj.calculate();
            Assert.Equal(obj.result(), 5.0);
        }

        [Fact]
        public void cannotDividebyZero() {
            var obj = new Division();
            Assert.Throws<DivideByZeroException>(() => obj.calculate());
        }
    }
}