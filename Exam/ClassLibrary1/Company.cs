
namespace ContactManagement
{
    public class Company
    {
        private string name;
        private string address;

        public string Name => name;
        public string Address => address;

        public Company()
        {
            name = "Company";
            address = "Company address";
        }
        public Company(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    }
}
