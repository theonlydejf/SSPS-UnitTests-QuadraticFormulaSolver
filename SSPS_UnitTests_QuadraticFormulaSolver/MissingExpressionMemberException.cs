using System;
using System.Collections.Generic;
using System.Text;

namespace SSPS_UnitTests_QuadraticFormulaSolver
{
    public class MissingExpressionMembersException : ApplicationException
    {
        public MissingExpressionMembersException(params string[] missingMembers)
        {
            MissingMembers = missingMembers;
        }

        public string[] MissingMembers { get; set; }
    }
}
