using System;

namespace SSPS_UnitTests_QuadraticFormulaSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                double a = ReadDouble("Enter A: ");
                double b = ReadDouble("Enter B: ");
                double c = ReadDouble("Enter C: ");

                QuadraticExpression expression;
                try
                {
                    expression = new QuadraticExpression(a, b, c);
                }
                catch(MissingExpressionMembersException ex)
                {
                    Console.Write("You entered values, which cannot create a quadratic equation! The final equation is missing following member(s): ");
                    Console.WriteLine(string.Join(", ", ex.MissingMembers));
                    continue;
                }

                QuadraticEquationSolver solver = new QuadraticEquationSolver(expression);

                double discriminant = solver.GetDiscriminant();
                QuadraticEquationResult result = solver.SolveForZero();

                if(result.Equals(QuadraticEquationResult.NULL))
                {
                    Console.WriteLine($"Quadratic equation {expression} = 0 has the following discriminant: {discriminant} and is not solvable in real numbers");
                    continue;
                }

                Console.WriteLine($"Quadratic equation {expression} = 0 has the following discriminant: {discriminant} and its result is {result}");
            }
        }

        private static double ReadDouble(string message)
        {
            Console.Write(message);
            if(!double.TryParse(Console.ReadLine(), out double num))
            {
                Console.WriteLine("Not a number!");
                return ReadDouble(message);
            }

            return num;
        }
    }
}
