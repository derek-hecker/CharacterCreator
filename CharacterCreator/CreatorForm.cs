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

        private void radioButton5_CheckedChanged(object sender, EventArgs e) //Barbarian
        {
            richTextBox3.Clear();
            Barbarian barbarian = new Barbarian();
            richTextBox3.Text = barbarian.DisplayAll();
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

        private void radioButtonFighter_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox3.Clear();
            Fighter fighter = new Fighter();
            richTextBox3.Text = fighter.DisplayAll();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonRogue_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox3.Clear();
            Rogue rogue = new Rogue();
            richTextBox3.Text = rogue.DisplayAll();
        }

        private void radioButtonRanger_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox3.Clear();
            Ranger ranger = new Ranger();
            richTextBox3.Text = ranger.DisplayAll();
        }

        private void btnFinalClass_Click(object sender, EventArgs e)
        {
            if (radioButtonBarbarian.Checked == true)
            {
                playersCharacter.Class = "Barbarian";
            }
            else if (radioButtonFighter.Checked)
            {
                playersCharacter.Class = "Fighter";
            }
            else if (radioButtonRanger.Checked)
            {
                playersCharacter.Class = "Ranger";
            } else if (radioButtonRogue.Checked)
            {
                playersCharacter.Class = "Rogue";
            } else
            {
                richTextBox3.Text = "Please select a class before submitting";
                return;
            }
            radioButtonRogue.Enabled = false;
            radioButtonRanger.Enabled = false;
            radioButtonBarbarian.Enabled = false;
            radioButtonFighter.Enabled = false;
        }
    }
}
