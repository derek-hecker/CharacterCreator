using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Priest : BaseBackground
    {
        public Priest()
        {
            Description = "You have spent your life in the service of a temple to a specific god or pantheon of gods. You act as an intermediary between the realm of the holy and the mortal world";
            Feature = "Shelter of the Faithful";
            Extra = "Two additonal known langauges";
            Proficiencies = "Insight and Religion";
        }
    }
}
