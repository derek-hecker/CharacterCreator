using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Noble : BaseBackground
    {
        public Noble()
        {
            Description = "You carry a noble title, and your family owns land, collects taxes, and wields significant political influence. You might be a pampered aristocrat unfamiliar with work or discomfort, a former merchant just elevated to the nobility, or a disinherited scoundrel with a disproportionate sense of entitlement.";
            Feature = "Position of Privelege";
            Extra = "One Language of your choice";
            Proficiencies = "History, Persuasion";
        }
    }
}
