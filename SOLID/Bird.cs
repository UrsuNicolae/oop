namespace ConsoleApp1.SOLID
{
    interface IBird
    {
        void Move();
    }

    class FlyingBird : IBird
    {
        public virtual void Move()
        {
            Fly();
        }

        public virtual void Fly()
        {
            Console.WriteLine("The bird is flying.");
        }
    }

    class Penguin : FlyingBird
    {
        public override void Move()
        {
            Console.WriteLine("The penguin is swimming.");
        }
    }
}
