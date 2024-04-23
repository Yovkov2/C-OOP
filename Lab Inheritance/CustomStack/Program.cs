namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            stack.Push("Ivo");
            stack.Push("Magdalena");
            stack.Push("Ivana");

            try
            {
                Console.WriteLine($"This is Empty or no? {stack.IsEmpty()}");

                Stack<string> additionalStack = new Stack<string>();
                additionalStack.Push("Viktoriq");
                additionalStack.Push("Adelina");
                additionalStack.Push("Stefan");

                stack.AddRange(additionalStack);
                Console.WriteLine($"This is Empty or no? {stack.IsEmpty()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.ToString());
            }
        }
    }
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }
        public Stack<string> AddRange(Stack<string> additionalStack)
        {
            foreach (string item in additionalStack)
            {
                this.Push(item);
            }
            return this;
        }
    }
}