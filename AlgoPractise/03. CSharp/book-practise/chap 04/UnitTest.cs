using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WindowsForms_async_await.book_practise.chap_04
{

    public class Calculator
    {
        public static double add(double  a, double  b)
        {
            return a + b;
        }
    }
    public class UnitTest
    {
        [Fact]
        public void TestAdd2And2()
        {
            double a=2,b = 2;
            double expected = 4;

            var result = Calculator.add(a , b);
            Assert.AreEqual(expected, result);


        }
    }
}
