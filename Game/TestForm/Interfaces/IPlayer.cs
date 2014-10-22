using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm.Interfaces
{
    public interface IPlayer
    {
        Faction Faction { get; }

        IList<Unit> Units { get; set; }
    }
}
