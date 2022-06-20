using System;
using System.Collections.Generic;
using System.Text;

namespace SSPS_UnitTests_QuadraticFormulaSolver
{
    public struct QuadraticEquationResult
    {
        public static readonly QuadraticEquationResult NULL = new QuadraticEquationResult() { X1 = double.NaN, X2 = double.NaN, isNull = true };

        public double X1 { get; set; }
        public double X2 { get; set; }

        private bool isNull;

        public QuadraticEquationResult(double x1, double x2) : this()
        {
            X1 = x1;
            X2 = x2;
            isNull = false;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is QuadraticEquationResult))
                return false;

            QuadraticEquationResult result = (QuadraticEquationResult)obj;

            if (result.isNull && isNull)
                return true;

            return (X1 == result.X1 &&
                   X2 == result.X2) ||
                   (X2 == result.X1 &&
                   X1 == result.X2);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X1, X2);
        }

        public override string ToString()
        {
            return $"{{x1={X1},x2={X2}}}";
        }
    }
}
