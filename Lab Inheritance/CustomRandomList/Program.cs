namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList mylist = new RandomList();

            mylist.Add("Ivo");
            mylist.Add("Damqn");
            mylist.Add("Yavor");

            mylist.Display();

            try
            {
                string removedItem = mylist.RemoveRandom();
                Console.WriteLine(removedItem);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            
            mylist.Display();
        }
    }
    public class RandomList
    {
       public List<string> list;
       private Random random;

        public RandomList()
        {
            list = new List<string>();
            random = new Random();
        }
        public int Count()
        {
            return list.Count;
        }
        public void Add(string value)
        {
            list.Add(value);
        }
        public void Remove(string value)
        {
            list.Remove(value);
        }
        public void Clear()
        {
            list.Clear();
        }
        public void Insert(string value)
        {
            list.Contains(value);
        }

        public string RemoveRandom()
        {
            if(list.Count == 0)
            {
                throw new InvalidOperationException("String is empty");
            }

            int index = random.Next(list.Count);
            string randomElement = list[index];
            list.RemoveAt(index);
            return randomElement;
        }
        public void Display()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}