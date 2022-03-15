using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LambdaExpressions.Tests
{
    [TestClass]
    public class MathQueueTests
    {


        [TestMethod]
        public void TestMethod1()
        {
            MathQueue mathQueue = new();

            mathQueue.Queue(42, 4.2,  (MathOperation<double>) ((left, right, more) => left*right*more));

            mathQueue.Queue(42, 4.2, Add);

            static double multiply(int left, double right) => left * right;

            mathQueue.Queue(42, 4.2, multiply);

            mathQueue.Queue(42, 4.2,
                (left, right) => left/right
            );

#pragma warning disable CS8321 // Local function is declared but never used
            // Sample local functions
            static int oneParamAction(int left) => left;

            static void doSomething(int left, double right)
            {
                double result = left+right;
                Console.WriteLine(result*result);
            }
#pragma warning restore CS8321 // Local function is declared but never used

            mathQueue.Queue(42, 4.2,
                (left, right) =>
                {
                    double result= left+right;
                    return result*result;
                }
            ) ;

            // ???? Max (int left, int right) => left > right ? right : left;
        }

        private double Add(int left, double right)
            => left + right;

    }
}