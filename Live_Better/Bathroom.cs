using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Better.Room.Mandatory
{
    // Bathroom class connected with Iinterior interface
    internal class Bathroom : Iinterior
    {
        // valueables
        protected internal int roomSize;
        protected internal int amountOfWindows;
        protected internal string windowType;
        protected internal int amountOfDoors;
        protected internal string doorType;
        protected internal bool floor;

        //Properties
        protected internal int RoomSize
        {
            get { return roomSize; }
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

        // constructor with default valuables
        protected internal Bathroom()
        {
            this.roomSize = 10;
            this.floor = true;
            this.amountOfDoors = 1;
            this.amountOfWindows = 1;
            this.doorType = "Interior Door";
            this.windowType = "1 Bay";
        }

    }
}
