using System;

namespace FirstLib
{
    public class ArithmeticFactory {
        public static Arithmetic getFactory(int ch) {
            switch(ch) {
                case 1: 
                    return new Addition();
                case 2: 
                    return new Subtraction();
                case 3: 
                    return new Multiplication();
                case 4: 
                    return new Division();

                default : return null;
            }
        }
    }
}