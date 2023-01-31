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
}

