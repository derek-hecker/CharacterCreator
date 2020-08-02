using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    abstract public class BaseBackground
    {
        private string description;
        private string extra;
        private string proficiencies;
        private string feature;

        public string Description { get => description; set => description = value; }
        public string Extra { get => extra; set => extra = value; }
        public string Proficiencies { get => proficiencies; set => proficiencies = value; }
        public string Feature { get => feature; set => feature = value; }

        public string DisplayAll() {
            string summary = "Description: " + Description + "\n" + "Background Feature: " + Feature + "\n" + Proficiencies + "\n" + Feature;
            return summary;
        }
    }
}
