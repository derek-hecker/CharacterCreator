using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class Gnome : DndCharacter, IRace
    {

        private bool __darkvision = true;
        private string __description = "A gnome’s energy and enthusiasm for living shines through every inch of his or her tiny body.\n Racial Traits: +2 Intelligence, Darkvision";
        private string __proficiencies = "Artisans Tools";
        private string __extrastuff = "Whenever you make an Intelligence (History) check related to magic items, alchemical objects, or technological devices, you can add twice your proficiency bonus, instead of any proficiency bonus you normally apply.";

        public Gnome()
        {
            Intelligence = Intelligence + 2;
        }

        public string description { get => __description; set => __description = value; }
        public bool Darkvision { get => __darkvision; set => __darkvision = value; }
        public string proficiencies { get => __proficiencies; set => __proficiencies = value; }
        public string extra_stuff { get => __extrastuff; set => __extrastuff = value; }

    }
}
