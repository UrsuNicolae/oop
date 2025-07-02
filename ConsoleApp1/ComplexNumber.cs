namespace ConsoleApp1
{
    public class ComplexNumber
    {
        public double Real;
        public double Imaginary;

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public ComplexNumber(ComplexNumber complexNumber)
        {
            Real = complexNumber.Real;
            Imaginary = complexNumber.Imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public static ComplexNumber operator +(ComplexNumber c1, int c2)
        {
            return new ComplexNumber(c1.Real + c2, c1.Imaginary + c2);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}";
        }
    }
}
