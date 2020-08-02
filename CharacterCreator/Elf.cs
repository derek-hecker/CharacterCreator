using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class Elf : DndCharacter, IRace
    {
        
        public Elf()
        {
            Dexterity = Dexterity + 2;
        }
        private bool __darkvision = true;
        private string __description = "Elves are a magical people of otherworldly grace, living in the world but not entirely part of it.\n Racial Traits: +2 Dex, Darkvision";
        private string __proficiencies = "Perception";
        private string __extrastuff = "Elves don't need to sleep and can instead meditate for 4 hours a day. ";
        public string description { get => __description; set => __description = value; }
        public bool Darkvision { get => __darkvision; set => __darkvision = value; }
        public string proficiencies { get => __proficiencies; set => __proficiencies = value; }
        public string extra_stuff { get => __extrastuff; set => __extrastuff = value; }
        public string DisplayAll()
        {
            string tmp;
            tmp = "Description: " + description + "\nProficiencies: " + proficiencies + "\nExtras: " + extra_stuff + "\n";
            return tmp;
        }
    }
}
