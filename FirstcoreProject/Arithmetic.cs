namespace FirstLib{
    public abstract class Arithmetic{
    
        protected double a;

        protected double b;
        protected double c;

        public Arithmetic() {
            
        }

        public Arithmetic(double a, double b) {
            this.a = a;
            this.b = b;
            this.c = 0.0;
        }

        public void read() {
            System.Console.WriteLine("Enter two numbers:");
            this.a = System.Convert.ToDouble(System.Console.ReadLine());
            this.b = System.Convert.ToDouble(System.Console.ReadLine());
        }

        public double result() {
            return this.c;
        }

        public virtual void display() {
            System.Console.WriteLine(this.c);
        }

        public abstract void calculate();
    }
 
}