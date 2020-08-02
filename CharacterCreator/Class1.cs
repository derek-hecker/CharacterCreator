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

        public string Race { get => race; set => race = value; }
        public string Class { get => @class; set => @class = value; }
        public string Background { get => background; set => background = value; }
        public string Inventory { get => inventory; set => inventory = value; }
    }
}
