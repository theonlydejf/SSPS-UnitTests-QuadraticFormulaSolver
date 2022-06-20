using NUnit.Framework;
using SSPS_UnitTests_QuadraticFormulaSolver;

namespace UnitTests
{
    public class Tests
    {
        private static object[] ExpressionCases =
        {
            new object[] { new QuadraticExpression(1, 0, 1), QuadraticEquationResult.NULL, -4 },
            new object[] { new QuadraticExpression(1, 0, 0), new QuadraticEquationResult(0, 0), 0 },
            new object[] { new QuadraticExpression(1, 0, -1), new QuadraticEquationResult(-1, 1), 4 }
        };

        [SetUp]
        public void Setup()
        {
            /*_expressionNoResult = new ExpressionResultPair(new QuadraticExpression(1, 0, 1), QuadraticEquationResult.NULL, -4);
            _expressionOneResult = new ExpressionResultPair(new QuadraticExpression(1, 0, 0), new QuadraticEquationResult(0, 0), 0);
            _expressionTwoResults = new ExpressionResultPair(new QuadraticExpression(1, 0, -1), new QuadraticEquationResult(-1, 1), 4);*/
        }

        [Test]
        [TestCase(0, 1, 1, false)]
        [TestCase(1, 1, 1, true)]
        public void TestCreateExpression(double a, double b, double c, bool validExpression)
        {
            TestDelegate testDelegate = () => new QuadraticExpression(a, b, c);
            if(validExpression)
                Assert.DoesNotThrow(testDelegate);
            else
                Assert.Throws<MissingExpressionMembersException>(testDelegate);
        }

        [Test]
        [TestCaseSource(nameof(ExpressionCases))]
        public void TestDiscriminant(QuadraticExpression expression, QuadraticEquationResult result, double expectedDiscriminant)
        {
            QuadraticEquationSolver solver = new QuadraticEquationSolver(expression);

            double discriminant = solver.GetDiscriminant();

            Assert.AreEqual(expectedDiscriminant, discriminant, 1E-6);
        }

        [Test]
        public void TestResultEquality()
        {
            Assert.AreEqual(new QuadraticEquationResult(1, 2), new QuadraticEquationResult(2, 1));
            Assert.AreEqual(QuadraticEquationResult.NULL, QuadraticEquationResult.NULL);
        }

        [Test]
        [TestCaseSource(nameof(ExpressionCases))]
        public void TestResults(QuadraticExpression expression, QuadraticEquationResult expectedResult, double expectedDiscriminant)
        {
            QuadraticEquationSolver solver = new QuadraticEquationSolver(expression);

            QuadraticEquationResult result = solver.SolveForZero();

            Assert.AreEqual(expectedResult, result);
        }
    }
}