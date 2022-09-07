using Live_Better.Room.Mandatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Better
{
    // Sealed class
    internal sealed class FiveRoom : FourRoom
    {
        // new instance of room
        internal BaseRoom room4 = new BaseRoom();

        // Properties
        internal BaseRoom Room4
        {
            get { return room4; }
            set { room4 = value; }
        }

        // Constructor
        internal FiveRoom() : base()
        {
            
        }
    }
}
