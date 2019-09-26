using MathLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathLibTest
{
    [TestClass]
    public class UnitTest1
    {
        readonly double TOLERANCE = 0.000001;

        [TestMethod]
        public void DoubleCastOp()
        {
            var f = new Fraction(1, 2);
            double d = (double) f;

            Assert.AreEqual(0.5, d, TOLERANCE);
        }

        [TestMethod]
        public void FractionCastFromIntOp()
        {
            Fraction f = 4;

            f = f * f * 3 * 2.4;

            Assert.AreEqual(4, f.Numerator);
            Assert.AreEqual(4, f);
        }

        [TestMethod]
        public void Swap()
        {
            int x = 1, y = 2;

            Swap(ref x, ref y);

            Assert.AreEqual(1, y);
        }

        void Swap(ref int a, ref int  b)
        {
            int t = a;
            a = b; b = t;
            //int t = a ^ b;
            //a = t ^ b;
            //b = t ^ a;
        }
    }
}
