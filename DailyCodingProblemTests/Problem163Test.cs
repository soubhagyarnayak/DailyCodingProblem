using DailyCodingProblem;
using NUnit.Framework;

namespace DailyCodingProblemTests
{
    public class Problem163Test
    {
        [Test]
        public void TestEvaluateReversePolishNotationShort()
        {
            double result = Problem163.EvaluateReversePolishNotation(new string[] { "5", "3", "+" });
            Assert.AreEqual(8, result);
        }

        [Test]
        public void TestEvaluateReversePolishNotationLarge()
        {
            double result = Problem163.EvaluateReversePolishNotation(new string[] 
            { "15", "7", "1","1","+","-","/","3","*","2","1","1","+","+","-" });
            Assert.AreEqual(5, result);
        }
    }
}
