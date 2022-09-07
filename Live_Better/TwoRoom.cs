using Live_Better.Room.Mandatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Live_Better
{
    internal class TwoRoom : Appartment
    {

        protected internal BaseRoom room1 = new BaseRoom();

        protected internal BaseRoom Room1
        {
            get { return room1; }
            set { room1 = value; }
        }

        protected internal TwoRoom() : base()
        {
            
        }
    }
}
