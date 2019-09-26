using System;

namespace MathLib
{
    public class Fraction
    {

        public Fraction(int n = 0, int d=1)
        {
            Numerator = n;
            Denominator = d;
        }

        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public static implicit operator Fraction(int x)
        {
            return new Fraction(x);
        }

        public static implicit operator Fraction(double x)
        {
            return new Fraction((int)x); //todo delta = 0.000001
        }

        public static Fraction operator*(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numerator  * f2.Numerator,
                   f1.Denominator *f2.Denominator);
        }

        public static explicit operator double(Fraction f)
        {
            return (double)f.Numerator / f.Denominator;
        }

        public static explicit operator int(Fraction f)
        {
            return f.Numerator / f.Denominator;
        }


        public override bool Equals(Object that)
        {
            return true;
            // avoid overflow
        }

        public override String ToString()
        {
            return null;
            // 
        }
    }
}
