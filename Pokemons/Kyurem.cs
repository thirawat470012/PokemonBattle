using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Kyurem : Pokemon
    {
        public Kyurem()
        {
            name = "Kyurem";
            Random random = new Random();
            //random number between >= 360 and <454
            HP = random.Next(360,454);
            _image = Properties.Resources._646;
            Attack = random.Next(238, 394);
            Defense = random.Next(166, 306);
        }
    }
}
