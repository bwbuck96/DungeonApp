using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        //Fields
        private int _minDamage;



        //Properties
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //can't be more than MaxDamage AND cannot be less than 1
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }


        //CTORs
        public Monster()
        {

        }

        public Monster(string name, int life, int maxLife, int hitChance, int block, int maxDamage, string description, int minDamage)
            //We have NO FQCTOR in the parent, so all assingments must be done here. We also must set MaxLife and MaxDamage first, 
            //because other properties depend on them having a value.
        {
            MaxLife = maxLife;
            MaxDamage = maxDamage;
            Name = name;
            Life = life;
            HitChance = hitChance;
            Block = block;
            MinDamage = minDamage;
            Description = description;

        }

        //Methods
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("\n***** MONSTER *****\n{0}\nLife: {1} of {2}\nDamage: {3} to {4}\n" +
                "Block: {5}\nDescription:\n{6}\n",Name, Life, MaxLife, MinDamage, MaxDamage, Block, Description);
        }

        public override int CalcDamage()
        {
            //return base.CalcDamage();
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
            
        }
    }
}
