using System;
namespace Record_Struct1
{
  
    public struct Struct1Triangle
	{
        public ushort A { get; set; }
        public ushort B { get; set; }
        public EnumSMS_Status SMS_Status { get; set; }
        public ushort GetPerimetr()
        { return (ushort)(A + B); }
    }
}

