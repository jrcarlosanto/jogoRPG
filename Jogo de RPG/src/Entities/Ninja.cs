using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_RPG.src.Entities
{
    class Ninja : Hero
    {
        public Ninja(string Name, int Level, int HP, int MP, string HeroType) : base(Name, Level, HP, MP, HeroType) 
        {
        }

        public override string Attack()
        {
            return this.Name + " " + "atacou com suas shurikens";
        }

    }
}
