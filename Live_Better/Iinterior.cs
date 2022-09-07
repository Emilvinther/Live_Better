using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Better
{

    // interface with windows, doors and floor
    internal interface Iinterior
    {
        public int AmountOfWindows
        {
            get;
        }

        public string WindowType
        {
            get; set;
        }

        public int AmountOfDoors
        {
            get;
        }

        public string DoorType
        {
            get; set;
        }

        public bool Floor
        {
            get;
        }


    }
}
