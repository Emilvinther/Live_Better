using Live_Better.Room.Mandatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Better
{
    internal class FourRoom : ThreeRoom
    {

        // making new instance for room
        protected internal BaseRoom room3 = new BaseRoom();

        //Properties

        protected internal BaseRoom Room3
        {
            get { return room3; }
            set { room3 = value; }
        }

        // Constructor
        protected internal FourRoom() : base()
        {
            
        }
    }
}
