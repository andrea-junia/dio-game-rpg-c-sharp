using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio.rpg.oo
{
    public class Knigth : Hero
    {
        public Knigth(string Name, int Level, string HeroType)
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
            for (int i = 0; i <= (27 - Skill.Length); i++){
                temp += " ";
            }
            return temp;
        }
    }
}