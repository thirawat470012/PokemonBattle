using System;

namespace PokemonBattle
{
    public partial class Form1 : Form
    {
        List<Pokemon> Pokemons;
        Pokemon selectedPokemon;
        Pokemon monster;
        public Form1()
        {
            InitializeComponent();
            Pokemons = new List<Pokemon>();
            Pokemons.Add(new Mew());
            Pokemons.Add(new Mewtwo());
            Pokemons.Add(new Reshiram());
            Pokemons.Add(new Zekrom());

            monster = new Kyurem();
            pictureBox2.Image = this.monster.getImage();
            Hptext2.Text = monster.getHP().ToString();
            NameText2.Text = monster.getName();
            AtkText2.Text = monster.getAtk().ToString();
            DefText2.Text = monster.getDefense().ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            selectedPokemon = Pokemons[0];
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("He's Dead.");
            }
            else
            {
                pictureBox1.Image = selectedPokemon.getImage();
                NameText1.Text = selectedPokemon.getName();
                Hptext1.Text = selectedPokemon.getHP().ToString();
                NameText1.Text = selectedPokemon.getName();
                AtkText1.Text = selectedPokemon.getAtk().ToString();
                DefText1.Text = selectedPokemon.getDefense().ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            selectedPokemon = Pokemons[1];
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("He's Dead.");
            }
            else
            {
                pictureBox1.Image = selectedPokemon.getImage();
                NameText1.Text = selectedPokemon.getName();
                Hptext1.Text = selectedPokemon.getHP().ToString();
                NameText1.Text = selectedPokemon.getName();
                AtkText1.Text = selectedPokemon.getAtk().ToString();
                DefText1.Text = selectedPokemon.getDefense().ToString();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = Pokemons[2];
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("He's Dead.");
            }
            else
            {
                pictureBox1.Image = selectedPokemon.getImage();
                NameText1.Text = selectedPokemon.getName();
                Hptext1.Text = selectedPokemon.getHP().ToString();
                NameText1.Text = selectedPokemon.getName();
                AtkText1.Text = selectedPokemon.getAtk().ToString();
                DefText1.Text = selectedPokemon.getDefense().ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = Pokemons[3];
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("He's Dead.");
            }
            else
            {
                pictureBox1.Image = selectedPokemon.getImage();
                NameText1.Text = selectedPokemon.getName();
                Hptext1.Text = selectedPokemon.getHP().ToString();
                NameText1.Text = selectedPokemon.getName();
                AtkText1.Text = selectedPokemon.getAtk().ToString();
                DefText1.Text = selectedPokemon.getDefense().ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (selectedPokemon.getHP() > 0)
            {

                int damage = (selectedPokemon.getAtk() - monster.getDefense());
                monster.takeDamage(damage);
                Hptext2.Text = monster.getHP().ToString();

                if (monster.getHP() <= 0)
                {
                    Hptext2.Text = "0";
                    MessageBox.Show("Monster Defeated!!");
                }
                else
                {
                    int enemyDamage = (monster.getAtk() - selectedPokemon.getDefense());
                    selectedPokemon.takeDamage(enemyDamage);
                    Hptext1.Text = selectedPokemon.getHP().ToString();
                }
            }
            else
            {
                MessageBox.Show("Your Pokemon is dead.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (selectedPokemon != null)
            {
                selectedPokemon.IncreaseHP(50);
                Hptext1.Text = selectedPokemon.getHP().ToString();
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (selectedPokemon != null)
            {
                selectedPokemon.IncreaseDef(50);
            }
            else
            {
                MessageBox.Show("");
            }
        }

       

        
    }
}