using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Level
{
    public class Level
    {
        // Dungeon Architecture
        public enum Tile
        {
            Wall,
            Floor,
            Door
        }

        // Exploration info
        private bool levelExplored;
        private float percentageExplored;
        private int roomCount;

        //potential movements for pathfinding
        private static Point[] _movements = new Point[]    //initialising for 8-directional movement
            {
                new Point (-1, -1),
                new Point (0, -1),
                new Point (1, -1),
                new Point (1, 0),
                new Point (1, 1),
                new Point (0, 1),
                new Point (-1, 1),
                new Point (-1, 0)
            };

        class Room : Level
        {
            // Position of the room in worldspace
            public int roomX;
            public int roomY;

            // Number of grid squares in a room
            public int roomLength;
            public int roomWidth;

            //Number of entries to other rooms
            public Point[] corridorSeed;
        }

        class GridSquare
        {
            Tile _contentCode = Tile.Wall;
            public Tile ContentCode
            {
                get { return _contentCode; }
                set { _contentCode = value; }
            }
            int _distanceSteps = 100;
            public int DistanceSteps
            {
                get { return _distanceSteps; }
                set { _distanceSteps = value; }
            }
            bool _isPath;
            public bool IsPath
            {
                get { return _isPath; }
                set { _isPath = value; }
            }
        }

        /// <Will>
        /// Function for generating new dungeon layouts and architecture; part of
        /// the New Game functionality. Creates an array of rooms using the Rooms
        /// class; 
        /// Populating the dungeon is done later on.
        /// The architecture is based on the Grid Based Dungeon architecture 
        /// demonstrated on RogueBasin, seen here: 
        /// http://www.roguebasin.com/index.php?title=Grid_Based_Dungeon_Generator
        /// </Will>
        public static GridSquare[,] DungeonGeneration()
        {
            int     cellSize = 8;                           //size of each individual cell
            int     roomCount = 25;                         //total number of rooms generated on the grid.
            int     cellNo = 64/cellSize;             //total number of cells per side
            bool[,] _cellGrid = new bool[cellNo, cellNo];    //grid of cells used to generate room positions
            Room[] _roomInformation = new Room[roomCount];  //room information (see room class)
            GridSquare[,] _output = new GridSquare[64, 64]; //final output of the dungeon grid
            Random rnd = new Random();
            int i; //count variables
            int j;
            //Place room
            i = 0;
            while (i < roomCount)
            {
                int x = rnd.Next(cellNo); //determines a random room cell
                int y = rnd.Next(cellNo);
                if (_cellGrid[x,y] == false) //if it does not contain another room...
                {
                    //add a room to the cell
                    _cellGrid[x,y] = true;
                    _roomInformation[i] = new Room();
                    //determine room size and worldspace position
                    _roomInformation[i].roomLength = rnd.Next(4,7); 
                    _roomInformation[i].roomWidth = rnd.Next(4,7); 
                    _roomInformation[i].roomX = rnd.Next((x * cellSize) + (cellSize - _roomInformation[i].roomLength));
                    _roomInformation[i].roomY = rnd.Next((y * cellSize) + (cellSize - _roomInformation[i].roomWidth));
                    //increment the counter
                    i++;
                }
            }
            //Create rooms on map grid
            for (i = 0; i < roomCount; i++)
            {
                for (j = 0; j < _roomInformation[i].roomLength; j++)
                {
                    for (int k = 0; k < _roomInformation[i].roomWidth; k++) //k used as third counter.
                    {
                        //Creates floor tiles for each room, for each contained square.
                        _output[j + _roomInformation[i].roomX, k + _roomInformation[i].roomY].ContentCode = Tile.Floor;
                    }
                }
            }
            //Create corridors
            i = 0;
            j = 0;
            int roomNo = 0;
            int linkedRooms = 0;
            while (linkedRooms < roomCount)
            {
                //Choose two random rooms and a point within each
                roomNo = rnd.Next(roomCount);
                i = rnd.Next(_roomInformation[roomNo].roomLength);
                j = rnd.Next(_roomInformation[roomNo].roomWidth);
                int corridorCount = _roomInformation[roomNo].corridorSeed.Length;
                _roomInformation[roomNo].corridorSeed[corridorCount + 1] = new Point(i, j);
                Point room1Loc = new Point(i, j); //first point
                if (corridorCount == 0)
                { linkedRooms++; } //linkedRooms represents the number of rooms that have been linked to at least one other room. 
                roomNo = rnd.Next(roomCount);
                i = rnd.Next(_roomInformation[roomNo].roomLength);
                j = rnd.Next(_roomInformation[roomNo].roomWidth);
                corridorCount = _roomInformation[roomNo].corridorSeed.Length;
                _roomInformation[roomNo].corridorSeed[corridorCount + 1] = new Point(i, j);
                Point room2Loc = new Point(i, j); //second point
                if (corridorCount == 0)
                { linkedRooms++; }
                //Generate path from room1Loc to room2Loc

            }
            //Return completed dungeon
            return _output;
        }

        private static Tile[,] AStarCorridor(Point start, Point dest, GridSquare[,] _output)
        //thanks to dotnetpearls.com/pathfinding for this section.
        {
            _output[start.X, start.Y].DistanceSteps = 0;
            while (true)
            {
                bool madeProgress = false;
                for (int i = 0; i < 64; i++)
                {
                    for (int j = 0; j < 64; j++) //check every cell
                        if (_output[i, j].ContentCode == Tile.Wall) //check whether cell type is valid
                        {
                            int passHere = _output[i, j].DistanceSteps;
                            foreach (Point movePoint in _movements)
                            {
                                int x = movePoint.X;
                                int y = movePoint.Y;
                                int newPass = passHere + 1;
                                if (_output[x,y].DistanceSteps > newPass)
                                {
                                    _output[x, y].DistanceSteps = newPass;
                                    madeProgress = true;
                                }
                            }
                        }
                }
                if(!madeProgress)
                { break; }
            }
            //remove wall tiles to generate corridor
            while (true)
            {
                Point lowestPoint = Point.Empty;
                int lowest = 100;
                foreach (Point movePoint in ValidMoves(dest.X, dest.Y))
                {
                    int count = _output[dest.X, dest.Y].DistanceSteps;
                    if (count < lowest)
                    {
                        lowest = count;
                        lowestPoint.X = movePoint.X;
                        lowestPoint.Y = movePoint.Y;
                    }
                    if (lowest != 100)
                    { 
                        //mark the square as part of the path if it is the lowest number. Set the current position as that square.
                        _output[lowestPoint.X, lowestPoint.Y].IsPath = true;
                        _output[lowestPoint.X, lowestPoint.Y].ContentCode = Tile.Floor;
                        dest.X = lowestPoint.X;
                        dest.Y = lowestPoint.Y;
                    }
                    else
                    { break; }
                    Point currentCell = new Point(dest.X, dest.Y);
                    if (currentCell == dest)
                    { break; } //we've reached the destination cell.
                }
            }
        }

        private static IEnumerable<Point> ValidMoves(int x, int y)
        {
            foreach (Point movePoint in _movements)
            {
                int newX = x + movePoint.X;
                int newY = y + movePoint.Y;
                if (ValidCoordinates (newX, newY))
                {
                    yield return new Point(newX, newY);
                }
            }
        }

        private static bool ValidCoordinates(int x, int y)
        {
            if (x < 0)
            { return false; }
            if (y < 0)
            { return false; }
            if (x > 64)
            { return false; }
            if (y > 64)
            { return false; }
            return true;
        }
    }
}
