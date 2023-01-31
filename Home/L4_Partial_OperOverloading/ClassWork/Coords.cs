namespace L4_Partial_OperOverloading
{
    public partial class Program
    {
        public partial class Coords
        {

            private int x;
            private int y;

            public Coords(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void PrintX()
            {
                Console.WriteLine("x", x);
            }
            public static partial void OnNameChanged();
        }
    }
}