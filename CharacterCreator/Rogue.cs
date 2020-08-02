using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Rogue : CharacterClass
    {
        private string firstAbility = "Expertise, Sneak Attack";
        private string secondAbility = "Cunning Action";
        private string thirdAbility = "Roguish Archetype";
        private string fourthAbility = "Uncanny Dodge";
        public Rogue()
        {
            Hitdie = 8;
            Hitpoints = "8 + Con Mod";
            PrimaryAbility = "Dex";
            Saves = "Dex or Int";
            Description = "A scoundrel who uses stealth and trickery to overcome obstacles and enemies";
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
