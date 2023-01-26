using System;
namespace Record_Struct1
{

    struct Coordinate
    {
        public int x;
        public int y;
    }

    public class Class1Triangle
	{
		public ushort A { get; set; }
		public ushort B { get; set; }
		public EnumSMS_Status SMS_Status { get; set; }

		public ushort GetPerimetr()
		{ return (ushort)(A + B); }
		public Class1Triangle()
		{ 
		}
	}
}

