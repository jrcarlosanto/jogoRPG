using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_RPG.src.Entities
{
    abstract class Hero
    {
        public Hero(string Name, int Level, int HP, int MP, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HP = HP;
            this.MP = MP;
            this.HeroType = HeroType;

        }

        public string Name;

        public int Level;

        public int HP;

        public int MP;

        public string HeroType;


        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " " + "atacou com sua espada";
        }

    }
}
