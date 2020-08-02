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
        public int Strength { get; set; }
        public int Charisma { get; set; }
        public int Dexterity { get; set; }
        public int Wisdom { get; set; }
        public int Intelligence { get; set; }
        public int Constitution { get; set; }

        public string Inventory = "";
        public string Name = "";
        //Fighter Barbarian Rogue or 
        public string classtype = "";
        // Elf Dwarf Human or Gnome
        public string race = "";


    }
}
