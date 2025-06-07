namespace ConsoleApp1
{
    public abstract class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Abstract sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Dog
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Elephant : Animal
    {
        
    }

}
