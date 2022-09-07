using Live_Better.Room.Mandatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Better
{
    internal class ThreeRoom : TwoRoom
    {

        protected internal BaseRoom room2 = new BaseRoom();

        protected internal BaseRoom Room2
        {
            get { return room2; }
            set { room2 = value; }
        }


        protected internal ThreeRoom() : base()
        {
            
        }
    }
}
