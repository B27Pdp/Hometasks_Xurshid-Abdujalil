namespace Homework_OOP_L1
{
    //  2   //
    public class Rectangle
    {
        private byte a;
        private byte b;

        public Rectangle(byte a, byte b)
        {
            this.a = a;
            this.b = b;
        }
        public void Perimeter()
        {
            byte P = (byte)(2 * (a + b));
            Console.WriteLine($" Perimetri : {P}sm");
        }
        public void Surface()
        {
            byte S = (byte)(a * b);
            Console.WriteLine($" Yuzasi : {S}sm (kv)");
        }


    }


}


