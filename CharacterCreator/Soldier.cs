using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Soldier : BaseBackground
    {
        public Soldier()
        {
            Description = "War has been your life for as long as you care to remember. You trained as a youth, studied the use of weapons and armor, learned basic survival techniques, including how to stay alive on the battlefield.";
            Feature = "Military Rank";
            Extra = "Gaming set of your choice";
            Proficiencies = "Athletics, Intimidation, Vehicles";
        }
    }
}
