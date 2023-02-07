using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{ 
    internal class Reshiram : Pokemon
    {
        public Reshiram()
        {
            name = "Reshiram";
            Random random = new Random();
            HP = random.Next(310, 404);
            _image = Properties.Resources._643;
            Attack = random.Next(184, 328);
            Defense = random.Next(184, 328);
        }
    }
}
