namespace Basics
{
    public class Customer
    {
        public string Name;
        public int Id;

        public Customer()
        {

        }
        public Customer(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Customer(int id)
        {
            this.Id = id;
        }
    }
}
