using System;
using System.Collections.Generic;
using System.Text;

namespace SSPS_UnitTests_QuadraticFormulaSolver
{
    public class QuadraticEquationSolver
    {
        private QuadraticExpression _expression;

        public QuadraticEquationSolver(QuadraticExpression expression)
        {
            _expression = expression;
        }

        public QuadraticEquationResult SolveForZero()
        {
            double a = _expression.A;
            double b = _expression.B;
            double c = _expression.C;

            double d = GetDiscriminant();

            if (d < 0)
                return QuadraticEquationResult.NULL;

            if (d == 0)
                return new QuadraticEquationResult(-b / (2 * a), -b / (2 * a));

            double x1 = (-b + Math.Sqrt(d)) / 2 * a;
            double x2 = (-b - Math.Sqrt(d)) / 2 * a;

            return new QuadraticEquationResult(x1, x2);
        }

        public double GetDiscriminant() => _expression.B * _expression.B - 4 * _expression.A * _expression.C;
    }
}
