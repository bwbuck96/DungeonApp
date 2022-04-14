﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //The abstract modifier indicates that the thing being modified 

    public abstract class Character
    {
        //Fields
        private string _name;
        private int _hitChance;
        private int _block;
        private int _life;
        private int _maxLife;
        //Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
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

        //CTORs
        //Since you do NOT inherit CTORs AND we already did a lot of work defining the player FQCTOR, we will NOT create any here.

        //Methods
        //No need to override the ToString() here because we will never create an object of the type Character.

        //Below are methods we want to be inherited by player and monster, so we are creating default versions.
        //The child classes can use these default versions or override them.

        public virtual int CalcBlock()
        {
            //To be able to override this in a child class, it MUST be virtual.

            //Basic version of CalcBlock will just return the value stored in Block.
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0;
        }
    }
}