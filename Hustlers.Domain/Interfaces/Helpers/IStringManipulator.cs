using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Interfaces.Helpers
{
    public interface IStringManipulator
    {
        IList<string> BreakDownText(string longtext);
    }
}
