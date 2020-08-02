using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Fighter : CharacterClass
    {
        private string firstAbility = "Fighting Style Choice, Second Wind ";
        private string secondAbility = "Action Surge";
        private string thirdAbility = "Martial Archetype";
        private string fourthAbility = "Extra Attack at 5th level";
        public Fighter()
        {
            Hitdie = 10;
            Hitpoints = "10 + Con Mod";
            PrimaryAbility = "Strength or Dex";
            Saves = "Strength or Con";
            Description = "A master of martial combat, skilled with a variety of weapons and armor";
        }

        public string FirstAbility { get => firstAbility; set => firstAbility = value; }
        public string SecondAbility { get => secondAbility; set => secondAbility = value; }
        public string ThirdAbility { get => thirdAbility; set => thirdAbility = value; }
        public string FourthAbility { get => fourthAbility; set => fourthAbility = value; }

        public override string DisplayFirstAbility()
        {
            return FirstAbility;
        }
        public override string DisplaySecondAbility()
        {
            return SecondAbility;
        }
        public override string DisplayThirdAbility()
        {
            return ThirdAbility;
        }
        public override string DisplayFourthAbility()
        {
            return FourthAbility;
        }
    }
}
