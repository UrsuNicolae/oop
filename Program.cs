namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IA ia = new Diamond();
            IB ib = new Diamond();
            IC ic = new Diamond();
            ia.DoWork();
            ib.DoWork();
            ic.DoWork();
        }

        static void RenderUI(List<IRender> renders)
        {
            foreach (var render in renders)
            {
                render.Render();
            }
        }

    }
}
