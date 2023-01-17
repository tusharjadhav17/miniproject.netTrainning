using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public interface IEmployee
    {
        string GetName();
        void SetName(string name);

        string GetDefaultName();

        string DisplayName();
    }
}
