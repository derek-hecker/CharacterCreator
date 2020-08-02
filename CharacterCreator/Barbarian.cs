using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Barbarian : CharacterClass
    {
        private string firstAbility = "Rage, Unarmored Defense";
        private string secondAbility = "Reckless Attack";
        private string thirdAbility = "Danger Sense, Primal Path";
        private string fourthAbility = "Extra Attack";
        public Barbarian()
        {
            Hitdie = 12;
            Hitpoints = "12 + Con Mod";
            PrimaryAbility = "Strength";
            Saves = "Strength and Con";
            Description = "A fierce warrior of primitive background who can enter a battle rage";
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
