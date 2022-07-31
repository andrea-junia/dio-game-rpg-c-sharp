using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio.rpg.oo
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;  
        }

        public override string Attack(string Skill)
        {
            return " "+Skill+calcSpaces(Skill)+"|";
        }

        string calcSpaces(string Skill){

            var temp = "";
            for (int i = 0; i <= (19 - Skill.Length); i++){
                temp += " ";
            }
            return temp;
        }
        
      
        /*public string Attack(int Bonus)
        {
            if (Bonus > 10){
                return this.Name + " Lançou uma cura super efetiva com bonus de: " + Bonus;
            }
            else
            return this.Name + " Lançou uma cura com força fraca com bonus de: " + Bonus;
        }*/
    }
}
     