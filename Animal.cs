namespace ConsoleApp1
{
    public interface IAnimal
    {
        string Name { get; set; }

        void ToAnimal();
    }
    public abstract class Animal : IAnimal
    {
        public string Name 
        { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Abstract sound");
        }

        public void ToAnimal()
        {
            throw new NotImplementedException();
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
