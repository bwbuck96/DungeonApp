using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //We CANNOT create an Enum through visualstudios interface directly.
    //Instead, we need to create a class, then change the Class keyword to Enum.


    public enum Race
    {
        //Single values, no spaces, comma separated
        Orc,
        Human,
        Elf,
        Dwarf,
        Gnome,
        Halfling,
        Tiefling,
        Dragonborn
    }
}
