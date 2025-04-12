using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilies.Results
{
    public interface IResults
    {
        bool Success { get; } //readonly
        string Message { get; }
    }
}
