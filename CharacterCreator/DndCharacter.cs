using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class DndCharacter
    {
        //Attributes
        public int Strength { get => strength; set => strength = value; }
        public int Charisma { get => charisma; set => charisma = value; }
        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int Wisdom { get => wisdom; set => wisdom = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
        public int Constitution { get => constitution; set => constitution = value; }

        private int strength = 8;
        private int charisma = 8;
        private int dexterity = 8;
        private int wisdom = 8;
        private int intelligence = 8;
        private int constitution = 8;
    }
}
