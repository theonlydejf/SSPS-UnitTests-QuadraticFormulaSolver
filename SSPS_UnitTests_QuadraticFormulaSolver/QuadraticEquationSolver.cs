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

        public QuadraticEquationResult SolveFor(double value)
        {
            throw new NotImplementedException();
        }

        public QuadraticEquationResult SolveForZero() => SolveFor(0);

        public double GetDiscriminant()
        {
            throw new NotImplementedException();
        }
    }
}
