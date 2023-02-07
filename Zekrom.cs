using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Zekrom : Pokemon
    {
        public Zekrom()
        {
            name = "Zekrom";
            Random random = new Random();
            HP = random.Next(310, 404);
            _image = Properties.Resources._644;
            Attack = random.Next(274, 438);
            Defense = random.Next(220, 372);
        }
    }
}
