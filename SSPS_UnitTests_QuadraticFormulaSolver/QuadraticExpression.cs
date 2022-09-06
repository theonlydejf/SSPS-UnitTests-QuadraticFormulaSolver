using System;
using System.Collections.Generic;
using System.Text;

namespace SSPS_UnitTests_QuadraticFormulaSolver
{
    public struct QuadraticExpression
    {
        public QuadraticExpression(double a, double b, double c)
        {
            if (a == 0)
                throw new MissingExpressionMembersException("A");

            A = a;
            B = b;
            C = c;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public override string ToString()
        {
            string aSgn = A < 0 ? "-" : "";
            string bSgn = B < 0 ? "-" : "+";
            string cSgn = C < 0 ? "-" : "+";
            return $"{aSgn}{Math.Abs(A)}x^2 {bSgn} {Math.Abs(B)}x {cSgn} {Math.Abs(C)}";
        }
    }
}
