using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petSimulator
{
    class Pet
    {
        public void setScale(int s)
        {
            scale = s;
        }
        public void setHunger(int h)
        {
            hunger = h;
        }
        public int scale;
        public int hunger;
    }

    class Cow: Pet
    {
        public int getScale()
        {
            return scale;
        }
        public int getHunger()
        {
            return hunger;
        }
    }
}
