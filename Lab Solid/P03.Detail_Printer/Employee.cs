namespace P03.DetailPrinter
{
    public abstract class Employee
    {
        public string Name { get; }

        protected Employee(string name)
        {
            Name = name;
        }

        public abstract void PrintDetails();
    }
}
