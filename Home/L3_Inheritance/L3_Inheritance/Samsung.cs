namespace L3_Inheritance
{
    class Samsung :Phone
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

