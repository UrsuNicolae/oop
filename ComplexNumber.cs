namespace ConsoleApp1
{
    public class ComplexNumber
    {
        private double Real;
        private double Imaginary;

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}";
        }
    }
}
