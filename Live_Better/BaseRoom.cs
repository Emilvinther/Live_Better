using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Better
{
    // BaseRoom class connected to Iinterior interface
    internal class BaseRoom : Iinterior
    {

        //valueables
        protected internal int roomSize;
        protected internal int amountOfWindows;
        protected internal string windowType;
        protected internal int amountOfDoors;
        protected internal string doorType;
        protected internal bool floor;

        // Properties
        protected internal int RoomSize
        {
            get { return roomSize; }
            set { roomSize = value; }
        }

        public int AmountOfWindows
        {
            get { return amountOfWindows; }
        }

        public string WindowType
        {
            get { return windowType; }
            set { windowType = value; }
        }
        public int AmountOfDoors
        {
            get { return amountOfDoors; }
        }
        public string DoorType
        {
            get { return doorType; }
            set { doorType = value; }
        }
        public bool Floor
        {
            get { return floor; }
        }

        // Constructor
        protected internal BaseRoom()
        {
            roomSize = 15;
            amountOfWindows = 1;
            windowType = "2 Bay";
            amountOfDoors = 1;
            doorType = "Interior Door";
            floor = true;
        }

    }
}
