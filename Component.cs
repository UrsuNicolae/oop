namespace ConsoleApp1
{
    interface IRender
    {
        void Render();
    }

    class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    abstract class Component
    {
        protected Coordinate Position;

        protected Component(int x, int y)
        {
            Position = new Coordinate
            {
                X = x,
                Y = y
            };
        }

        public abstract void Move(int x, int y);
    }

    class Button : Component, IRender
    {
        public Button(int x, int y) : base(x, y)
        {
        }

        public override void Move(int x, int y)
        {
            base.Position.X = x;
            base.Position.Y = y;
        }

        public void Render()
        {
            Console.WriteLine("Button has coordinates: {0}:{1}", base.Position.X, base.Position.Y);
        }
    }

    class ImageComponent : Component, IRender
    {
        public ImageComponent(int x, int y) : base(x, y)
        {
        }

        public override void Move(int x, int y)
        {
            base.Position.X = x;
            base.Position.Y = y;
        }

        public void Render()
        {
            Console.WriteLine("ImageComponent has coordinates: {0}:{1}", base.Position.X, base.Position.Y);
        }
    }
}
