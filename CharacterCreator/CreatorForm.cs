using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class CreatorForm : Form
    {

        PlayersCharacter playersCharacter = new PlayersCharacter();
        public CreatorForm()
        {
            InitializeComponent();
         
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            rTBRaceDescription.Text = "";
            Human human = new Human();
            rTBRaceDescription.Text = human.description;
        }
        private void radioButtonDwarf_CheckedChanged(object sender, EventArgs e)
        {
            rTBRaceDescription.Text = "";
            Dwarf dwarf = new Dwarf();
            rTBRaceDescription.Text = dwarf.description;
        }

        private void radioButtonElf_CheckedChanged(object sender, EventArgs e)
        {
            rTBRaceDescription.Text = "";
            Elf elf = new Elf();
            rTBRaceDescription.Text = elf.description;

        }

        private void radioButtonGnome_CheckedChanged(object sender, EventArgs e)
        {
            rTBRaceDescription.Text = "";
            Gnome gnome = new Gnome();
            rTBRaceDescription.Text = gnome.description;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonFinalRace_Click(object sender, EventArgs e)
        {
           if (radioButtonHuman.Checked == true)
            {
                playersCharacter.Race = "Human";
            } else if (radioButtonElf.Checked == true)
            {
                playersCharacter.Race = "Elf";
            } else if (radioButtonDwarf.Checked == true)
            {
                playersCharacter.Race = "Dwarf";
            } else if (radioButtonGnome.Checked == true)
            {
                playersCharacter.Race = "Gnome";
            } else
            {
                rTBRaceDescription.Text = "Please select a race before submitting";
                return;
            }
            radioButtonDwarf.Enabled = false;
            radioButtonHuman.Enabled = false;
            radioButtonElf.Enabled = false;
            radioButtonGnome.Enabled = false;
        }

    }
}
