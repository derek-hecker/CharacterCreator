using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class Dwarf : DndCharacter, IRace
    {

        private bool __darkvision = true;
        private string __description = "Bold and hardy, dwarves are known as skilled warriors, miners, and workers of stone and metal.\n Racial Traits: +2 Constitution, Darkvision";
        private string __proficiencies = "Batlleaxe, handaxe, light hammer, war hammer";
        private string __extrastuff = "Whenever you make an Intelligence (History) check related to the origin of stonework, you are considered proficient in the History skill and add double your proficiency bonus to the check, instead of your normal proficiency bonus ";

        public Dwarf()
        {
            Constitution = Constitution + 2;
        }

        public string description { get => __description; set => __description = value; }
        public bool Darkvision { get => __darkvision; set => __darkvision = value; }
        public string proficiencies { get => __proficiencies; set => __proficiencies = value; }
        public string extra_stuff { get => __extrastuff; set => __extrastuff = value; }
    }
}
