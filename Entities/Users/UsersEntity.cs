namespace CallingExternalApi
{
    public class Users
    {
        private int id;
        private string name;
        private string email;
        private Address address;
        private string phone;
        private string webSite;
        private Company company;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public Address Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string WebSite { get => webSite; set => webSite = value; }
        public Company Company { get => company; set => company = value; }
    }
}