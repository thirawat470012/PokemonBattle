using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Mewtwo : Pokemon
    {
        public Mewtwo()
        {
            name = "Mewtwo";
            Random random = new Random();          
            HP = random.Next(322, 416);
            _image = Properties.Resources._150;
            Attack = random.Next(202, 350);
            Defense = random.Next(166, 306);
        }
    }
}
