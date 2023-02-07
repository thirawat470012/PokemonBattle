using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PokemonBattle
{
    internal class Pokemon
    {
        protected string name;
        protected int HP;
        protected int Attack;
        protected int Defense;
        protected int Speed;
        protected Bitmap _image;

        public Bitmap getImage()
        {
            return _image;
        }
        public string getName()
        {
            return name;
        }
        public int getHP()
        {
            return HP;
        }

        public int getAtk() { return Attack; }
        public int getSpeed() { return Speed; }
        public int getDefense() { return Defense; }
        public void takeDamage(int damage) {
                if (damage > 0)
                {
                    HP -= damage;
                }
                else
                {
                    damage = 0;
                }

        }
        public void IncreaseHP(int amount)
        {
            HP += amount;
        }
        public void IncreaseDef(int number)
        {
            Defense = number;
        }
    }
            
}
