
namespace ClassLibrary1
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Person(string name,string surname,int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
    }
}
