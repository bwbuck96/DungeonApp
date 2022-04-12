using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //public is an access modifier. It determines WHERE this class can be used in our application.
    //Since we want to make Player objects in our Dungeon Console App project, we need this class
    //to be public.
    public class Player
    {
        //FIELDS
        //Fields are nothing more than variables to store information related to this kind of object.
        //The access for fields is ALWAYS private.
        //Naming convention. _fieldName
        private string _playerName;
        private int _hitChance;
        private int _block;
        private int _life;
        private int _maxLife;
        private Race _characterRace;
        private Weapon _equippedWeapon;
        //PROPERTIES
        //Publicly available gatekeepers of the information in the fields.
        //Define the rules for interacting with the fields & their values.
        public string PlayerName
        {
            get { return _playerName; }
            set { _playerName = value; }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        public Race CharacterRace
        {
            get { return _characterRace; }
            set { _characterRace = value; }
        }
        public Weapon EquippedWeapon
        {
            get { return _equippedWeapon; }
            set { _equippedWeapon = value; }
        }

        //Properties and Fields that require Custom "Business Rules"
        //properties and fields that require business rules should come AFTER properties/fields that use the default.
        public int Life
        {
            get { return _life; }
            set
            {
                //Business rule example. Life should not be more than MaxLife
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else
                { _life = MaxLife; }
            } 
        }
        //CONSTRUCTORS!
        //Special methods used to create objects of this type.
        //Access is ALWAYS public
        //Naming Convention: PascalCase - MUST match the name of the class

        //Fully Qualified Constructor, All properties are accounted for with Parameters.
        
        public Player(string playerName, int block, int hitChance, int life, int maxLife, Race characterRace, Weapon equippedWeapon)
        {
            //ASSIGNMENT
            //Property = parameter;
            //PascalCase = camelCase;
            //Business Rule items should be at the bottom of the list.
            PlayerName = playerName;
            Block = block;
            HitChance = hitChance;
            MaxLife = maxLife;
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            Life = life; //Life depends on MaxLife, so MaxLife MUST be set first.

        }
        public override string ToString()
        {
            //  return base.ToString(); 
            string description = "";

            switch (CharacterRace)
            {
                case Race.Orc:
                    description = "Orc";

                    //Life += 5; ENUMS ARE GREAT!

                    break;
                case Race.Human:
                    description = "Human";
                    break;
                case Race.Elf:
                    description = "Elf";
                    break;
                case Race.Dwarf:
                    description = "Dwarf";
                    break;
                case Race.Gnome:
                    description = "Gnome";
                    break;
                case Race.Halfling:
                    description = "Halfling";
                    break;
                case Race.Tiefling:
                    description = "Tiefling";
                    break;
                case Race.Dragonborn:
                    description = "Dragonborn";
                    break;
            }

            return string.Format("\t\t\tPLAYER INFO\n xXxXx {0} xXxXx\n" +
                "Life: {1} of {2}\nHit Chance: {3}%\n" +
                "Weapon: \n{4}\nBlock: {5}\nDescription: {6}", 
                PlayerName,
                Life,
                MaxLife,
                HitChance,
                EquippedWeapon,
                Block,
                description);

        }

    }
}
