using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
   public abstract class CharacterClass
    {
        private int hitdie;
        private string hitpoints;
        private string primaryAbility;
        private string saves;
        private string description;

        public int Hitdie { get => hitdie; set => hitdie = value; }
        public string Hitpoints { get => hitpoints; set => hitpoints = value; }
        public string PrimaryAbility { get => primaryAbility; set => primaryAbility = value; }
        public string Saves { get => saves; set => saves = value; }
        public string Description { get => description; set => description = value; }



        public virtual string DisplayFirstAbility() { return "Should be overwritten"; }
        public virtual string DisplaySecondAbility() { return "Should be overwritten"; }
        public virtual string DisplayThirdAbility() { return "Should be overwritten"; }
        public virtual string DisplayFourthAbility() { return "Should be overwritten"; }

        public string DisplayAll()
        {
            string summary = "";
            summary = "Description: " + Description + "\n" + "Hitdie" + Hitdie.ToString() + "\n" + "Primary: " + PrimaryAbility + "\n" + "Saves: " + Saves + "\n" + "Abilities: " + DisplayFirstAbility() + "\n" + DisplaySecondAbility() + "\n" + DisplayThirdAbility() + "\n" + DisplayFourthAbility();
            return summary;
        }
    }
}
