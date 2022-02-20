namespace CallingExternalApi
{
    public class Address
    {
        private string street;
        private string suite;
        private string city;
        private string zipCode;
        private Geo geo;

        public string Street { get => street; set => street = value; }
        public string Suite { get => suite; set => suite = value; }
        public string City { get => city; set => city = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }
        public Geo Geo { get => geo; set => geo = value; }
    }
}