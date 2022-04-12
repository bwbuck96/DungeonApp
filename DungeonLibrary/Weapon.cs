using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        //FIELDS
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;

        //PROPERTIES
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value <= MaxDamage && value > 0)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }

        //CONSTRUCTORS
        public Weapon() { }

        public Weapon(string name, bool isTwoHanded, int minDamage, int maxDamage, int bonusHitChance)
        {
            Name = name;
            IsTwoHanded = isTwoHanded;
            MaxDamage = maxDamage;
            BonusHitChance = BonusHitChance;
            MinDamage = minDamage;
        }

        //METHODS
        public override string ToString()
        {
            return string.Format("\t\t\t\tWEAPON STATS\n\n\nName: {0}\nGrip Style: {1}\nDamage Range: {2} - {3}\nBonus Hit Chance: {4}%", Name, IsTwoHanded ? "Two-Handed" : "One-Handed", MinDamage, MaxDamage, BonusHitChance);
        }
    }
}
