using System;

namespace FirstLib
{
    class Addition : A.Arithmetic
    {
        public int calculate(int num1, int num2) {
            return (num1+num2);
        }
        public String display() {
            return "Hi";
        }
    }

    class Subtraction : A.Arithmetic
    {
        public int calculate(int num1, int num2) {
            return (num1-num2);
        }
    }

    class Divide : A.Arithmetic
    {
        public int calculate(int num1, int num2) {
            if(num2==0) {
                Exception e = new ArithmeticException("Can't divide by zero");
                throw (e);
            }
            else
                return num1/num2;
        }
    }
}