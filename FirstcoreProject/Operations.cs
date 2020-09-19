using System;

namespace FirstLib
{
    class Addition : Arithmetic
    {
        public Addition() : base() {

        }
        public Addition(double a, double b) : base(a, b) {

        }
        override public void calculate() {
            this.c = this.a + this.b;
        }

        public sealed override void display() {
            System.Console.WriteLine("Addition");
            base.display();
        }

    }

    class Subtraction : Arithmetic
    {
        public Subtraction() : base() {

        }
        public Subtraction(double a, double b) : base(a, b) {

        }
        override public void calculate() {
            this.c =  (this.a - this.b);
        }

        public sealed override void display() {
            System.Console.WriteLine("Subtraction");
            base.display();
        }
    }

    class Multiplication : Arithmetic
    {
        public Multiplication() : base() {

        }
        public Multiplication(double a, double b) : base(a, b) {

        }
        override public void calculate() {
            this.c =  (this.a * this.b);
        }

        public sealed override void display() {
            System.Console.WriteLine("Multiplication");
            base.display();
        }
    }

    class Division : Arithmetic
    {
        public Division() : base() {

        }
        public Division(double a, double b) : base(a, b) {

        }
        override public void calculate() {
            if(this.b==0) { 
                throw (new DivideByZeroException());
            }
            else
                this.c = this.a/this.b;
        }
        public sealed override void display() {
            System.Console.WriteLine("Multiplication");
            base.display();
        }
    }

}