
namespace ClassLibrary1
{
    public class Company
    {
        private string name;
        private string address;

        public string Name => name;
        public string Address => address;

        public Company(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    }
}
