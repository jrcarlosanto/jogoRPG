namespace Jogo_de_RPG.src.Entities
{
    class Wizard : Hero
    {
        public Wizard(string Name, int Level, int HP, int MP, string HeroType) : base(Name, Level, HP, MP, HeroType) 
        {
        }

        public override string Attack()
        {
            return this.Name + " " + "lançou magia";
        }

        public string Attack(int Bonus)
        {   if(Bonus > 6)
            {
                return this.Name + " " + "lançou magia super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " " + "lançou magia com força fraca com bonus de " + Bonus;
            }

        }
    }
}
