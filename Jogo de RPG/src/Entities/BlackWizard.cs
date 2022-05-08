using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_RPG.src.Entities
{
    class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, int HP, int MP, string HeroType) : base(Name, Level, HP, MP, HeroType) 
        {
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 10)
            {
                return this.Name + " " + "lançou um super efetivo debuff em area com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " " + "lançou um debuff no inimigo com bonus de " + Bonus;
            }

        }
    }
}
