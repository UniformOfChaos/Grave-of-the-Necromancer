using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOTN_Version_0._1
{
    class Level
    {
        // Exploration info
        private bool levelExplored;
        private float percentageExplored;
        private int roomCount;

        // Methods: generateLevel
        // METHODS GO HERE
    }

    class Room : Level
    {
        // Number of things in the room
        private int monsterCount; // Number of monsters in the room
        private int itemCount; //Number of items in the room

        // Number of grid squares in a room
        private int roomLength;
        private int roomWidth;
        private int roomArea; // roomArea = roomLength * roomWidth
        private int doorCount; // Number of doors in the room
    }
}
