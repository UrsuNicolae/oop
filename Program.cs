namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cmp1 = new ComplexNumber(1, 2);
            var cmp2 = new ComplexNumber(1, 2);

            var cmp3 = cmp1 + cmp2;
            Console.WriteLine(cmp3);
        }

        static void DisplayAnimalSound(Animal animal)
        {
            animal.MakeSound();
        }
    }
}
