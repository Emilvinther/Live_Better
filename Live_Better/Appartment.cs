using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Better.Room.Mandatory;

namespace Live_Better
{
    // abstract class 
    internal abstract class Appartment
    {
        // Making instances of base rooms
        private Kitchen kitchen1 = new Kitchen();
        private LivingRoom livingroom1 = new LivingRoom();
        private Bathroom bathroom1 = new Bathroom();

        // Properties
        protected internal Kitchen Kitchen1
        {
            get { return kitchen1; }
            private set { kitchen1 = value; }
        }

        protected internal LivingRoom LivingRoom1
        {
            get { return livingroom1; }
           private set { livingroom1 = value; }
        }

        protected internal Bathroom Bathroom1
        {
            get { return bathroom1; }
           private set { bathroom1 = value; }
        }

        //Constructor

        protected internal Appartment()
        {
            
        }


        
    }
}
