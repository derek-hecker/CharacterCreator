using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public interface IRace
    {
        string description { get; set; }
        bool Darkvision { get; set; }
        string proficiencies { get; set; }
        string extra_stuff { get; set; }
    }
}
