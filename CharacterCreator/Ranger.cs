using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Ranger : CharacterClass
    {
        private string firstAbility = "Favored Enemy, Natural Explorer";
        private string secondAbility = "Fighting Style, Spellcasting";
        private string thirdAbility = "Ranger Archetype, Primeival Awareness";
        private string fourthAbility = "Extra Attack";
        public Ranger()
        {
            Hitdie = 10;
            Hitpoints = "10 + Con Mod";
            PrimaryAbility = "Dex and Wis";
            Saves = "Strength and Dex";
            Description = "A warrior who combats threats on the edges of civilization";
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
