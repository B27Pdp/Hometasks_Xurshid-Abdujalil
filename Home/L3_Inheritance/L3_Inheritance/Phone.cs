using System;
namespace L3_Inheritance
{
	public class Phone
	{
        //public string model;
        //public string owner;
        //public string chargerType;

        public string Model { get; set; }
        public string Owner { get; set; }
        public string ChargerType { get; set; }

        public Phone()
		{}
        public Phone(string model="Default Phone Model")
        {
            Model = model;
        }

	}
    class Samsung:Phone
    {
        public string OperatingSystem="Android";
        public object MyProperty { get; set; }

        public Samsung()
        {

        }
        public Samsung(string Owner) : base()
        {
            base.Owner = Owner;
        }
        public Samsung(string Owner,string ChargerType)
        {

        }
        public Samsung(string Owner, string ChargerType,string OperatingSystem)
        {
        }




    }
}

