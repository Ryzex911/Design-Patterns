namespace FacadePattern
{
    internal class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("Popcornmachine aan.");
        }

        public void Off()
        {
            Console.WriteLine("Popcornmachine uit.");
        }

        public void Pop()
        {
            Console.WriteLine("Popcorn wordt gemaakt.");
        }
    }
}