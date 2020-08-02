using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class PlayersCharacter
    {
        private string race;
        private string @class;
        private string background;
        private string inventory;
        private int strength;
        private int charisma;
        private int dexterity;
        private int wisdom;
        private int intelligence;
        private int constitution;

        public string Race { get => race; set => race = value; }
        public string Class { get => @class; set => @class = value; }
        public string Background { get => background; set => background = value; }
        public string Inventory { get => inventory; set => inventory = value; }

        public int Strength { get => strength; set => strength = value; }
        public int Charisma { get => charisma; set => charisma = value; }
        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int Wisdom { get => wisdom; set => wisdom = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
        public int Constitution { get => constitution; set => constitution = value; }
    }
}
