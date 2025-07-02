namespace ConsoleApp1.DesignPatterns
{
    public class Calculator
    {
        public string ScreenColor { get; set; }

        public List<string> Fuctions { get; set; } = new();

        public void ShowDetails()
        {
            Console.WriteLine($"Screen Color: {ScreenColor}");
            Console.WriteLine($"Functions {string.Join(",", Fuctions)}");
        }
    }

    public abstract class CalculatorBuilder
    {
        protected Calculator _calculator = new Calculator();

        public abstract void BuildScreen();
        public abstract void BuildFunctions();

        public Calculator GetCalculator() => _calculator;
    }

    public class ScientificCalculatorBuilder : CalculatorBuilder
    {
        public override void BuildFunctions()
        {
            _calculator.Fuctions = new List<string>
            {
                "+", "-", "*", "/", "%", "^", "sqrt", "^2"
            };
        }

        public override void BuildScreen()
        {
            _calculator.ScreenColor = "Black";
        }
    }

    public class SimpleCalculatorBuilder : CalculatorBuilder
    {
        public override void BuildFunctions()
        {
            _calculator.Fuctions = new List<string>
            {
                "+", "-", "*", "/"
            };
        }

        public override void BuildScreen()
        {
            _calculator.ScreenColor = "White";
        }
    }

    public class CalculatorManagement
    {
        private readonly CalculatorBuilder _builder;

        public CalculatorManagement(CalculatorBuilder builder)
        {
            _builder = builder;
        }

        public Calculator Construct()
        {
            _builder.BuildScreen();
            _builder.BuildFunctions();
            return _builder.GetCalculator();
        }
    }
}
