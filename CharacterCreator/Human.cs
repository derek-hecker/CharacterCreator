using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class Human : DndCharacter, IRace
    {
        private bool __darkvision = true;
        private string __description = "Humans are the most adaptable and ambitious people among the common races.Whatever drives them, humans are the innovators, the achievers, and the pioneers of the worlds.\n" +
            "Racial Traits: + 1 to All Ability Scores, Extra Language";
        private string __proficiencies = "Artisans Tools";
        private string __extrastuff = "Whenever you make an Intelligence (History) check related to magic items, alchemical objects, or technological devices, you can add twice your proficiency bonus, instead of any proficiency bonus you normally apply.";

        public Human()
        {
            Intelligence = Intelligence + 1;
            Charisma = Charisma + 1;
            Wisdom = Wisdom + 1;
            Strength = Strength + 1;
            Dexterity = Dexterity + 1;
            Constitution = Constitution + 1;
        }

        public string description { get => __description; set => __description = value; }
        public bool Darkvision { get => __darkvision; set => __darkvision = value; }
        public string proficiencies { get => __proficiencies; set => __proficiencies = value; }
        public string extra_stuff { get => __extrastuff; set => __extrastuff = value; }
    }
}
