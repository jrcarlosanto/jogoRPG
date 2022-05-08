using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_RPG.src.Entities
{
    class Knight : Hero
    {
        public Knight(string Name, int Level, int HP, int MP , string HeroType) : base(Name, Level, HP, MP ,HeroType)
        {
        }
    }
}
