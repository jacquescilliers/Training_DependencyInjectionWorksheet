using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjection_Worksheet
{
    public interface IDateGenerator
    {
        DateTime DateToUse();
    }
}
